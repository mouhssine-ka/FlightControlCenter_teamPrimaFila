using Clients.ImpiantiClient;
using FlightSimulatorControlCenter.Model.Aereo;
using FlightSimulatorControlCenter.Model.Biglietto;
using FlightSimulatorControlCenter.Model.Event;
using FlightSimulatorControlCenter.Service.Int;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightSimulatorControlCenter
{
    public partial class SelezionaAereoPerVolo : Form
    {
        public event AirplaneSelectedEvent AereoSelected;

        public List<AereoBl> _elencoAerei = new List<AereoBl>();
        public BindingList<AereoTableModel> aerei = new BindingList<AereoTableModel>();


        private IValidationUserInputService _validationService;
        private IExternalServicesService _externalService;
        private IConversionModelService _conversionService;

        public SelezionaAereoPerVolo(IValidationUserInputService validationService, IExternalServicesService externalService, IConversionModelService conversionService)
        {
            InitializeComponent();
            _validationService = validationService;
            _externalService = externalService;
            _conversionService = conversionService;

            RetrieveAndUpdateAereiData();
        }

        private void RetrieveAndUpdateAereiData()
        {
            tabellaAerei.DataSource = null;
            _elencoAerei = RetrieveAereiData();
            InitalizeAereiDataGridFromDBModel();

        }

        private void InitalizeAereiDataGridFromDBModel()
        {
            aerei = new BindingList<AereoTableModel>();

            foreach (var a in _elencoAerei)
            {
                var temp = AereoTableModel.AereoTableModelFactory(a.IdAereo, a.Codice, a.Colore, a.NumeroDiPosti);
                aerei.Add(temp);
            }
            var source = new BindingSource(aerei, null);
            tabellaAerei.DataSource = source;

            tabellaAerei.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tabellaAerei.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }

        private List<AereoBl> RetrieveAereiData()
        {
            // Recupero la flotta
            var result = _externalService.GetElencoFlotteAsync();

            // Converto la risposta nei modelli Bl
            var flotteBl = _conversionService.ConvertToBl(result);

            List<AereoBl> listaAerei = new List<AereoBl>();
            foreach (var f in flotteBl)
            {
                foreach (var a in f.Aerei)
                {
                    listaAerei.Add(a);
                }
            }

            return listaAerei;
        }

        private void btnSeleziona_Click(object sender, EventArgs e)
        {
            int row = tabellaAerei.CurrentRow.Index;
            var aereoTableSelezionata = aerei[row];
            var aereoBlSelezionato = _elencoAerei.Single(x => x.IdAereo == aereoTableSelezionata.IdAereo);

            this.AereoSelected(aereoBlSelezionato);
        }

        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
