using FlightSimulatorControlCenter.Model.Aereo;
using FlightSimulatorControlCenter.Model.Event;

namespace FlightSimulatorControlCenter
{
    public partial class ModificaAereo : Form
    {
        public event AirplaneExecuteModifyEvent AirplaneModifyReq;

        private long idFlottaSelezioanta;
        private long idAereo;
        private string codiceAereo;

        public ModificaAereo(long idFlotta, AereoBl areoToModify)
        {
            InitializeComponent();

            // Setto i valori dell'int
            idFlottaSelezioanta = idFlotta;
            idAereo = areoToModify.IdAereo;
            codiceAereo = areoToModify.Codice;

            idAereoLabel.Text = idAereo.ToString();
            codiceAereoLabel.Text = codiceAereo;

            coloreAereoText.Text = areoToModify.Colore;
            numPostiText.Text = areoToModify.NumeroDiPosti.ToString();
        }

        private void modificaButton_Click(object sender, EventArgs e)
        {
            // Recupero dati
            var colore = coloreAereoText.Text;
            var numeroDiPosti = numPostiText.Text;

            // Valido l'input
            //var esistoValidazione = _validationService.ValidateUserInputForAirplaneModify(codice, colore, numeroDiPosti);

            //if (esistoValidazione.IsValid())
            //{
                // Notifico la richiesta di creazione aereo
                this.AirplaneModifyReq(idFlottaSelezioanta, idAereo, codiceAereo, colore, long.Parse(numeroDiPosti));
            //}
            //else
            //{
            //    // se ci sono errori li mostro
            //    var messaggeToshow = new StringBuilder();
            //    messaggeToshow.Append("Prima di procedere correggere i seguenti errori:\n\r");

            //    foreach (var message in esistoValidazione.ValidationErrors)
            //    {
            //        messaggeToshow.Append(message + "\n\r");
            //    }

            //    messaggeToshow.Append("Grazie!\n\r");

            //    MessageBox.Show(messaggeToshow.ToString());
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
