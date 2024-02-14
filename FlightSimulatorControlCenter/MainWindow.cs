using FlightSimulatorControlCenter.Helper;
using FlightSimulatorControlCenter.Model.DB;
using FlightSimulatorControlCenter.Service.Int;

namespace FlightSimulatorControlCenter
{
    public partial class MainWindow : Form
    {
        private IValidationUserInputService _validationService;

        private string NomeFlottaSelezionata = "Flotta non selezionata";
        private long IdFlottaSelezionata = 0;
        private ToolStripLabel LabelFlottaSelezionata;

        public MainWindow(IValidationUserInputService validationService)
        {
            InitializeComponent();
            _validationService = validationService;

            LabelFlottaSelezionata = new ToolStripLabel(NomeFlottaSelezionata);
            LabelFlottaSelezionata.Alignment = ToolStripItemAlignment.Right;
            LabelFlottaSelezionata.Padding = new Padding(0, 0, 20, 0);

            menuStrip1.Items.Add(LabelFlottaSelezionata);
        }

        private void airplaneManager_Click(object sender, EventArgs e)
        {
            if (!FormUtils.FormIsOpen("AirplaneManager"))
            {
                var airm = new AirplaneManager(_validationService, NomeFlottaSelezionata, IdFlottaSelezionata);
                airm.MdiParent = this;
                airm.Show();
            }
        }

        private void fleetManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!FormUtils.FormIsOpen("FleetManager"))
            {
                var fleetmanager = new FleetManager(_validationService);
                fleetmanager.MdiParent = this;
                fleetmanager.FormPrincipale = this;
                fleetmanager.Show();
            }
        }

        public void AggiornaFlottaSelezionataLabel()
        {
            // Aggiorno la label nella schermata principale
            menuStrip1.Items.Remove(LabelFlottaSelezionata);

            LabelFlottaSelezionata = new ToolStripLabel(FakeDB.FlottaSelezionata.Nome);
            LabelFlottaSelezionata.Alignment = ToolStripItemAlignment.Right;
            LabelFlottaSelezionata.Padding = new Padding(0, 0, 20, 0);
            menuStrip1.Items.Add(LabelFlottaSelezionata);
        }      
    }
}
