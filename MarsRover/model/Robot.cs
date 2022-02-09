namespace MarsRover.model;

public class Rover
{
    public int PositionX { get; set; }
    public int PositionY { get; set; }
    public Direction CurrentDirection { get; set; }

    public Rover()
    {
        PositionX = PositionY = 1;
        CurrentDirection = Direction.North;
    }

    public override string ToString()
        => PositionX + "," + PositionY + "," + CurrentDirection.ToString();
}



