class MiniRobot : Robot
{
    public override void Movement()
    {
        foreach (char movementValue in M)
        {
            switch (movementValue)
            {
                case 'M': ChangeCoordinates(); //abstract class
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
}

