using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorChallenge.Models
{
    public class ElevatorManager
    {
        private List<Elevator> Elevators { get; set; }

        public ElevatorManager(int numOfElevators, int capacity)
        {
            Elevators = new List<Elevator>();
        }
    }
}
