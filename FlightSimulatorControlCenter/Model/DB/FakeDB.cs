using FlightSimulatorControlCenter.Model.Aereo;
using FlightSimulatorControlCenter.Model.Flotta;

namespace FlightSimulatorControlCenter.Model.DB
{
    public static class FakeDB
    {
        public static List<FlottaBl> Flotte { get; set; } = new List<FlottaBl>();
        public static FlottaBl FlottaSelezionata { get; set; }

        public static void AggiungiFlotta(FlottaBl flotta) {
            Flotte.Add(flotta);
        }

        public static void ImpostaFlottaSelezionata(FlottaBl flotta)
        {
            FlottaSelezionata = flotta;
        }

        public static FlottaBl GetFlottaSelezionataById(long id)
        {
            return Flotte.Single(x=> x.IdFlotta == id);
        }

        public static AereoBl GetAereoSelezionataByIdAereo(long idAereo)
        {
            return Flotte.SelectMany(x=> x.Aerei).Single(x => x.IdAereo == idAereo);
        }

        public static AereoBl DeleteAereoSelezionataByIdAereo(long idAereo)
        {
            long flottaId = 0;
            AereoBl aereo = null;

            foreach (var f in Flotte)
            {
                if (f.Aerei.Exists(x => x.IdAereo == idAereo)) {
                    flottaId = f.IdFlotta;
                    aereo = f.Aerei.Single(x => x.IdAereo == idAereo);

                    break;
                }
            }

            var fl = GetFlottaSelezionataById(flottaId);
            fl.Aerei.Remove(aereo);

            return aereo;
        }
    }
}
