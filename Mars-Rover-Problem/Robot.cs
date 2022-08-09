abstract class Robot : IRobot
{
    public Direction Direction { get; set; }
    public int X { get; set; }
    public int Y { get; set; }
    public string M { get; set; }

    public void ChangeCoordinates()
    {
        switch (Direction)
        {
            case Direction.S: Y--;
                break;
            case Direction.N: Y++;
                break;
            case Direction.W: X--;
                break;
            case Direction.E: X++;
                break;
            default:
                break;
        }
    }

    public abstract void Movement();
}
