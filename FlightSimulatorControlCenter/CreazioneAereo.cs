using FlightSimulatorControlCenter.Model.Event;
using FlightSimulatorControlCenter.Service.Int;
using System.Text;

namespace FlightSimulatorControlCenter
{
    public partial class CreazioneAereo : Form
    {
        public event AirplaneExecuteCreateEvent AirplaneCreateReq;

        private IValidationUserInputService _validationService;

        public CreazioneAereo(IValidationUserInputService validationService)
        {
            InitializeComponent();
            _validationService = validationService;
        }

        private void salvaButton_Click(object sender, EventArgs e)
        {
            // Recupero dati
            var codice = codiceText.Text;
            var colore = coloreText.Text;
            var numeroDiPosti = numPostiText.Text;

            // Valido l'input
            var esistoValidazione = _validationService.ValidateUserInputForAirplaneCreation(codice, colore, numeroDiPosti);

            if (esistoValidazione.IsValid())
            {
                // Notifico la richiesta di creazione aereo
                this.AirplaneCreateReq(esistoValidazione.Codice, esistoValidazione.Colore, esistoValidazione.NumeroDiPosti);
            }
            else
            {
                // se ci sono errori li mostro
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

        private void annullaButton_Click(object sender, EventArgs e)
        {
            // Chiudo la form
            this.Close();
        }
    }
}
