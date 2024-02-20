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
        private ToolStripLabel LabelFlottaSelezionata;
        public FlottaBl FlottaSelezionata;

        // Aggiungo la ref alle due form
        AirplaneManager airplaneManagerForm;
        FleetManager fleetManagerForm;
        FleetSelectedEvent fleetSelected;


        public MainWindow(IValidationUserInputService validationService)
        {
            InitializeComponent();
            _validationService = validationService;

            // Inizializzo la label della flotta inizializzata
            UpdateLabelOfSelectedFleet("Flotta non selezionata");
        }

        private void airplaneManager_Click(object sender, EventArgs e)
        {
            if (!FormUtils.FormIsOpen("AirplaneManager"))
            {
                airplaneManagerForm = new AirplaneManager(_validationService, FlottaSelezionata);
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
                fleetManagerForm = new FleetManager(_validationService);
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
                FlottaSelezionata = flotta;

                airplaneManagerForm?.RequestUpdateData();
                UpdateLabelOfSelectedFleet(flotta.Nome);
            };
        }

        // Metodi interni
        private void UpdateLabelOfSelectedFleet(string labelFlotta) {
            // Aggiorno la label nella schermata principale

            // Rimuovo la label corrente se presente
            if (LabelFlottaSelezionata != null) {
                menuStrip1.Items.Remove(LabelFlottaSelezionata);
            }        

            // Creo la nuova label e la aggiungo
            LabelFlottaSelezionata = new ToolStripLabel(labelFlotta);
            LabelFlottaSelezionata.Alignment = ToolStripItemAlignment.Right;
            LabelFlottaSelezionata.Padding = new Padding(0, 0, 20, 0);
            menuStrip1.Items.Add(LabelFlottaSelezionata);
        }
    }
}
