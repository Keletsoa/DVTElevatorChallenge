namespace ElevatorChallenge.Models
{
    public class ElevatorManager
    {
        public List<Elevator> Elevators { get; set; }

        public ElevatorManager(int numOfElevators, int capacity)
        {
            Elevators = new List<Elevator>();

            for (int i = 1; i <= numOfElevators; i++)
            {
                var elevator = new Elevator(i, capacity);
                Elevators.Add(elevator);
            }
        }

        public Elevator GetClosestElevator(int floor)
        {
            var availableElevator = Elevators.Where(a => !a.IsElevatorMoving).ToList();

            if (availableElevator.Count == 0)
                return null;

            var closestElevator = availableElevator[0];
            var minDistance = Math.Abs(closestElevator.CurFloorPosition - floor);

            foreach (var elevator in availableElevator)
            {
                var distance = Math.Abs(elevator.CurFloorPosition - floor);
                if (distance < minDistance)
                {
                    closestElevator = elevator;
                    minDistance = distance;
                }
            }

            return closestElevator;
        }

        public void ElevatorStatus()
        {
            foreach (var elevator in Elevators)
            {
                var direction = elevator.IsElevatorMoving ? elevator.ElevatorDirection.ToString() : "Not Moving";
                Console.WriteLine($"Elevator {elevator.Id} is at floor {elevator.CurFloorPosition}, {direction}");
            }
        }

        public void CallElevator (int floor)
        {
            var elevator = GetClosestElevator(floor);

            if(elevator == null)
            {
                Console.WriteLine("No available elevator at the moment.");
                return;
            }

            Console.WriteLine($"Elevator {elevator.Id} is coming to floor {floor}");
            elevator.MoveToFloor(floor);
        }
    }
}
