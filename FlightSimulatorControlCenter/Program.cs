using Clients.ImpiantiClient;
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
            AereoBl.AereoBlFactory(1, "AereoCod1", "Rosso", 10),
            AereoBl.AereoBlFactory(2,"AereoCod2", "Blu", 20),
            AereoBl.AereoBlFactory(3,"AereoCod3", "Verde", 10)
            };

            var flotta1 = FlottaBl.FlottaBlFactory(1, "WizzAir", "Attiva", aerei);

            FakeDB.AggiungiFlotta(flotta1);

            List<AereoBl> aerei2 = new List<AereoBl>() {
            AereoBl.AereoBlFactory(4,"AereoCod4", "Rosso", 40),
            AereoBl.AereoBlFactory(5,"AereoCod5", "Blu", 50),
            AereoBl.AereoBlFactory(6,"AereoCod6", "Verde", 60)
            };

            var flotta2 = FlottaBl.FlottaBlFactory(2, "Rayanair", "Attiva", aerei2);

            FakeDB.AggiungiFlotta(flotta2);

            // Da modificare
            var client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:5093/");
            FlightSimulatorClient clientImpianto = new(client);
            var t = clientImpianto.AereoGETAsync(1);
            t.Wait();

            var a = t.Result;

            // Sono singleton
            IValidationUserInputService validationService = new ValidationUserInputService();

            Application.Run(new MainWindow(validationService));
        }
    }
}