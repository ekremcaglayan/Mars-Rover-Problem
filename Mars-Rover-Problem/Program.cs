﻿using System.Linq.Expressions;
using System.Numerics;

public static class Program
{
    static void Main(string[] args)
    {
        Console.Write("Alan değerini giriniz: ");
        string areaValues = Console.ReadLine();

        Area currentArea = new Area();
        List<Robot> robots = new List<Robot>();

        while (true)
        {
            Console.Write("Mevcut konum değerini giriniz: ");
            string robotValues = Console.ReadLine();
            Console.Write("Nasıl ilerleyeceğini giriniz: ");
            string movementValues = Console.ReadLine();

            currentArea.X = int.Parse(areaValues.Split(' ')[0]);
            currentArea.Y = int.Parse(areaValues.Split(' ')[1]);

            Robot currentRobot = new Robot();
            currentRobot.X = int.Parse(robotValues.Split(' ')[0]);
            currentRobot.Y = int.Parse(robotValues.Split(' ')[1]);
            currentRobot.M = movementValues;
            Enum.TryParse(robotValues.Split(' ')[2], out Direction direction);
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

    static void RedirectDirection(Robot robot)
    {
        Console.WriteLine("P1 new direction : " + robot.X + " " + robot.Y + " " + robot.Direction);
    }
}