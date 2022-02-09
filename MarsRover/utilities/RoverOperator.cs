using MarsRover.model;

namespace MarsRover.utilities;

public static class RoverOperator
{
    public static void ChangeDirection(this Rover Rover, string direction)
    {
        switch (direction)
        {
            case "L":
                Rover.CurrentDirection = Rover.CurrentDirection.Left();
                break;
            case "R":
                Rover.CurrentDirection = Rover.CurrentDirection.Right();
                break;
        }
    }

    private static Direction Left(this Direction currentDirection)
    {
        var length = Enum.GetNames(typeof(Direction)).Length;
        var newDirection = (int)currentDirection - 1;
        if (newDirection < 0) return (Direction)(length - 1);
        else return (Direction)(newDirection);
    }

    private static Direction Right(this Direction currentDirection)
    {
        var length = Enum.GetNames(typeof(Direction)).Length;
        var newDirection = (int)currentDirection + 1;
        return (Direction)(newDirection % length);
    }

    public static void MoveFront(this Rover Rover,Plateau plateau)
        {
            switch (Rover.CurrentDirection)
            {
                case Direction.North:
                    if (plateau.HasMoreNorth(Rover.PositionX))
                        Rover.PositionX--;
                    break;
                case Direction.South:
                    if (plateau.HasMoreSouth(Rover.PositionX))
                        Rover.PositionX++;
                    break;
                case Direction.East:
                    if (plateau.HasMoreEast(Rover.PositionY))
                        Rover.PositionY++;
                    break;
                case Direction.West:
                    if (plateau.HasMoreWest(Rover.PositionY))
                        Rover.PositionY--;
                    break;
            }
        }
}



