// See https://aka.ms/new-console-template for more information
using ElevatorChallenge.Models;

//Lets create an elevator manager with 2 elevators and a capacity of 8!
var elevatorManager = new ElevatorManager(2, 8);

//Lets assume Elevator 1 is at floor 3 and Elevator 2 is at floor 5
elevatorManager.Elevators[0].MoveToFloor(3);
elevatorManager.Elevators[1].MoveToFloor(5);

//Lets show the status of the elevators
elevatorManager.ElevatorStatus();

//Lets call an elevator to floor 4
elevatorManager.CallElevator(4);

//Lets show the status of the elevators
elevatorManager.ElevatorStatus();

Console.ReadLine();
