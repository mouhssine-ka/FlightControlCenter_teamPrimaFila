namespace FlightSimulatorControlCenter.Model.Flotta
{
    public class FlottaTableModel
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public long NumAerei { get; set; }
        public string Stato { get; set; }

        public FlottaTableModel(long id, string nome, long numAerei, string stato) {
            Id = id;
            Nome = nome;
            NumAerei = numAerei;
            Stato = stato;
        }

        public static FlottaTableModel FlottaTableModelFactory(long idFlotta, string nome, long numAerei, string stato) {
            return new FlottaTableModel(idFlotta, nome, numAerei, stato);
        }
    }
}
