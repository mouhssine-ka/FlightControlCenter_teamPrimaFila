using FlightSimulatorControlCenter.Model.DB;
using FlightSimulatorControlCenter.Model.Flotta;
using FlightSimulatorControlCenter.Service.Int;
using System.ComponentModel;

namespace FlightSimulatorControlCenter
{
    public partial class FleetManager : Form
    {
        private IValidationUserInputService _validationService;
        private BindingList<FlottaTableModel> flotte = new BindingList<FlottaTableModel>();

        public MainWindow FormPrincipale { get; set; }

        public FleetManager(IValidationUserInputService validationService)
        {
            InitializeComponent();
            _validationService = validationService;

            InitalizeAereiDataGridFromDBModel();

            // Cambio label tabella
            //tabellaAerei.Columns[0].HeaderText = "Id Aereo";
            //tabellaAerei.Columns[0].Name = "IdAereo";

            //tabellaAerei.Columns[1].HeaderText = "Cod Aereo";
            //tabellaAerei.Columns[1].Name = "Codice";

            //tabellaAerei.Columns[2].HeaderText = "Colore";
            //tabellaAerei.Columns[2].Name = "Colore";

            //tabellaAerei.Columns[3].HeaderText = "Num. Posti";
            //tabellaAerei.Columns[3].Name = "NumeroDiPosti";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Aggiorno la flotta selezionata sul db
            int row = tabellaFlotte.CurrentRow.Index;
            var flottaTableSelezionata = flotte[row];

            var flottaBlSelezionata = FakeDB.GetFlottaSelezionataById(flottaTableSelezionata.Id);
            FakeDB.ImpostaFlottaSelezionata(flottaBlSelezionata);

            // Chiedo alla form main di aggiornare la label della flotta selezionata
            FormPrincipale.AggiornaFlottaSelezionataLabel();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            InitalizeAereiDataGridFromDBModel();
        }

        private void InitalizeAereiDataGridFromDBModel() {
            flotte = new BindingList<FlottaTableModel>();

            foreach (var f in FakeDB.Flotte)
            {
                var temp = FlottaTableModel.FlottaTableModelFactory(f.IdFlotta, f.Nome, f.Aerei.Count, "Attiva");
                flotte.Add(temp);
            }

            var source = new BindingSource(flotte, null);

            // Binding data source
            tabellaFlotte.DataSource = source;

            // Fit colonne a size tabella
            tabellaFlotte.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tabellaFlotte.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

        }
    }
}
