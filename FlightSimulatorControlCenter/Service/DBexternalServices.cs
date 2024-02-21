using Clients.ImpiantiClient;
using FlightSimulatorControlCenter.Service.Int;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSimulatorControlCenter.Service
{
    public class DBexternalServices : IExternalServicesService
    {
        private Client _clientFlightSimulator { get; set; }

        public DBexternalServices(string baseAdress)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(baseAdress);
            _clientFlightSimulator = new(client);
        }

        public FlottaApi FlottaPOSTAsync(CreateFlottaRequest req)
        {
            var flottaCreataApi = (_clientFlightSimulator.FlottaPOSTAsync(req)).Result;
            return flottaCreataApi;
        }

        public List<FlottaApi> GetElencoFlotteAsync()
        {
            var elencoFlotte = (_clientFlightSimulator.GetElencoFlotteAsync()).Result;
            return elencoFlotte.ToList();
        }

        public FlottaApi GetFlottaAsync(long idFLotta)
        {
            var flotta = (_clientFlightSimulator.FlottaGETAsync(idFLotta)).Result;
            return flotta;
        }

        public AereoApi AereoPOSTAsync(CreateAereoRequest req)
        {
            var aereoCreatoApi = (_clientFlightSimulator.AereoPOSTAsync(req)).Result;
            return aereoCreatoApi;
        }

        public AereoApi AereoPutAsync(UpdateAereoRequest req)
        {
            var aereoModificatoApi = (_clientFlightSimulator.AereoPUTAsync(req)).Result;
            return aereoModificatoApi;
        }

        public void AereoDELETEAsync(long IDaereo)
        {
            _clientFlightSimulator.AereoDELETEAsync(IDaereo);
        }
    }
}
