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
            
            // Sono singleton
            IValidationUserInputService validationService = new ValidationUserInputService();
            IConversionModelService conversionService = new ConversionModelService();
            // remote server addr"http://localhost:5093/"
            IExternalServicesService externalService = new ExternalServicesFakeDBService(conversionService);

            Application.Run(new MainWindow(validationService, externalService, conversionService));
        }
    }
}