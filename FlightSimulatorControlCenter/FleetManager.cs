using FlightSimulatorControlCenter.Model.DB;
using FlightSimulatorControlCenter.Model.Event;
using FlightSimulatorControlCenter.Model.Flotta;
using FlightSimulatorControlCenter.Service.Int;
using System.ComponentModel;

namespace FlightSimulatorControlCenter
{
    public partial class FleetManager : Form
    {
        // Eventi esposti dalla Form
        public event FleetSelectedEvent FleetSelected;
        public event FleetUpdatedEvent FleetUpdated;
        public event FleetCreatedEvent FleetCreated;

        private IValidationUserInputService _validationService;
        private BindingList<FlottaTableModel> flotte = new BindingList<FlottaTableModel>();

        public MainWindow FormPrincipale { get; set; }

        public FleetManager(IValidationUserInputService validationService)
        {
            InitializeComponent();
            _validationService = validationService;

            InitalizeAereiDataGridFromDBModel();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Aggiorno la flotta selezionata sul db
            int row = tabellaFlotte.CurrentRow.Index;
            var flottaTableSelezionata = flotte[row];

            var flottaBlSelezionata = FakeDB.GetFlottaSelezionataById(flottaTableSelezionata.Id);
            FakeDB.ImpostaFlottaSelezionata(flottaBlSelezionata);

            // Mando l'evento
            this.FleetSelected(flottaBlSelezionata);
        }

        public void RequestUpdateData() {
            InitalizeAereiDataGridFromDBModel();
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
