using FlightSimulatorControlCenter.Model.Aereo;

namespace FlightSimulatorControlCenter.Model.Event
{
    public delegate void AirplaneCreatedEvent(AereoBl airplaneCreated);
    public delegate void AirplaneUpdatedEvent(AereoBl airplaneUpdated);
    public delegate void AirplaneDeletedEvent(AereoBl airplaneDeleted);
}
