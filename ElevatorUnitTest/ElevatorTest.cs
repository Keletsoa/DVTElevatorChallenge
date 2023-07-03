using ElevatorChallenge.Models;

namespace ElevatorUnitTest
{
    public class MoveElevatorTest
    {
        private ElevatorManager _manager = null;

        public MoveElevatorTest()
        {
            if (_manager == null)
            {
                //Lets create an elevator manager with 2 elevators and a capacity of 8!
                _manager = new ElevatorManager(2, 8);
            }
        }

        [Fact]
        public void CheckFloor()
        {
            var expected = new[] { "Elevator 1 is coming to floor 1, Not Moving", "Elevator 2 is coming to floor 1, Not Moving" };
            var actual = = new ElevatorManager(2, 8);
            Assert.Equal(expected, actual, 0);
        }

        [Fact]
        public void MoveToFloor()
        {
            //Lets create an elevator manager with 2 elevators and a capacity of 8!
            var expected = new ElevatorManager(2, 8);

            //Lets assume Elevator 1 is at floor 3 and Elevator 2 is at floor 5
            _manager.Elevators[0].MoveToFloor(3);
            _manager.Elevators[1].MoveToFloor(5);

            //Lets show the status of the elevators
            _manager.ElevatorStatus();

            //Assert.Equal()
        }
    }
}
