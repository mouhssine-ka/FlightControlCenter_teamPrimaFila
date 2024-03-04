using FlightSimulatorControlCenter.Model.Aereo;

namespace FlightSimulatorControlCenter.Model.Event
{
    public delegate void AirplaneCreatedEvent(AereoBl airplaneCreated);
    public delegate void AirplaneUpdatedEvent(AereoBl airplaneUpdated);
    public delegate void AirplaneDeletedEvent();
    public delegate void AirplaneSelectedEvent(AereoBl airplaneSelected);

    public delegate void AirplaneExecuteCreateEvent(string codice, string colore, long numerodiposti);
    public delegate void AirplaneExecuteModifyEvent(long idFlotta, long idAereo, string codice, string colore, long numerodiposti);
    public delegate void AirplaneExecuteDeleteEvent(long idFlotta, long idAereo);

}
