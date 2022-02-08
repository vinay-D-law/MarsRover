using MarsRover.model;
using MarsRover.utilities;
using Xunit;

namespace MarsRoverTest
{
    public class RobotOperatorTest
    {
        [Fact]
        public void RobotChangesDirectionToEastFromNorthOnRight()
        {
            var robot = new Robot();
            robot.ChangeDirection("R");
            Assert.Equal(Direction.East,robot.CurrentDirection);
        }

        [Fact]
        public void RobotChangesDirectionTowestFromNorthOnLeft()
        {
            var robot = new Robot();
            robot.ChangeDirection("L");
            Assert.Equal(Direction.West, robot.CurrentDirection);
        }

        [Fact]
        public void RobotChangesDirectionToNorthFromWestOnRight()
        {
            var robot = new Robot();
            robot.ChangeDirection("L"); // goes to west
            robot.ChangeDirection("R");
            Assert.Equal(Direction.North, robot.CurrentDirection);
        }


        [Fact]
        public void RobotCannotMoveNorthBeyondPlateau()
        {
            var plateau = new Plateau(4, 4);
            var robot = new Robot();
            var expectedCoordinates = "1,1,North";
            robot.MoveFront(plateau);
            var actualCoordinates = robot.ToString();
            Assert.Equal(expectedCoordinates, actualCoordinates);
        }

        [Fact]
        public void RobotCannotMoveSouthBeyondPlateau()
        {
            var plateau = new Plateau(4, 4);
            var robot = new Robot();
            robot.PositionX = 4;
            robot.CurrentDirection = Direction.South;
            var expectedCoordinates = "4,1,South";
            robot.MoveFront(plateau);
            var actualCoordinates = robot.ToString();
            Assert.Equal(expectedCoordinates, actualCoordinates);
        }

        [Fact]
        public void RobotCannotMoveWestBeyondPlateau()
        {
            var plateau = new Plateau(4, 4);
            var robot = new Robot();
            robot.CurrentDirection = Direction.West;
            var expectedCoordinates = "1,1,West";
            robot.MoveFront(plateau);
            var actualCoordinates = robot.ToString();
            Assert.Equal(expectedCoordinates, actualCoordinates);
        }

        [Fact]
        public void RobotCannotMoveEastBeyondPlateau()
        {
            var plateau = new Plateau(4, 4);
            var robot = new Robot();
            robot.PositionY = 4;
            robot.CurrentDirection = Direction.East;
            var expectedCoordinates = "1,4,East";
            robot.MoveFront(plateau);
            var actualCoordinates = robot.ToString();
            Assert.Equal(expectedCoordinates, actualCoordinates);
        }

        [Fact]
        public void RobotCanMoveFreelyWithinPlateau()
        {
            var plateau = new Plateau(4, 4);
            var robot = new Robot();

            robot.ChangeDirection("R");
            robot.MoveFront(plateau);
            robot.ChangeDirection("R");
            robot.MoveFront(plateau);
            robot.ChangeDirection("L");
            robot.MoveFront(plateau);

            var expectedCoordinates = "2,3,East";
            var actualCoordinates = robot.ToString();
            Assert.Equal(expectedCoordinates, actualCoordinates);
        }

    }
}