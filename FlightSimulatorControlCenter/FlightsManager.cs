using FlightSimulatorControlCenter.Helper;
using FlightSimulatorControlCenter.Model.Event;
using FlightSimulatorControlCenter.Model.Flotta;
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

namespace FlightSimulatorControlCenter
{
    public partial class FlightsManager : Form
    {

        //eventi esposti dalla form 
        public event FlightCreateEvent FlightCreate;
        public event FlightUpdatedEvent FlightUpdated;
        public event FlightDeletedEvent FlightDelete;


        private List<VoloBl> _elencoVolo = new List<VoloBl>();




        private IValidationUserInputService _validationService;
        private IExternalServicesService _externalService;
        private IConversionModelService _conversionService;

        private BindingList<VoloTableModel> flotte = new BindingList<VoloTableModel>();


        public MainWindow FormPrincipale { get; set; }

        public FlightsManager(IValidationUserInputService validationService, IExternalServicesService externalService, IConversionModelService conversionService)
        {
            InitializeComponent();
            _validationService = validationService;
            _externalService = externalService;
            _conversionService = conversionService;
        }

        private void FlightsManager_Load(object sender, EventArgs e)
        {

        }

        private void CreateVolo_Btn_Click(object sender, EventArgs e)
        {
            // Apro la form di creazione
            if (!FormUtils.FormIsOpen("CreazioneBiglietto"))
            {

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            volo = new BindingList<VoloTableModel>();

            foreach (var v in _elencoVolo)
            {
                var temp = VoloTableModel.VoloTableModelFactory(v.IdVolo, v.Aereo, v., "Attiva");
                flotte.Add(temp);
            }
        }
    }
}
