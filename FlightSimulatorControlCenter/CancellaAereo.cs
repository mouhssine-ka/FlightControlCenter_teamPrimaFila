using FlightSimulatorControlCenter.Model.Aereo;
using FlightSimulatorControlCenter.Model.Flotta;
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

namespace FlightSimulatorControlCenter
{

    public partial class CancellaAereo : Form
    {
        AereoBl AereoSel;
        IExternalServicesService _externalService;
        public CancellaAereo(AereoBl aereoSelezionato,IExternalServicesService DbService)
        {
            _externalService= DbService;
            AereoSel = aereoSelezionato;
            InitializeComponent();
        }

        private void Annulla_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Conferma_Btn_Click(object sender, EventArgs e)
        {
            _externalService.AereoDELETEAsync(AereoSel.IdAereo);
            
            this.Close();

            
        }

        private void CancellaAereo_Load(object sender, EventArgs e)
        {
            Info_Aereo_lbl.Text = $"Codice: {AereoSel.Codice}  ID: {AereoSel.IdAereo}  Colore: {AereoSel.Colore}  Numero di posti: {AereoSel.NumeroDiPosti}";
        }
    }
}
