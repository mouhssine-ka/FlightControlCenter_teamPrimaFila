using Clients.ImpiantiClient;
using FlightSimulatorControlCenter.Model.Aereo;
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

        private List<FlottaApi> _elencoFlotte = new List<FlottaApi>();

        private IValidationUserInputService _validationService;
        private BindingList<FlottaTableModel> flotte = new BindingList<FlottaTableModel>();

        public MainWindow FormPrincipale { get; set; }

        public FleetManager(IValidationUserInputService validationService)
        {
            InitializeComponent();
            _validationService = validationService;

            _elencoFlotte = RetrieveFleetData();
            InitalizeAereiDataGridFromDBModel();
        }

        // Recupero l'elenco delle flotte dal server
        private List<FlottaApi> RetrieveFleetData()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:5093/");
            Client clientImpianto = new(client);
            var t = clientImpianto.GetElencoFlotteAsync();
            t.Wait();

            // Converto nel modello bl

            return t.Result.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Aggiorno la flotta selezionata sul db
            int row = tabellaFlotte.CurrentRow.Index;
            var flottaTableSelezionata = flotte[row];

            var fleetApi = _elencoFlotte.Single(x => x.IdFlotta == flottaTableSelezionata.Id);
            // Converto in modello bl -> SubService per la conversione
            var aereiBl = fleetApi.Aerei.Select(x => AereoBl.AereoBlFactory(x.IdAereo, x.CodiceAereo, x.Colore, x.NumeroDiPosti)).ToList();
            var flottaBlSelezionata = FlottaBl.FlottaBlFactory(fleetApi.IdFlotta, fleetApi.Nome, "Attivo", aereiBl);

            //var flottaBlSelezionata = FakeDB.GetFlottaSelezionataById(flottaTableSelezionata.Id);
            //FakeDB.ImpostaFlottaSelezionata(flottaBlSelezionata);

            // Mando l'evento
            this.FleetSelected(flottaBlSelezionata);
        }

        public void RequestUpdateData()
        {
            InitalizeAereiDataGridFromDBModel();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            InitalizeAereiDataGridFromDBModel();
        }

        private void InitalizeAereiDataGridFromDBModel()
        {
            flotte = new BindingList<FlottaTableModel>();

            foreach (var f in _elencoFlotte)
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

        private void button1_Click(object sender, EventArgs e)
        {
            var nomeFlotta = textBox1.Text;

            var client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:5093/");
            Client clientImpianto = new(client);
            var req = new CreateFlottaRequest();
            req.Nome = nomeFlotta;
            var t = clientImpianto.FlottaPOSTAsync(req);
            t.Wait();

            var flottaCreataApi = t.Result;

            // Converto in modello bl -> SubService per la conversione
            var aereiBl = flottaCreataApi.Aerei.Select(x => AereoBl.AereoBlFactory(x.IdAereo, x.CodiceAereo, x.Colore, x.NumeroDiPosti)).ToList();
            var flottaBlSelezionata = FlottaBl.FlottaBlFactory(flottaCreataApi.IdFlotta, flottaCreataApi.Nome, "Attivo", aereiBl);

            _elencoFlotte = RetrieveFleetData();
            InitalizeAereiDataGridFromDBModel();

            // Mando l'evento
            this.FleetSelected(flottaBlSelezionata);
        }
    }
}
