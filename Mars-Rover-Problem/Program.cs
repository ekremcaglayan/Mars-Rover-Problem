using System.Linq.Expressions;
using System.Numerics;

public static class Program
{
    static void Main(string[] args)
    {
        Console.Write("Alan değerini giriniz: ");
        string areaValues = Console.ReadLine();

        string movementValues = string.Empty;
        Area currentArea = new Area();
        List<Robot> robots = new List<Robot>();
        Direction direction = Direction.N;

        while (true)
        {
            Console.Write("Mevcut konum değerini giriniz: ");
            string robotValues = Console.ReadLine();
            Console.Write("Nasıl ilerleyeceğini giriniz: ");
            movementValues = Console.ReadLine();

            currentArea.X = int.Parse(areaValues.Split(' ')[0]);
            currentArea.Y = int.Parse(areaValues.Split(' ')[1]);

            Robot currentRobot = new Robot();
            currentRobot.X = int.Parse(robotValues.Split(' ')[0]);
            currentRobot.Y = int.Parse(robotValues.Split(' ')[1]);
            currentRobot.M = movementValues;
            Enum.TryParse(robotValues.Split(' ')[2], out direction);
            currentRobot.Direction = direction;

            robots.Add(currentRobot);

            Console.Write("Would you like to continue? (Y/N): ");
            string choice = Console.ReadLine();
            Console.WriteLine("");
            if (choice == "N")
            {
                break;
            }
        }

        foreach (Robot currentRobot in robots)
        {
            Console.WriteLine("----------------------");
            ShowMatrix(currentArea, currentRobot);
            Console.WriteLine();

            Movement(currentRobot);
            RedirectDirection(currentRobot);
            Console.WriteLine();

            ShowMatrix(currentArea, currentRobot);
            Console.WriteLine("----------------------");
        }
    }

    static void ShowMatrix(Area currentArea, Robot currentRobot)
    {
        int i, j;

        for (j = currentArea.Y - 1; j >= 0; j--)
        {
            for (i = 0; i < currentArea.X; i++)
            {
                //Console.Write(" ");
                if (i == currentRobot.X && j == currentRobot.Y)
                {
                    ReportLocation();
                }
                else
                {
                    Console.Write(0 + " ");
                }
            }
            Console.WriteLine();
        }
    }

    static void ReportLocation()
    {
        Console.Write("P1" + " ");
    }

    static void RedirectDirection(Robot robot)
    {
        Console.WriteLine("P1 new direction : " + robot.X + " " + robot.Y + " " + robot.Direction);
    }

    static void Movement(Robot robot)
    {
        foreach (char movementValue in robot.M)
        {
            switch (movementValue)
            {
                case 'M':
                    if (robot.Direction == Direction.S) { robot.Y--; }
                    else if (robot.Direction == Direction.N) { robot.Y++; }
                    else if (robot.Direction == Direction.W) { robot.X--; }
                    else if (robot.Direction == Direction.E) { robot.X++; }
                    break;
                case 'R':
                    if (robot.Direction == Direction.S) { robot.Direction = Direction.W; }
                    else if (robot.Direction == Direction.N) { robot.Direction = Direction.E; }
                    else if (robot.Direction == Direction.W) { robot.Direction = Direction.N; }
                    else if (robot.Direction == Direction.E) { robot.Direction = Direction.S; }
                    break;
                case 'L':
                    if (robot.Direction == Direction.S) { robot.Direction = Direction.E; }
                    else if (robot.Direction == Direction.N) { robot.Direction = Direction.W; }
                    else if (robot.Direction == Direction.W) { robot.Direction = Direction.S; }
                    else if (robot.Direction == Direction.E) { robot.Direction = Direction.N; }
                    break;
                default:
                    break;
            }
        }
    }
}