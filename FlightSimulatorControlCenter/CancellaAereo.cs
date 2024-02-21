using FlightSimulatorControlCenter.Model.Aereo;
using FlightSimulatorControlCenter.Model.Event;

namespace FlightSimulatorControlCenter
{
    public partial class CancellaAereo : Form
    {
        public event AirplaneExecuteDeleteEvent AirplaneDeleteReq;

        private long idFlotta { get; set; }
        private long idAereo { get; set; }

        public CancellaAereo(long idFlotta, AereoBl aereoBl)
        {
            InitializeComponent();

            this.idFlotta = idFlotta;
            this.idAereo = aereoBl.IdAereo;

            this.idLabelText.Text = this.idAereo.ToString();
            this.coloreLabelText.Text = aereoBl.Colore;
            this.codiceLabelText.Text = aereoBl.Codice;
            this.numPostiLabelText.Text = aereoBl.NumeroDiPosti.ToString();
        }

        private void annullaButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void eliminaButton_Click(object sender, EventArgs e)
        {
            // Invio l'evento
            this.AirplaneDeleteReq(idFlotta, idAereo);
        }
    }
}
