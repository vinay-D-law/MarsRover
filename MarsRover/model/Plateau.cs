namespace MarsRover.model;

public record Plateau(int Rows, int Columns)
{
    public bool HasMoreNorth(int row)
    {
        if (row == 1)
            return false;
        else
            return true;
    }

    public bool HasMoreSouth(int row)
    {
        if (row == Rows)
            return false;
        else
            return true;
    }

    public bool HasMoreEast(int column)
    {
        if (column == Columns)
            return false;
        else
            return true;
    }

    public bool HasMoreWest(int column)
    {
        if (column == 1)
            return false;
        else
            return true;
    }
}



