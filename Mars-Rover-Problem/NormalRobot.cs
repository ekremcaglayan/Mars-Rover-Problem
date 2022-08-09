class NormalRobot : IRobot
{
    public Direction Direction { get; set; }
    public int X { get; set; }
    public int Y { get; set; }
    public string M { get; set; }

    public void Movement()
    {
        foreach (char movementValue in M)
        {
            switch (movementValue)
            {
                case 'M': ChangeCoordinates();
                    break;
                case 'R': ChangeDirectionRight();
                    break;
                case 'L': ChangeDirectionLeft();
                    break;
                default:
                    break;
            }
        }
    }

    public void ChangeDirectionRight()
    {
        switch (Direction)
        {
            case Direction.S: Direction = Direction.W;
                break;
            case Direction.N: Direction = Direction.E;
                break;
            case Direction.W: Direction = Direction.N;
                break;
            case Direction.E: Direction = Direction.S;
                break;
            default:
                break;
        }
    }

    public void ChangeDirectionLeft()
    {
        switch (Direction)
        {
            case Direction.S: Direction = Direction.E;
                break;
            case Direction.N: Direction = Direction.W;
                break;
            case Direction.W: Direction = Direction.S;
                break;
            case Direction.E: Direction = Direction.N;
                break;
            default:
                break;
        }
    }

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
}

