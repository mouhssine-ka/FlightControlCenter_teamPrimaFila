using Clients.ImpiantiClient;
using FlightSimulatorControlCenter.Model.Aereo;
using FlightSimulatorControlCenter.Model.DB;
using FlightSimulatorControlCenter.Model.Flotta;
using FlightSimulatorControlCenter.Service.Int;

namespace FlightSimulatorControlCenter.Service
{
    public class ExternalServicesService : IExternalServicesService
    {
        private Client _clientFlightSimulator { get; set; }

        public ExternalServicesService(string baseAdress) {
            var client = new HttpClient();
            client.BaseAddress = new Uri(baseAdress);
            _clientFlightSimulator = new(client);
        }

        public FlottaApi FlottaPOSTAsync(CreateFlottaRequest req)
        {
            List<AereoApi> aerei = new List<AereoApi>() {
            new AereoApi() { IdAereo = 1, CodiceAereo = "AereoCod1", Colore = "Rosso", NumeroDiPosti = 10 },
            new AereoApi() { IdAereo = 2, CodiceAereo = "AereoCod1", Colore = "Rosso", NumeroDiPosti = 10 },
            new AereoApi() { IdAereo = 3, CodiceAereo = "AereoCod1", Colore = "Rosso", NumeroDiPosti = 10 },           
            };

            var flotta1 = new FlottaApi() { IdFlotta=1, Nome= "WizzAir", Aerei= aerei };
            return flotta1;

            var flottaCreataApi = (_clientFlightSimulator.FlottaPOSTAsync(req)).Result;
            return flottaCreataApi;
        }

        public List<FlottaApi> GetElencoFlotteAsync()
        {
            List<AereoApi> aerei = new List<AereoApi>() {
            new AereoApi() { IdAereo = 1, CodiceAereo = "AereoCod1", Colore = "Rosso", NumeroDiPosti = 10 },
            new AereoApi() { IdAereo = 2, CodiceAereo = "AereoCod1", Colore = "Rosso", NumeroDiPosti = 10 },
            new AereoApi() { IdAereo = 3, CodiceAereo = "AereoCod1", Colore = "Rosso", NumeroDiPosti = 10 },
            };

            var flotta1 = new FlottaApi() { IdFlotta = 1, Nome = "WizzAir", Aerei = aerei };
            return new List<FlottaApi>() { flotta1 };

            var elencoFlotte = (_clientFlightSimulator.GetElencoFlotteAsync()).Result;
            return elencoFlotte.ToList();
        }
    }
}
