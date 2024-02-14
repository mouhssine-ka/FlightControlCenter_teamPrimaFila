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
    }
}
