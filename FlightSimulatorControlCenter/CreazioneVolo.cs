using FlightSimulatorControlCenter.Helper;
using FlightSimulatorControlCenter.Model.Aereo;
using FlightSimulatorControlCenter.Model.Event;
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
    public partial class CreazioneVolo : Form
    {
        private SelezionaAereoPerVolo FormSelezionaAereoPerVolo;

        private IValidationUserInputService _validationService;
        private IExternalServicesService _externalService;
        private IConversionModelService _conversionService;

        private AereoBl AereoSelezionato;

        public event FlightExecuteCreateEvent VoloCreateReq;

        public CreazioneVolo(IValidationUserInputService validationService, IExternalServicesService externalService, IConversionModelService conversionService)
        {
            InitializeComponent();
            _validationService = validationService;
            _externalService = externalService;
            _conversionService = conversionService;
        }

        private void btnScegliAereo_Click(object sender, EventArgs e)
        {
            if (!FormUtils.FormIsOpen("SelezionaAereoPerVolo"))
            {
                FormSelezionaAereoPerVolo = new SelezionaAereoPerVolo(_validationService, _externalService, _conversionService);

                HandleAirplaneManagerEvent(FormSelezionaAereoPerVolo);
                FormSelezionaAereoPerVolo.Show();

            }
        }
        private void HandleAirplaneManagerEvent(SelezionaAereoPerVolo selezionaAereoPerVolo)
        {
            selezionaAereoPerVolo.AereoSelected += (AereoBl aereobl) =>
            {
                AereoSelezionato = aereobl;
                ShowIdAereoSelezionato();
                FormSelezionaAereoPerVolo.Close();
            };
        }

        private void ShowIdAereoSelezionato()
        {
            lblIdAereoSelezoinato.Text = AereoSelezionato.IdAereo.ToString();
        }

        private async void btnCreaVolo_Click(object sender, EventArgs e)
        {
            var aereoId = AereoSelezionato != null ? AereoSelezionato.IdAereo : -1;
            var FormcostoPosto = txtBoxCostoVolo.Text;
            long costoPosto = -1;
            if (long.TryParse(FormcostoPosto, out long number))
            {
                costoPosto = number;
            }
            var cittaPartenza = txtBoxCittaPartenza.Text;
            var cittaArrivo = txtBoxCittaArrivo.Text;
            var orarioPartenza = dtpOrarioPartenza.Value;
            var orarioArrivo = dtpOrarioArrivo.Value;

            var esitoValidazione = _validationService.ValidateUserInputForVoloCreation(aereoId, costoPosto, cittaPartenza, cittaArrivo, orarioPartenza, orarioArrivo);

            if (esitoValidazione.IsValid())
            {
                this.VoloCreateReq(esitoValidazione.AereoId, esitoValidazione.CostPosto, esitoValidazione.CittaPartenza, esitoValidazione.CittaArrivo, esitoValidazione.OrarioPartenza, esitoValidazione.OrarioArrivo);

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
