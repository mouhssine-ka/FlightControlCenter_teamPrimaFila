using FlightSimulatorControlCenter.Model.Aereo;

namespace FlightSimulatorControlCenter.Model.Flotta
{
    public class FlottaBl
    {
        public long IdFlotta { get; set; }
        public string Nome { get; set; }
        public string Stato { get; set; }
        public List<AereoBl> Aerei { get; set; }

        public FlottaBl(long idFlotta, string nome, string stato, List<AereoBl> aerei) {
            IdFlotta = idFlotta;
            Nome = nome;
            Stato = stato;
            Aerei = aerei;
        }

        public static FlottaBl FlottaBlFactory(long idFlotta, string nome, string stato, List<AereoBl> aerei) {
            return new FlottaBl(idFlotta, nome, stato, aerei);
        }

        public void AddAereo(AereoBl aereobl) {
            this.Aerei.Add(aereobl);
        }
    }
}
