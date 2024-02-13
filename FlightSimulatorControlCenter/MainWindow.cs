using FlightSimulatorControlCenter.Helper;
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
    public partial class MainWindow : Form
    {
        private IValidationUserInputService _validationService;

        private string NomeFlottaSelezionata = "Flotta Rayanair";
        private long IdFlottaSelezionata = 0;

        public MainWindow(IValidationUserInputService validationService)
        {
            InitializeComponent();
            _validationService = validationService;
        }

        private void airplaneManager_Click(object sender, EventArgs e)
        {
            if (!FormUtils.FormIsOpen("AirplaneManager")) {
                var airm = new AirplaneManager(_validationService, NomeFlottaSelezionata, IdFlottaSelezionata);
                airm.MdiParent = this;
                airm.Show();
            }       
        }
    }
}
