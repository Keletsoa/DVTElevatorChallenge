namespace ElevatorChallenge.Models
{
    public class Elevator
    {
        public int Id { get; set; }
        public int Capacity { get; set; }
        public int CurFloorPosition { get; set; }
        public bool IsElevatorMoving { get; set; }
        public ElevatorDirection ElevatorDirection { get; set; }

        public Elevator(int id, int capacity)
        {
            Id = id;
            Capacity = capacity;
            CurFloorPosition = 1;
            IsElevatorMoving = false;
            ElevatorDirection = ElevatorDirection.Up;
        }

        public void MoveToFloor(int floor)
        {
            IsElevatorMoving = true;

            if(floor < CurFloorPosition)
            {
                ElevatorDirection = ElevatorDirection.Down;
            }
            else
            {
                ElevatorDirection = ElevatorDirection.Up;
            }

            while (CurFloorPosition != floor)
            {
                if (ElevatorDirection == ElevatorDirection.Up)
                {
                    CurFloorPosition++;
                }
                else
                {
                    CurFloorPosition--;
                }

                Console.WriteLine($"Elevator {Id} is at floor {CurFloorPosition}");
            }

            IsElevatorMoving = false;
            
        }
    }

    public enum ElevatorDirection
    {
        Up,
        Down
    }
}
