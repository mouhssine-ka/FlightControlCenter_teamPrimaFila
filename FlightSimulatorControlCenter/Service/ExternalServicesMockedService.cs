using Clients.ImpiantiClient;
using FlightSimulatorControlCenter.Service.Int;

namespace FlightSimulatorControlCenter.Service
{
    public class ExternalServicesMockedService : IExternalServicesService
    {
        public ExternalServicesMockedService(string ba = "http://localhost:5093/") {
                   
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
        }

        public FlottaApi GetFlottaAsync(long idFLotta)
        {
            List<AereoApi> aerei = new List<AereoApi>() {
            new AereoApi() { IdAereo = 1, CodiceAereo = "AereoCod1", Colore = "Rosso", NumeroDiPosti = 10 },
            new AereoApi() { IdAereo = 2, CodiceAereo = "AereoCod1", Colore = "Rosso", NumeroDiPosti = 10 },
            new AereoApi() { IdAereo = 3, CodiceAereo = "AereoCod1", Colore = "Rosso", NumeroDiPosti = 10 },
            };

            var flotta1 = new FlottaApi() { IdFlotta = 1, Nome = "WizzAir", Aerei = aerei };
            return flotta1;
        }

        public AereoApi AereoPOSTAsync(CreateAereoRequest req)
        {
            var aereo1 = new AereoApi() { IdAereo = 1, CodiceAereo = "AereoCod1", Colore = "Rosso", NumeroDiPosti = 10 };
            return aereo1;
        }

        public AereoApi AereoPutAsync(UpdateAereoRequest req)
        {
            var aereo1 = new AereoApi() { IdAereo = 1, CodiceAereo = "AereoCod1", Colore = "Rosso", NumeroDiPosti = 10 };
            return aereo1;
        }

        public AereoApi AereoDeleteAsync(long idAereo)
        {
            var aereo1 = new AereoApi() { IdAereo = 1, CodiceAereo = "AereoCod1", Colore = "Rosso", NumeroDiPosti = 10 };
            return aereo1;
        }

        public List<VoloApi> GetElencoVoliAsync()
        {
            throw new NotImplementedException();
        }

        public VoloApi VoloPOSTAsync(CreateVoloRequest req)
        {
            throw new NotImplementedException();
        }
    }
}
