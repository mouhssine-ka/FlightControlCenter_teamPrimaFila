using Clients.ImpiantiClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSimulatorControlCenter.Service.Int
{
    public interface IExternalServicesService
    {
        AereoApi AereoDeleteAsync(long idAereo);
        AereoApi AereoPOSTAsync(CreateAereoRequest req);
        AereoApi AereoPutAsync(UpdateAereoRequest req);
        FlottaApi FlottaPOSTAsync(CreateFlottaRequest req);
        List<FlottaApi> GetElencoFlotteAsync();
        FlottaApi GetFlottaAsync(long idFlottaAttiva);
    }
}
