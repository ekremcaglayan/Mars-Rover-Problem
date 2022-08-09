class MiniRobot : IRobot
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
                case 'B': TurnBack();
                    break;
                default:
                    break;
            }
        }
    }

    public void TurnBack()
    {
        switch (Direction)
        {
            case Direction.S: Direction = Direction.N;
                break;
            case Direction.N: Direction = Direction.S;
                break;
            case Direction.W: Direction = Direction.E;
                break;
            case Direction.E: Direction = Direction.W;
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

