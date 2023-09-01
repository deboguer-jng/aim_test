using AIMTest.Models;

namespace AIMTest.Repositories
{
    public class InMemoryElevatorDb : IInMemoryElevatorDb
    {
        Elevator _elevator { get; set; }
        
        public InMemoryElevatorDb()
        {
            _elevator = new Elevator() { 
                CurrentFloor = 0,
                UpcomingFloors = new List<int>(),
                PassengerFloors = new List<int>(),
            };
        }

        public void AddUpcomingFloor(int floorId)
        {
            _elevator.UpcomingFloors.Add(floorId);
        }

        public void RemoveUpcomingFloor(int floorId)
        {
            _elevator.UpcomingFloors.Remove(floorId);
        }

        public void AddPassengerFloor(int floorId)
        {
            _elevator.PassengerFloors.Add(floorId);
        }

        public void RemovePassengerFloor(int floorId)
        {
            _elevator.PassengerFloors.Remove(floorId);
        }

        public List<int> GetCurrentPassengerFloors()
        {
            return _elevator.PassengerFloors;
        }

        public List<int> GetUpcomingFloors()
        {
            return _elevator.UpcomingFloors;
        }

        public void SetCurrentFloor(int floorId)
        {
            _elevator.CurrentFloor = floorId;
        }

        public int GetCurrentFloor()
        {
            return _elevator.CurrentFloor;
        }

    }
}
