using Microsoft.AspNetCore.Mvc;

namespace AIMTest.Controllers
{
    public interface IElevatorController
    {

        public ActionResult<string> RequestElevator(ElevatorRequestDto request);

        public ActionResult<string> RequestFloor([FromBody] FloorRequestDto request);

        public ActionResult<IEnumerable<int>> CurrentPassengerFloors();

        public ActionResult<int> NextFloor();

        public class ElevatorRequestDto
        {
            public int? CurrentFloor { get; set; }
        }

        public class FloorRequestDto
        {
            public int? Floor { get; set; }
        }
    }
}