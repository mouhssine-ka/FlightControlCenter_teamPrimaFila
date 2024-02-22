using Clients.ImpiantiClient;
using FlightSimulatorControlCenter.Service.Int;

namespace FlightSimulatorControlCenter.Service
{
    public class ExternalServicesRemoteService : IExternalServicesService
    {
        private static Client _clientFlightSimulator { get; set; }
        private static string baseAddress { get; set; }

        public ExternalServicesRemoteService(string ba = "http://localhost:5093/") {
            baseAddress = ba;            
        }

        private Client GetClientIstance() {
            if (_clientFlightSimulator == null) {
                var client = new HttpClient();
                client.BaseAddress = new Uri(baseAddress);
                _clientFlightSimulator = new(client);
            }

            return _clientFlightSimulator;
        }

        public FlottaApi FlottaPOSTAsync(CreateFlottaRequest req)
        {
            var flottaCreataApi = (GetClientIstance().FlottaPOSTAsync(req)).Result;
            return flottaCreataApi;
        }

        public List<FlottaApi> GetElencoFlotteAsync()
        {                 
            var elencoFlotte = (GetClientIstance().GetElencoFlotteAsync()).Result;
            return elencoFlotte.ToList();
        }

        public FlottaApi GetFlottaAsync(long idFLotta)
        {           
            var flotta = (GetClientIstance().FlottaGETAsync(idFLotta)).Result;
            return flotta;
        }

        public AereoApi AereoPOSTAsync(CreateAereoRequest req)
        {
            var aereoCreatoApi = (GetClientIstance().AereoPOSTAsync(req)).Result;
            return aereoCreatoApi;
        }

        public AereoApi AereoPutAsync(UpdateAereoRequest req)
        {
            var aereoModificatoApi = (GetClientIstance().AereoPUTAsync(req)).Result;
            return aereoModificatoApi;
        }

        public AereoApi AereoDeleteAsync(long idAereo)
        {
            var aereoCancellatoApi = (GetClientIstance().AereoDELETEAsync(idAereo)).Result;
            return aereoCancellatoApi;
        }
    }
}
