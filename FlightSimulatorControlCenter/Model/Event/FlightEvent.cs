using FlightSimulatorControlCenter.Model.Volo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSimulatorControlCenter.Model.Event
{
    public class FlightEvent
    {
        public delegate void FlightCreatedEvent(VoloBl voloCreated);
        public delegate void FlightDeletedEvent();

        public delegate void FlightExecuteCreateEvent(long aereoId, decimal costoTotale, string cittaPartenza, string cittaArrivo, DateTime orarioPartenza, DateTime orarioArrivo);
    }
}
