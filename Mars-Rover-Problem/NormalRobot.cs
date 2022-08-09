class NormalRobot : Robot
{
    public override void Movement()
    {
        foreach (char movementValue in M)
        {
            switch (movementValue)
            {
                case 'M': ChangeCoordinates(); //abstract class
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
}

