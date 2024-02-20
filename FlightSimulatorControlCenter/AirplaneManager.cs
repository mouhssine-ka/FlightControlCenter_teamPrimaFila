using Clients.ImpiantiClient;
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
        private static FlottaBl FlottaSelezionata;

        public AirplaneManager(IValidationUserInputService validationService, FlottaBl flottaSelezionata)
        {
            InitializeComponent();
            FlottaSelezionata = flottaSelezionata;
            _validationService = validationService;
        }

        private void Step1Init_Load(object sender, EventArgs e)
        {
            // Def data source
            InitalizeFlotteDataGrid();
            UpdateLabelOfSelectedFleet();           
        }       

        private void creaAereo_Click(object sender, EventArgs e)
        {
            // Recupero campi form
            var formCodice = this.txtBoxCodice.Text;
            var formColore = this.txtBoxColore.Text;
            var formNumeroDiPosti = this.txtBoxNumPosti.Text;

            // Valido l'input
            var esistoValidazione = _validationService.ValidateUserInputForAirplaneCreation(formCodice, formColore, formNumeroDiPosti);

            if (esistoValidazione.IsValid())
            {
                // X Ragazzi, perchè non mi faccio ritornare direttamente il modello dell'aereo dall'esito validazione
                // Salvo in locale
                var a1 = AereoBl.AereoBlCreateFactory(esistoValidazione.Codice, esistoValidazione.Colore, esistoValidazione.NumeroDiPosti);
                //FakeDB.FlottaSelezionata.Aerei.Add(a1);

                // Mando l'evento
                this.AirPlaneCreated(a1);


                // Qui faro la mia chiamata in remoto
                AddAereoAllaFlotta(a1);
            }
            else {
                var messaggeToshow = new StringBuilder();
                messaggeToshow.Append("Prima di procedere correggere i seguenti errori:\n\r");

                foreach (var message in esistoValidazione.ValidationErrors)
                {
                    messaggeToshow.Append(message + "\n\r");
                }

                messaggeToshow.Append("Grazie!\n\r");

                MessageBox.Show(messaggeToshow.ToString());
            }
        }
        public void AddAereoAllaFlotta(AereoBl aereo)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:5093/");
            Client clientImpianto = new(client);

            CreateAereoRequest request = new CreateAereoRequest();
            request.IdFLotta = FlottaSelezionata.IdFlotta;
            request.NumeroDiPosti = aereo.NumeroDiPosti;
            request.CodiceAereo = aereo.Codice;
            request.Colore = aereo.Colore;
            

            var flottaResult = clientImpianto.AereoPOSTAsync(request);
            
        }
        public void RequestUpdateData() {
            InitalizeFlotteDataGrid();
            UpdateLabelOfSelectedFleet();
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        private void InitalizeFlotteDataGrid()
        {
            var result = new BindingList<AereoBl>();

            //if(FlottaSelezionata != null)
            //{
                foreach (var a in FlottaSelezionata.Aerei)
                {
                    result.Add(a);
                }
            //}


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
            label5.Text = FlottaSelezionata?.Nome;
        }
    }
}
