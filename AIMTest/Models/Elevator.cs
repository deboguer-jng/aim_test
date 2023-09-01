namespace AIMTest.Models
{
    public class Elevator
    {
        // floors requested by passengers in the elevator
        public List<int> PassengerFloors { get; set; }
        
        // floors requested by waiters outside the elevator
        public List<int> UpcomingFloors { get; set; }
        
        // current floor of the elevator
        public int CurrentFloor { get; set; }
    }
}
