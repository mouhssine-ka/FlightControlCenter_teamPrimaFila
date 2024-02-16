using FlightSimulatorControlCenter.Model.Flotta;

namespace FlightSimulatorControlCenter.Model.Event
{
    public delegate void FleetSelectedEvent(FlottaBl fleetSelected);
    public delegate void FleetCreatedEvent(FlottaBl fleetCreated);
    public delegate void FleetUpdatedEvent(FlottaBl fleetUpdated);
}
