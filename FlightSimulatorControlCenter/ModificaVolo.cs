using Clients.ImpiantiClient;
using FlightSimulatorControlCenter.Model.Aereo;
using FlightSimulatorControlCenter.Model.Event;
using FlightSimulatorControlCenter.Model.Validation;
using FlightSimulatorControlCenter.Model.Volo;
using FlightSimulatorControlCenter.Service.Int;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FlightSimulatorControlCenter.Model.Event.FlightEvent;

namespace FlightSimulatorControlCenter
{
    public partial class ModificaVolo : Form
    {
        public event FlightExecuteModifyEvent FlightModifyReq;
        public IExternalServicesService _externalServices;
        public IValidationUserInputService _validationService;

        private VoloBl Volo;

        public ModificaVolo(VoloBl volo, IExternalServicesService externalService, IValidationUserInputService validationService)
        {
            InitializeComponent();
            Volo = volo;
            MostraDatiVolo();
            _externalServices = externalService;
            _validationService = validationService;
        }

        private void MostraDatiVolo()
        {
            lblIDVolo.Text = Volo.IdVolo.ToString();
            lblIdAereo.Text = Volo.Aereo.IdAereo.ToString();
            txtBoxNumPosti.Text = Volo.PostiRimanenti.ToString();
            txtBoxCittaPartenza.Text = Volo.CittaPartenza;
            txtBoxCittaArrivo.Text = Volo.CittaArrivo;
            dtpOrarioPartenza.Value = Volo.OrarioPartenza;
            dtpOrarioArrivo.Value = Volo.OrarioArrivo;
            txtBoxCostoVolo.Text = Volo.CostoDelPosto.ToString();
        }

        private void btnConferma_Click(object sender, EventArgs e)
        {
            var numPosti = long.Parse(txtBoxNumPosti.Text);
            var cittaPartenza = txtBoxCittaPartenza.Text;
            var cittaArrivo = txtBoxCittaArrivo.Text;
            var orarioPartenza = dtpOrarioPartenza.Value;
            var orarioArrivo = dtpOrarioArrivo.Value;
            var costoPosto = decimal.Parse(txtBoxCostoVolo.Text);

            var esitoValidazione = _validationService.ValidateUserInputForVoloUpdate(numPosti, costoPosto, cittaPartenza, cittaArrivo, orarioPartenza, orarioArrivo, Volo);

            if (esitoValidazione.IsValid())
            {
                FlightModifyReq(Volo.Aereo.IdAereo, numPosti, costoPosto, cittaPartenza, cittaArrivo, orarioPartenza, orarioArrivo);
            }
            else
            {
                // se ci sono errori li mostro
                var messaggeToshow = new StringBuilder();
                messaggeToshow.Append("Prima di procedere correggere i seguenti errori:\n\r");

                foreach (var message in esitoValidazione.ValidationErrors)
                {
                    messaggeToshow.Append(message + "\n\r");
                }

                messaggeToshow.Append("Grazie!\n\r");

                MessageBox.Show(messaggeToshow.ToString());
            }

        }

        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
