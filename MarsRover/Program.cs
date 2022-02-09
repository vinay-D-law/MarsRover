// See https://aka.ms/new-console-template for more information
using MarsRover;




var dimensions = Console.ReadLine();
var commandList = Console.ReadLine();

Console.WriteLine(RoverTask.PerformRoverTask(dimensions ?? "", commandList ?? ""));
