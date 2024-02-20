using Clients.ImpiantiClient;
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

        public static List<FlottaApi> flotteResult = new List<FlottaApi>();
        private IValidationUserInputService _validationService;
        private BindingList<FlottaTableModel> flotte = new BindingList<FlottaTableModel>();

        public MainWindow FormPrincipale { get; set; }

        public FleetManager(IValidationUserInputService validationService)
        {
            InitializeComponent();
            _validationService = validationService;

            flotteResult = GetListaFlotte();
            InitalizeFlotteDataGrid();
        }
        public static FlottaApi GetFlottaSelezionataById(long id)
        {
            return flotteResult.Single(x => x.IdFlotta == id);
        }
        private void selezionaFlotta_Click(object sender, EventArgs e)
        {
            // Aggiorno la flotta selezionata sul db
            int row = tabellaFlotte.CurrentRow.Index;
            var flottaTableSelezionata = flotte[row];

            var flottaSelezionata = GetFlottaSelezionataById(flottaTableSelezionata.Id);

            var flottaBlSelezionata = FlottaBl.FlottaBlFactory(flottaSelezionata.IdFlotta, flottaSelezionata.Nome, "attiva", new List<Model.Aereo.AereoBl>());
            
            
            //var flottaBlSelezionata = FakeDB.GetFlottaSelezionataById(flottaTableSelezionata.Id);
            //FakeDB.ImpostaFlottaSelezionata(flottaBlSelezionata);

            // Mando l'evento
            this.FleetSelected(flottaBlSelezionata);
        }

        public void RequestUpdateData()
        {
            InitalizeFlotteDataGrid();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            flotteResult = GetListaFlotte();
            InitalizeFlotteDataGrid();
        }
        private List<FlottaApi> GetListaFlotte()
        {
            flotte = new BindingList<FlottaTableModel>();

            var client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:5093/");
            Client clientImpianto = new(client);

            var flotteApi = clientImpianto.GetElencoFlotteAsync();
            List<FlottaApi> flotteResult = flotteApi.Result.ToList();

            return flotteResult;
        }
        private void InitalizeFlotteDataGrid()
        {
            foreach (var f in flotteResult)
            {
                var temp = FlottaTableModel.FlottaTableModelFactory(f.IdFlotta, f.Nome, f.Aerei.Count, "Attiva");
                flotte.Add(temp);
            }

            //foreach (var f in FakeDB.Flotte)
            //{
            //    var temp = FlottaTableModel.FlottaTableModelFactory(f.IdFlotta, f.Nome, f.Aerei.Count, "Attiva");
            //    flotte.Add(temp);
            //}

            var source = new BindingSource(flotte, null);

            // Binding data source
            tabellaFlotte.DataSource = source;

            // Fit colonne a size tabella
            tabellaFlotte.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tabellaFlotte.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nomeFl = txtBox_NomeFlotta.Text;

            var client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:5093/");
            Client clientImpianto = new(client);
            var request = new CreateFlottaRequest();
            request.Nome = nomeFl;
            var flottaGenerata = clientImpianto.FlottaPOSTAsync(request);

            //FlottaBl.FlottaBlFactory(flottaGenerata.Id,flottaGenerata.nome);

            flotteResult = GetListaFlotte();
            InitalizeFlotteDataGrid();
        }
        private async void GetFlottaSelezionataByID(int id)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:5093/");
            Client clientImpianto = new Client(client);

            var flottaSelezionata = await clientImpianto.FlottaGETAsync(id);
            if (flottaSelezionata != null)
            {
                FlottaBl flotta = FlottaBl.FlottaBlFactory(flottaSelezionata.IdFlotta, flottaSelezionata.Nome, "attiva", new List<Model.Aereo.AereoBl>());
                this.FleetSelected(flotta);
            }
        }

        private void tabellaFlotte_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
