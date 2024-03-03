using Clients.ImpiantiClient;
using FlightSimulatorControlCenter.Helper;
using FlightSimulatorControlCenter.Model.Aereo;
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
using static FlightSimulatorControlCenter.Model.Event.FlightEvent;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace FlightSimulatorControlCenter
{
    public partial class FlightManager : Form
    {
        public List<VoloBl> _elencoVoli = new List<VoloBl>();
        public BindingList<VoloTableModel> voli = new BindingList<VoloTableModel>();
        public VoloBl VoloSelezionato { get; set; }

        private IValidationUserInputService _validationService;
        private IExternalServicesService _externalService;
        private IConversionModelService _conversionService;

        public MainWindow FormPrincipale { get; set; }
        private CreazioneVolo FormCreazioneVolo;
        private CancellaVolo FormCancellaVolo;
        private ModificaVolo FormModificaVolo;

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
                FormCreazioneVolo = new CreazioneVolo(_validationService, _externalService, _conversionService);
                FormCreazioneVolo.VoloCreateReq += (long idAereo, decimal costoPosto, string cittaPartenza, string cittaArrivo, DateTime orarioPartenza, DateTime orarioArrivo) =>
                {
                    // Creo la request
                    var req = new CreateVoloRequest();
                    req.AereoId = idAereo;
                    req.CostoDelPosto = costoPosto;
                    req.CittaPartenza = cittaPartenza;
                    req.CittaArrivo = cittaArrivo;
                    req.OrarioPartenza = orarioPartenza;
                    req.OrarioArrivo = orarioArrivo;

                    // Eseguo la chiamata
                    var voloApi = _externalService.VoloPOSTAsync(req);

                    // Chiudo la form
                    FormCreazioneVolo.Close();

                    // Richiedo l'aggiornamento della tabella
                    RetrieveAndUpdateVoli();
                };

                FormCreazioneVolo.Show();
            }
        }

        private void btnEliminaVolo_Click(object sender, EventArgs e)
        {
            if (VoloSelezionato == null)
            {
                MessageBox.Show("E' neccessario selezionare un Volo");
                return;
            }
            if (!FormUtils.FormIsOpen("CancellaVolo"))
            {
                FormCancellaVolo = new CancellaVolo(VoloSelezionato, _externalService);
                FormCancellaVolo.FlightDeleted += () =>
                {
                    VoloSelezionato = null;
                    RetrieveAndUpdateVoli();
                    FormCancellaVolo.Close();
                };
                FormCancellaVolo.Show();
            }
        }

        private void btnSeleziona_Click(object sender, EventArgs e)
        {
            var row = tabellaVoli.CurrentRow.Index;
            var voloDaSelezionare = voli[row];

            VoloBl volo = _elencoVoli.Single(x => x.IdVolo == voloDaSelezionare.IdVolo);

            if (volo != null)
            {
                VoloSelezionato = volo;
            }
        }

        private void btnModificaVolo_Click(object sender, EventArgs e)
        {
            if(VoloSelezionato == null)
            {
                MessageBox.Show("E' neccessario selezionare un volo");
                return;
            }

            if (!FormUtils.FormIsOpen("ModificaVolo"))
            {
                FormModificaVolo = new ModificaVolo(VoloSelezionato, _externalService, _validationService);

                FormModificaVolo.FlightModifyReq += (idAereo, numPosti, costoPosto, cittaPartenza, cittaArrivo, orarioPartenza, orarioArrivo) =>
                {
                    var req = new UpdateVoloRequest();
                    req.AereoId = idAereo;
                    req.VoloId = VoloSelezionato.IdVolo;
                    req.Posti = numPosti;
                    req.CostoDelPosto = costoPosto;
                    req.CittaPartenza = cittaPartenza;
                    req.CittaArrivo = cittaArrivo;
                    req.OrarioPartenza = orarioPartenza;
                    req.OrarioArrivo = orarioArrivo;

                    var voloApi = _externalService.VoloUPDATEAsync(req);

                    var voloBlModificato = _conversionService.ConvertToBl(voloApi);

                    FormModificaVolo.Close();
                    VoloSelezionato = null;
                    RetrieveAndUpdateVoli();

                };

                FormModificaVolo.Show();
            }
        }
    }
}
