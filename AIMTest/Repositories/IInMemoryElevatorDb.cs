using AIMTest.Models;

namespace AIMTest.Repositories
{
    public interface IInMemoryElevatorDb
    {
        public void AddUpcomingFloor(int floorId);

        public void RemoveUpcomingFloor(int floorId);

        public void AddPassengerFloor(int floorId);

        public void RemovePassengerFloor(int floorId);

        public List<int> GetCurrentPassengerFloors();

        public List<int> GetUpcomingFloors();

        public void SetCurrentFloor(int floorId);

        public int GetCurrentFloor();

    }
}