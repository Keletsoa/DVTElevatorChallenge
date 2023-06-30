using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorChallenge.Models
{
    public class Elevator
    {
        public int Id { get; set; }
        public int Capacity { get; set; }
        public int CurFloorPosition { get; set; }
        public bool IsMoving { get; set; }
    }
}
