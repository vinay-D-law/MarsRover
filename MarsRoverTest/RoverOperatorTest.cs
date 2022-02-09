using MarsRover.model;
using MarsRover.utilities;
using Xunit;

namespace MarsRoverTest
{
    public class RoverOperatorTest
    {
        [Fact]
        public void RoverChangesDirectionToEastFromNorthOnRight()
        {
            var Rover = new Rover();
            Rover.ChangeDirection("R");
            Assert.Equal(Direction.East,Rover.CurrentDirection);
        }

        [Fact]
        public void RoverChangesDirectionTowestFromNorthOnLeft()
        {
            var Rover = new Rover();
            Rover.ChangeDirection("L");
            Assert.Equal(Direction.West, Rover.CurrentDirection);
        }

        [Fact]
        public void RoverChangesDirectionToNorthFromWestOnRight()
        {
            var Rover = new Rover();
            Rover.ChangeDirection("L"); // goes to west
            Rover.ChangeDirection("R");
            Assert.Equal(Direction.North, Rover.CurrentDirection);
        }


        [Fact]
        public void RoverCannotMoveNorthBeyondPlateau()
        {
            var plateau = new Plateau(4, 4);
            var Rover = new Rover();
            var expectedCoordinates = "1,1,North";
            Rover.MoveFront(plateau);
            var actualCoordinates = Rover.ToString();
            Assert.Equal(expectedCoordinates, actualCoordinates);
        }

        [Fact]
        public void RoverCannotMoveSouthBeyondPlateau()
        {
            var plateau = new Plateau(4, 4);
            var Rover = new Rover();
            Rover.PositionX = 4;
            Rover.CurrentDirection = Direction.South;
            var expectedCoordinates = "4,1,South";
            Rover.MoveFront(plateau);
            var actualCoordinates = Rover.ToString();
            Assert.Equal(expectedCoordinates, actualCoordinates);
        }

        [Fact]
        public void RoverCannotMoveWestBeyondPlateau()
        {
            var plateau = new Plateau(4, 4);
            var Rover = new Rover();
            Rover.CurrentDirection = Direction.West;
            var expectedCoordinates = "1,1,West";
            Rover.MoveFront(plateau);
            var actualCoordinates = Rover.ToString();
            Assert.Equal(expectedCoordinates, actualCoordinates);
        }

        [Fact]
        public void RoverCannotMoveEastBeyondPlateau()
        {
            var plateau = new Plateau(4, 4);
            var Rover = new Rover();
            Rover.PositionY = 4;
            Rover.CurrentDirection = Direction.East;
            var expectedCoordinates = "1,4,East";
            Rover.MoveFront(plateau);
            var actualCoordinates = Rover.ToString();
            Assert.Equal(expectedCoordinates, actualCoordinates);
        }

        [Fact]
        public void RoverCanMoveFreelyWithinPlateau()
        {
            var plateau = new Plateau(4, 4);
            var Rover = new Rover();

            Rover.ChangeDirection("R");
            Rover.MoveFront(plateau);
            Rover.ChangeDirection("R");
            Rover.MoveFront(plateau);
            Rover.ChangeDirection("L");
            Rover.MoveFront(plateau);

            var expectedCoordinates = "2,3,East";
            var actualCoordinates = Rover.ToString();
            Assert.Equal(expectedCoordinates, actualCoordinates);
        }

    }
}