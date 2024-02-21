﻿using FlightSimulatorControlCenter.Helper;
using FlightSimulatorControlCenter.Model.Aereo;
using FlightSimulatorControlCenter.Model.Event;
using FlightSimulatorControlCenter.Model.Flotta;
using FlightSimulatorControlCenter.Service.Int;

namespace FlightSimulatorControlCenter
{
    public partial class MainWindow : Form
    {
        private IValidationUserInputService _validationService;
        private IExternalServicesService _externalService;
        private IConversionModelService _conversionService;
        private ToolStripLabel LabelFlottaSelezionata;

        // Aggiungo la ref alle due form
        AirplaneManager airplaneManagerForm;
        FleetManager fleetManagerForm;
        DbSelection sceltaManagerForm;


        long idFlottaSelezionata = -1;

        public MainWindow(IValidationUserInputService validationService, IExternalServicesService externalService, IConversionModelService conversionService)
        {
            InitializeComponent();
            _validationService = validationService;
            _externalService = externalService;
            _conversionService = conversionService;

            // Inizializzo la label della flotta inizializzata
            UpdateLabelOfSelectedFleet("Flotta non selezionata");
        }


        private void airplaneManager_Click(object sender, EventArgs e)
        {
            if (!FormUtils.FormIsOpen("AirplaneManager"))
            {
                airplaneManagerForm = new AirplaneManager(idFlottaSelezionata, _validationService, _externalService, _conversionService);
                airplaneManagerForm.MdiParent = this;
                HandleAirplaneManagerEvent(airplaneManagerForm);

                airplaneManagerForm.Show();
            }
        }
        private void HandleAirplaneManagerEvent(AirplaneManager airplaneManagerForm)
        {
            airplaneManagerForm.AirPlaneCreated += (AereoBl aereobl) =>
            {
                // Ricevo la notifica che un aereo è stato creato
                // Chiedo alla form di gestione flotta di aggiornare la lista (così da incrementare il numero di aerei)
                fleetManagerForm?.RequestUpdateData();
            };

            airplaneManagerForm.AirPlaneUpdated += (AereoBl aereobl) =>
            {
                // Ricevo la notifica che un aereo è stato creato
                // Chiedo alla form di gestione flotta di aggiornare la lista (così da incrementare il numero di aerei)
                fleetManagerForm?.RequestUpdateData();
            };

            airplaneManagerForm.AirPlaneDeleted += (AereoBl aereobl) =>
            {
                // Ricevo la notifica che un aereo è stato creato
                // Chiedo alla form di gestione flotta di aggiornare la lista (così da incrementare il numero di aerei)
                fleetManagerForm?.RequestUpdateData();
            };
        }

        private void fleetManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!FormUtils.FormIsOpen("FleetManager"))
            {
                fleetManagerForm = new FleetManager(_validationService, _externalService, _conversionService);
                fleetManagerForm.MdiParent = this;
                fleetManagerForm.FormPrincipale = this;
                HandleFleetManagerEvent(fleetManagerForm);
                fleetManagerForm.Show();
            }
        }

        private void HandleFleetManagerEvent(FleetManager fleetManager)
        {
            fleetManager.FleetCreated += (FlottaBl flotta) =>
            {
                // Ricevo la notifica che una flotta è stata creata
            };

            fleetManager.FleetUpdated += (FlottaBl flotta) =>
            {
                // Ricevo la notifica che una flotta è stata modificata
                // Chiedo alla form di gestione Aerei di aggiornare le info della flotta
                airplaneManagerForm?.RequestUpdateData();
            };

            fleetManager.FleetSelected += (FlottaBl flotta) =>
            {
                // Ricevo la notifica che una flotta è stata selezionata
                // Chiedo alla form di gestione Aerei di aggiornare gli aerei
                idFlottaSelezionata = flotta.IdFlotta;
                UpdateLabelOfSelectedFleet(flotta.Nome);

                airplaneManagerForm?.UpdateSelectedFleet(flotta);
            };
        }

        // Metodi interni
        private void UpdateLabelOfSelectedFleet(string labelFlotta)
        {
            // Aggiorno la label nella schermata principale

            // Rimuovo la label corrente se presente
            if (LabelFlottaSelezionata != null)
            {
                menuStrip1.Items.Remove(LabelFlottaSelezionata);
            }

            // Creo la nuova label e la aggiungo
            LabelFlottaSelezionata = new ToolStripLabel(labelFlotta);
            LabelFlottaSelezionata.Alignment = ToolStripItemAlignment.Right;
            LabelFlottaSelezionata.Padding = new Padding(0, 0, 20, 0);
            menuStrip1.Items.Add(LabelFlottaSelezionata);
        }

        private void fleetToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sceltaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!FormUtils.FormIsOpen("DbSelection"))
            {
                sceltaManagerForm = new DbSelection();
                sceltaManagerForm.MdiParent = this;
                HandleSceltaManagerEvent(sceltaManagerForm);

                sceltaManagerForm.Show();
            }
        }
        private void HandleSceltaManagerEvent(DbSelection sceltaForm)
        {
            
            
            sceltaForm.SceltaSelected. += ()
            {
                // Ricevo la notifica che un aereo è stato creato
                // Chiedo alla form di gestione flotta di aggiornare la lista (così da incrementare il numero di aerei)
                fleetManagerForm?.RequestUpdateData();
            };

            airplaneManagerForm.AirPlaneUpdated += (AereoBl aereobl) =>
            {
                // Ricevo la notifica che un aereo è stato creato
                // Chiedo alla form di gestione flotta di aggiornare la lista (così da incrementare il numero di aerei)
                fleetManagerForm?.RequestUpdateData();
            };

            airplaneManagerForm.AirPlaneDeleted += (AereoBl aereobl) =>
            {
                // Ricevo la notifica che un aereo è stato creato
                // Chiedo alla form di gestione flotta di aggiornare la lista (così da incrementare il numero di aerei)
                fleetManagerForm?.RequestUpdateData();
            };

        }

    }
}
