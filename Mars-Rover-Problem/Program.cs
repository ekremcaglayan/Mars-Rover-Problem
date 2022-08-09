using System.Linq.Expressions;
using System.Numerics;

public static class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the area value: ");
        string areaValues = Console.ReadLine();

        Area currentArea = new Area();
        List<IRobot> robots = new List<IRobot>();

        while (true)
        {
            Console.Write("Enter the current position value: ");
            string robotValues = Console.ReadLine();

            currentArea.X = int.Parse(areaValues.Split(' ')[0]);
            currentArea.Y = int.Parse(areaValues.Split(' ')[1]);

            Console.Write("Chooese Mini or Normal Robot (M/N): ");
            string chooseRobot = Console.ReadLine();

            Console.WriteLine("");
            Console.WriteLine("You can use L,R,M for Normal Robot " + "\n" +
                              "You can use B,M for Mini Robot " + "\n" +
                              "L: Turn Left" + "\n" +
                              "R: Turn Right" + "\n" +
                              "M: Move Forward" + "\n" +
                              "B: Turn Back");
            Console.WriteLine("");

            Console.Write("Enter how to move: ");
            string movementValues = Console.ReadLine();

            IRobot currentRobot = chooseRobot switch
            {
                "N" => new NormalRobot(),
                "M" => new MiniRobot(),
                _ => throw new InvalidOperationException(),
            };

            currentRobot.X = int.Parse(robotValues.Split(' ')[0]);
            currentRobot.Y = int.Parse(robotValues.Split(' ')[1]);
            currentRobot.M = movementValues;
            Enum.TryParse(robotValues.Split(' ')[2], out Direction direction);
            currentRobot.Direction = direction;
            robots.Add(currentRobot);

            Console.Write("Would you like to continue? (Y/N): ");
            string choice = Console.ReadLine();
            Console.WriteLine("----------------------");
            Console.WriteLine("");
            if (choice == "N")
            {
                break;
            }
        }

        foreach (IRobot currentRobot in robots)
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("***BEFORE***");
            Console.WriteLine("");
            currentArea.ShowMatrix(currentRobot);
            Console.WriteLine();

            currentRobot.Movement();
            RedirectDirection(currentRobot);

            Console.WriteLine();
            currentArea.ShowMatrix(currentRobot);
            Console.WriteLine("");
            Console.WriteLine("***AFTER***");
            Console.WriteLine("----------------------");
        }
    }

    static void RedirectDirection(IRobot robot)
    {
        Console.WriteLine("P1 new direction : " + robot.X + " " + robot.Y + " " + robot.Direction);
    }
}