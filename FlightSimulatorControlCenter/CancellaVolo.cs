using Clients.ImpiantiClient;
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
    public partial class CancellaVolo : Form
    {
        public event FlightDeletedEvent FlightDeleted;
        private IExternalServicesService _externalService;

        private VoloBl Volo { get; set; }
        public CancellaVolo(VoloBl volo, IExternalServicesService externalService)
        {
            _externalService = externalService;
            InitializeComponent();
            this.Volo = volo;
            ShowDatiVolo();
        }

        private void ShowDatiVolo()
        {
            lblIDVolo.Text = Volo.IdVolo.ToString();
            lblIDAereo.Text = Volo.Aereo.IdAereo.ToString();
            lblNumPosti.Text = Volo.PostiRimanenti.ToString();
            lblCittaPartenza.Text = Volo.CittaPartenza;
            lblCittaArrivo.Text = Volo.CittaArrivo;
            var orarioPartenza = Volo.OrarioPartenza.ToString();
            lblOrarioPartenza.Text = orarioPartenza.Substring(0, orarioPartenza.Length - 3); //rimuovi i secondi
            var orarioArrivo = Volo.OrarioArrivo.ToString();
            lblOrarioArrivo.Text = orarioArrivo.Substring(0, orarioArrivo.Length - 3);
        }

        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnElimina_Click(object sender, EventArgs e)
        {
           _externalService.VoloDELETEAsync(Volo.IdVolo);
            FlightDeleted();
        }
    }
}
