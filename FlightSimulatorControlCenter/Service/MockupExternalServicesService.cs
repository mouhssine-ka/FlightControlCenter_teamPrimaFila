﻿using Clients.ImpiantiClient;
using FlightSimulatorControlCenter.Model.Aereo;
using FlightSimulatorControlCenter.Model.DB;
using FlightSimulatorControlCenter.Model.Flotta;
using FlightSimulatorControlCenter.Service.Int;

namespace FlightSimulatorControlCenter.Service
{
    public class MockupExternalServicesService : IExternalServicesService
    {
        
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

        public void AereoDELETEAsync(long IDaereo)
        {
            throw new NotImplementedException();
        }
    }
}
