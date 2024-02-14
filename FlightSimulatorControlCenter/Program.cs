using FlightSimulatorControlCenter.Model.Aereo;
using FlightSimulatorControlCenter.Model.DB;
using FlightSimulatorControlCenter.Model.Flotta;
using FlightSimulatorControlCenter.Service;
using FlightSimulatorControlCenter.Service.Int;

namespace FlightSimulatorControlCenter
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Inizializzo il modello di db
            List<AereoBl> aerei = new List<AereoBl>() {
            AereoBl.AereoBlCreateFactory("AereoCod1", "Rosso", 10),
            AereoBl.AereoBlCreateFactory("AereoCod2", "Blu", 20),
            AereoBl.AereoBlCreateFactory("AereoCod3", "Verde", 10)
            };

            var flotta1 = FlottaBl.FlottaBlFactory(1, "WizzAir", "Attiva", aerei);

            FakeDB.AggiungiFlotta(flotta1);

            List<AereoBl> aerei2 = new List<AereoBl>() {
            AereoBl.AereoBlCreateFactory("AereoCod4", "Rosso", 40),
            AereoBl.AereoBlCreateFactory("AereoCod5", "Blu", 50),
            AereoBl.AereoBlCreateFactory("AereoCod6", "Verde", 60)
            };

            var flotta2 = FlottaBl.FlottaBlFactory(2, "Rayanair", "Attiva", aerei2);

            FakeDB.AggiungiFlotta(flotta2);

            // Sono singleton
            IValidationUserInputService validationService = new ValidationUserInputService();

            Application.Run(new MainWindow(validationService));
        }
    }
}