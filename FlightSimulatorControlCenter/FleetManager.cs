using Clients.ImpiantiClient;
using FlightSimulatorControlCenter.Helper;
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

        private AggiungiFlotta formCreazioneFlotta;

        private List<FlottaBl> _elencoFlotte = new List<FlottaBl>();

        private IValidationUserInputService _validationService;
        private IExternalServicesService _externalService;
        private IConversionModelService _conversionService;

        private BindingList<FlottaTableModel> flotte = new BindingList<FlottaTableModel>();

        public MainWindow FormPrincipale { get; set; }

        public FleetManager(IValidationUserInputService validationService, IExternalServicesService externalService, IConversionModelService conversionService)
        {
            InitializeComponent();
            _validationService = validationService;
            _externalService = externalService;
            _conversionService = conversionService;

            _elencoFlotte = RetrieveFleetData();
            InitalizeAereiDataGridFromDBModel();
        }

        // Recupero l'elenco delle flotte dal server
        private List<FlottaBl> RetrieveFleetData()
        {
            // Recupero la flotta
            var result =  _externalService.GetElencoFlotteAsync();

            // Converto la risposta nei modelli Bl
            var flotteBl = _conversionService.ConvertToBl(result);

            return flotteBl;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Aggiorno la flotta selezionata sul db
            int row = tabellaFlotte.CurrentRow.Index;
            var flottaTableSelezionata = flotte[row];

            // Recupero la flotta bl selezionata
            var flottaBlSelezionata = _elencoFlotte.Single(x => x.IdFlotta == flottaTableSelezionata.Id);        

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

        private void RetrieveAndUpdateFleetData() {
            _elencoFlotte = RetrieveFleetData();
            InitalizeAereiDataGridFromDBModel();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Apro la form di creazione
            if (!FormUtils.FormIsOpen("AggiungiFlotta"))
            {
                formCreazioneFlotta = new AggiungiFlotta(_validationService);
                formCreazioneFlotta.FleetCreateReq += (string nomeFlotta) =>  {
                    // Creo la request
                    var req = new CreateFlottaRequest();
                    req.Nome = nomeFlotta;

                    // Eseguo la chiamata
                    var flottaApi = _externalService.FlottaPOSTAsync(req);

                    // converto il modello 
                    var flottaBlCreata = _conversionService.ConvertToBl(flottaApi);

                    // Mando l'evento
                    this.FleetSelected(flottaBlCreata);

                    // Chiudo la form
                    formCreazioneFlotta.Close();

                    // Richiedo l'aggiornamento della tabella
                    RetrieveAndUpdateFleetData();
                };
                formCreazioneFlotta.Show();
            }      
        }
    }
}
