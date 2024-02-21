using FlightSimulatorControlCenter.Model.Event;
using FlightSimulatorControlCenter.Service.Int;

namespace FlightSimulatorControlCenter
{
    public partial class AggiungiFlotta : Form
    {
        public event FleetExecuteCreateEvent FleetCreateReq;

        private IValidationUserInputService _validationService;

        public AggiungiFlotta(IValidationUserInputService validationService)
        {
            InitializeComponent();

            _validationService = validationService;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Recupero il nome della flotta
            var nomeFlotta = textBox1.Text;

            // X ragazzi aggiungere controlli qui

            // Invio l'evento
            this.FleetCreateReq(nomeFlotta);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
