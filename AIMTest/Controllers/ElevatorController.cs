using AIMTest.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace AIMTest.Controllers
{
    [ApiController]

    [Route("elevator")]
    public class ElevatorController : Controller, IElevatorController
    {
        readonly IInMemoryElevatorDb _elevator;

        public ElevatorController(IInMemoryElevatorDb elevator)
        {
            this._elevator = elevator;
        }

        [HttpPost("request_elevator")]
        public ActionResult<string> RequestElevator(IElevatorController.ElevatorRequestDto request)
        {
            if (request.CurrentFloor == null)
            {
                return BadRequest("CurrentFloor is required");
            }

            List<int> currentPassengerFloors = _elevator.GetCurrentPassengerFloors();

            if (currentPassengerFloors.Count == 0)
            {
                _elevator.AddPassengerFloor((int)request.CurrentFloor);
            } 
            else
            {
                _elevator.AddUpcomingFloor((int)request.CurrentFloor);
            }

            return Ok("Elevator request resolved");
        }


        [HttpPost("request_floor")]
        public ActionResult<string> RequestFloor(IElevatorController.FloorRequestDto request)
        {
            if (request.Floor == null)
            {
                return BadRequest("Floor is required");
            }
            
            _elevator.AddPassengerFloor((int)request.Floor);

            return Ok("Floor request resolved");
        }


        [HttpGet("current_passenger_floors")]
        public ActionResult<IEnumerable<int>> CurrentPassengerFloors()
        {
            return Ok(_elevator.GetCurrentPassengerFloors());
        }


        [HttpPost("next_floor")]
        public ActionResult<int> NextFloor()
        {
            List<int> currentPassengerFloors = _elevator.GetCurrentPassengerFloors();
            List<int> pendingFloors = _elevator.GetUpcomingFloors();

            if (currentPassengerFloors.Count > 0)
            {
                return Ok(currentPassengerFloors[0]);
            }

            if (pendingFloors.Count > 0)
            {
                return Ok(pendingFloors[0]);
            }

            return Ok(-1);
        }
    }
}
