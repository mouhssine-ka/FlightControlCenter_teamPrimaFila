namespace FlightSimulatorControlCenter.Model.Aereo
{
    // Classe di appoggio da spostare
    public class AereoBl
    {
        public long IdAereo { get; set; }
        public string Codice { get; set; }
        public string Colore { get; set; }
        public long NumeroDiPosti { get; set; }

        public AereoBl()
        {
        }

        protected AereoBl(long idAereo, string codice, string colore, long numeroDiPosti)
        {
            this.IdAereo = idAereo;
            this.Codice = codice;
            this.Colore = colore;
            this.NumeroDiPosti = numeroDiPosti;
        }

        public static AereoBl AereoBlFactory(long idAereo, string codice, string colore, long numeroDiPosti)
        {
            return new AereoBl(idAereo, codice, colore, numeroDiPosti);
        }

        public static AereoBl AereoBlCreateFactory(string codice, string colore, long numeroDiPosti)
        {
            return new AereoBl(0, codice, colore, numeroDiPosti);
        }
    }
}
