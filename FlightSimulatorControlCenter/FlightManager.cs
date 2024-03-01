using FlightSimulatorControlCenter.Helper;
using FlightSimulatorControlCenter.Model.Volo;
using FlightSimulatorControlCenter.Service;
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
    public partial class FlightManager : Form
    {

        public List<VoloBl> _elencoVoli = new List<VoloBl>();
        public BindingList<VoloTableModel> voli = new BindingList<VoloTableModel>();


        private IValidationUserInputService _validationService;
        private IExternalServicesService _externalService;
        private IConversionModelService _conversionService;

        public MainWindow FormPrincipale { get; set; }
        private CreazioneVolo FormCreazioneVolo;    

        public FlightManager(IValidationUserInputService validationService, IExternalServicesService externalService, IConversionModelService conversionService)
        {
            InitializeComponent();
            _validationService = validationService;
            _externalService = externalService;
            _conversionService = conversionService;

            RetrieveAndUpdateVoli();

        }
        private void RetrieveAndUpdateVoli()
        {
            tabellaVoli.DataSource = null;
            _elencoVoli = RetrieveVoliData();
            InitalizeVoliDataGridFromDBModel();

        }

        private void InitalizeVoliDataGridFromDBModel()
        {
            voli = new BindingList<VoloTableModel>();

            foreach (var v in _elencoVoli)
            {
                var temp = VoloTableModel.VoloTableModelFactory(v.IdVolo, v.Aereo.IdAereo, v.PostiRimanenti, v.CostoDelPosto, v.CittaPartenza, v.CittaArrivo, v.OrarioPartenza, v.OrarioArrivo);
                voli.Add(temp);
            }

            var source = new BindingSource(voli, null);

            tabellaVoli.DataSource = source;

            tabellaVoli.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tabellaVoli.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }

        private List<VoloBl> RetrieveVoliData()
        {
            var result = _externalService.GetElencoVoliAsync();

            var voliBl = _conversionService.ConvertToBl(result);

            return voliBl;
        }
        
        private void btnCreaVolo_Click(object sender, EventArgs e)
        {
            if (!FormUtils.FormIsOpen("CreazioneVolo"))
            {
                FormCreazioneVolo = new CreazioneVolo();

                FormCreazioneVolo.Show();
             }
        }
    }
}
