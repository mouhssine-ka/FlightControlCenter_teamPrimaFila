using Clients.ImpiantiClient;
using FlightSimulatorControlCenter.Model.Aereo;
using FlightSimulatorControlCenter.Model.Flotta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSimulatorControlCenter.Service.Int
{
    public interface IConversionModelService
    {
        List<FlottaBl> ConvertToBl(List<FlottaApi> result);

        FlottaBl ConvertToBl(FlottaApi flottaApi);

        AereoBl ConvertToBl(AereoApi aereoApi);       
    }
}
