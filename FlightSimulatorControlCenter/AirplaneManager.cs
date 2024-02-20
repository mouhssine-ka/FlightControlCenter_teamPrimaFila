using Clients.ImpiantiClient;
using FlightSimulatorControlCenter.Helper;
using FlightSimulatorControlCenter.Model.Aereo;
using FlightSimulatorControlCenter.Model.DB;
using FlightSimulatorControlCenter.Model.Event;
using FlightSimulatorControlCenter.Model.Flotta;
using FlightSimulatorControlCenter.Service.Int;
using System.ComponentModel;
using System.Text;

namespace FlightSimulatorControlCenter
{
    public partial class AirplaneManager : Form
    {
        // Eventi esposti dalla Form
        public event AirplaneCreatedEvent AirPlaneCreated;
        public event AirplaneUpdatedEvent AirPlaneUpdated;
        public event AirplaneDeletedEvent AirPlaneDeleted;

        private IValidationUserInputService _validationService;    
        private IExternalServicesService _externalService;
        private IConversionModelService _conversionService;

        //Stato inizializzazione mancante
        private long idFlottaAttiva = -1;
        private FlottaBl flottaAttiva;

        private CreazioneAereo creazioneAereoForm;

        public AirplaneManager(long idFLottaAttiva, IValidationUserInputService validationService, IExternalServicesService externalService, IConversionModelService conversionService)
        {
            InitializeComponent();
            _validationService = validationService;
            _externalService = externalService;
            _conversionService = conversionService;

            idFlottaAttiva = idFLottaAttiva;
        }

        private void Step1Init_Load(object sender, EventArgs e)
        {   
            RetrieveAndUpdateFleetData();
            CheckUIElementToEnableDisable();
        }       

        private void creaAereo_Click(object sender, EventArgs e)
        {
            // Apro la form di creazione
            if (!FormUtils.FormIsOpen("CreazioneAereo"))
            {
                creazioneAereoForm = new CreazioneAereo(_validationService);
                creazioneAereoForm.AirplaneCreateReq += (string codice, string colore, long numPosti) => {
                    // Creo la request
                    var req = new CreateAereoRequest();                    
                    req.IdFLotta = flottaAttiva.IdFlotta;
                    req.CodiceAereo = codice;
                    req.Colore = colore;
                    req.NumeroDiPosti = numPosti;

                    // Eseguo la chiamata
                    var aereoApi = _externalService.AereoPOSTAsync(req);

                    // converto il modello 
                    var aereoBlCreato = _conversionService.ConvertToBl(aereoApi);

                    // Mando l'evento
                    this.AirPlaneCreated(aereoBlCreato);

                    // Chiudo la form
                    creazioneAereoForm.Close();

                    // Richiedo l'aggiornamento della tabella
                    RetrieveAndUpdateFleetData();
                };
                creazioneAereoForm.Show();
            }            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RetrieveAndUpdateFleetData();
        }

        public void RequestUpdateData() {
            RetrieveAndUpdateFleetData();          
        }

        public void UpdateSelectedFleet(FlottaBl flotta)
        {
            idFlottaAttiva = flotta.IdFlotta;
            CheckUIElementToEnableDisable();
            RetrieveAndUpdateFleetData();
        }

        // Controllo se e' selezionata una flotta e attivo disattivo i controlli
        private void CheckUIElementToEnableDisable()
        {
            if (idFlottaAttiva != -1)
            {
                this.creaAereo.Enabled = true;
                this.aggiornaDati.Enabled = true;
                this.modificaAereo.Enabled = true;
                this.cancellaAereo.Enabled = true;
            }
            else {
                this.creaAereo.Enabled = false;
                this.aggiornaDati.Enabled = false;
                this.modificaAereo.Enabled = false;
                this.cancellaAereo.Enabled = false;
            }
        }

        private void RetrieveAndUpdateFleetData()
        {
            if (idFlottaAttiva != -1)
            {
                flottaAttiva = RetrieveFleetData();
                InitalizeAereiDataGridFromDBModel();
                UpdateLabelOfSelectedFleet();
            }
            else
            {
                MessageBox.Show("Seleziona una flotta prima di gestire gli aerei!");
            }           
        }      

        // Recupero l'elenco delle flotte dal server
        private FlottaBl RetrieveFleetData()
        {
            // Recupero la flotta
            var result = _externalService.GetFlottaAsync(idFlottaAttiva);

            // Converto la risposta nei modelli Bl
            var flotteBl = _conversionService.ConvertToBl(result);

            return flotteBl;
        }

        private void InitalizeAereiDataGridFromDBModel()
        {
            var result = new BindingList<AereoBl>();

            foreach (var a in flottaAttiva.Aerei)
            {
                result.Add(a);
            }

            var source = new BindingSource(result, null);

            // Binding data source
            tabellaAerei.DataSource = source;

            // Fit colonne a size tabella
            tabellaAerei.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tabellaAerei.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

            // Cambio label tabella
            tabellaAerei.Columns[0].HeaderText = "Id Aereo";
            tabellaAerei.Columns[0].Name = "IdAereo";

            tabellaAerei.Columns[1].HeaderText = "Cod Aereo";
            tabellaAerei.Columns[1].Name = "Codice";

            tabellaAerei.Columns[2].HeaderText = "Colore";
            tabellaAerei.Columns[2].Name = "Colore";

            tabellaAerei.Columns[3].HeaderText = "Num. Posti";
            tabellaAerei.Columns[3].Name = "NumeroDiPosti";
        }

        private void UpdateLabelOfSelectedFleet()
        {
            label5.Text = flottaAttiva.Nome;
        }       
    }
}
