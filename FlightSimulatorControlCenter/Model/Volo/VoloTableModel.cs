using FlightSimulatorControlCenter.Model.Aereo;

namespace FlightSimulatorControlCenter.Model.Volo
{
    public class VoloTableModel
    {
        public long IdVolo { get; set; }
        public long AereoId { get; set; }
        public long PostiRimanenti { get; set; }
        public decimal CostoDelPosto { get; set; }
        public string CittaPartenza { get; set; }
        public string CittaArrivo { get; set; }
        public DateTime OrarioPartenza { get; set; }
        public DateTime OrarioArrivo { get; set; }

        public VoloTableModel(long idVolo, long aereoId, long postiRimanenti, decimal costoDelPosto,
            string cittaPartenza, string cittaArrivo, DateTime orarioPartenza, DateTime orarioArrivo)
        {
            this.IdVolo = idVolo;
            this.AereoId = aereoId;
            this.PostiRimanenti = postiRimanenti;
            this.CostoDelPosto = costoDelPosto;
            this.CittaPartenza = cittaPartenza;
            this.CittaArrivo = cittaArrivo;
            this.OrarioPartenza = orarioPartenza;
            this.OrarioArrivo = orarioArrivo;
        }

        public static VoloTableModel VoloTableModelFactory(long idVolo, long aereoId, long postiRimanenti, decimal costoDelPosto,
            string cittaPartenza, string cittaArrivo, DateTime orarioPartenza, DateTime orarioArrivo)
        {
            return new VoloTableModel (idVolo, aereoId,  postiRimanenti,  costoDelPosto,
             cittaPartenza,  cittaArrivo,  orarioPartenza,  orarioArrivo);
        }
    }
}
