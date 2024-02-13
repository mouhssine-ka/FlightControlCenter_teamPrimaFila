using FlightSimulatorControlCenter.Model.Aereo;
using FlightSimulatorControlCenter.Service.Int;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;

namespace FlightSimulatorControlCenter
{
    public partial class AirplaneManager : Form
    {
        private IValidationUserInputService _validationService;
        private BindingList<AereoBl> aerei;

        private string NomeFlotta = string.Empty;
        private long IdFlotta = 0;

        public AirplaneManager(IValidationUserInputService validationService, string nomeFlotta, long idFlotta)
        {
            InitializeComponent();
            _validationService = validationService;

            NomeFlotta = nomeFlotta;
            IdFlotta = idFlotta;
        }

        private void Step1Init_Load(object sender, EventArgs e)
        {
            // Def data source
            aerei = new BindingList<AereoBl>();
            var source = new BindingSource(aerei, null);

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

            label5.Text = NomeFlotta;
        }

        private void creaAereo_Click(object sender, EventArgs e)
        {
            // Recupero campi form
            var formCodice = this.textBox1.Text;
            var formColore = this.textBox2.Text;
            var formNumeroDiPosti = this.textBox3.Text;

            // Valido l'input
            var esistoValidazione = _validationService.ValidateUserInputForAirplaneCreation(formCodice, formColore, formNumeroDiPosti);

            if (esistoValidazione.IsValid())
            {
                // X Ragazzi, perchè non mi faccio ritornare direttamente il modello dell'aereo dall'esito validazione
                // Salvo in locale
                var a1 = AereoBl.AereoBlCreateFactory(esistoValidazione.Codice, esistoValidazione.Colore, esistoValidazione.NumeroDiPosti);
                aerei.Add(a1);

                // Qui faro la mia chiamata in remoto
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

        private void button2_Click(object sender, EventArgs e)
        {
            // Chiamata di aggiornamento della lista di aerei nella tabella
            //MainWindow flottaForm = new MainWindow();
            //this.Hide();
            //flottaForm.ShowDialog();
            //this.Close();


            //flottaForm.TopLevel = false;
            //this.Controls.Add(flottaForm);
            //flottaForm.Show();
        }
    }
}
