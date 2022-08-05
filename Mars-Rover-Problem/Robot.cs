class Robot
{
    public Direction Direction { get; set; }
    public int X { get; set; }
    public int Y { get; set; }
    public string M { get; set; }

    public static void Movement(Robot robot)
    {
        foreach (char movementValue in robot.M)
        {
            switch (movementValue)
            {
                case 'M': ChangeCoordinates(robot);
                    break;
                case 'R': ChangeDirectionRight(robot);
                    break;
                case 'L': ChangeDirectionLeft(robot);
                    break;
                default:
                    break;
            }
        }
    }

    static void ChangeDirectionRight(Robot robot)
    {
        switch (robot.Direction)
        {
            case Direction.S: robot.Direction = Direction.W;
                break;
            case Direction.N: robot.Direction = Direction.E;
                break;
            case Direction.W: robot.Direction = Direction.N;
                break;
            case Direction.E: robot.Direction = Direction.S;
                break;
            default:
                break;
        }
    }

    static void ChangeDirectionLeft(Robot robot)
    {
        switch (robot.Direction)
        {
            case Direction.S: robot.Direction = Direction.E;
                break;
            case Direction.N: robot.Direction = Direction.W;
                break;
            case Direction.W: robot.Direction = Direction.S;
                break;
            case Direction.E: robot.Direction = Direction.N;
                break;
            default:
                break;
        }
    }

    static void ChangeCoordinates(Robot robot)
    {
        switch (robot.Direction)
        {
            case Direction.S: robot.Y--;
                break;
            case Direction.N: robot.Y++;
                break;
            case Direction.W: robot.X--;
                break;
            case Direction.E: robot.X++;
                break;
            default:
                break;
        }
    }
}
