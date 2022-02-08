using MarsRover.model;

namespace MarsRover.utilities;

public static class RobotOperator
{
    public static void ChangeDirection(this Robot robot, string direction)
    {
        switch (direction)
        {
            case "L":
                robot.CurrentDirection = robot.CurrentDirection.Left();
                break;
            case "R":
                robot.CurrentDirection = robot.CurrentDirection.Right();
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

    public static void MoveFront(this Robot robot,Plateau plateau)
        {
            switch (robot.CurrentDirection)
            {
                case Direction.North:
                    if (plateau.HasMoreNorth(robot.PositionX))
                        robot.PositionX--;
                    break;
                case Direction.South:
                    if (plateau.HasMoreSouth(robot.PositionX))
                        robot.PositionX++;
                    break;
                case Direction.East:
                    if (plateau.HasMoreEast(robot.PositionY))
                        robot.PositionY++;
                    break;
                case Direction.West:
                    if (plateau.HasMoreWest(robot.PositionY))
                        robot.PositionY--;
                    break;
            }
        }
}



