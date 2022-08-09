class Area
{
    public int X { get; set; }
    public int Y { get; set; }

    public void ShowMatrix(IRobot currentRobot)
    {
        int i, j;

        for (j = Y - 1; j >= 0; j--)
        {
            for (i = 0; i < X; i++)
            {
                //Console.Write(" ");
                if (i == currentRobot.X && j == currentRobot.Y)
                {
                    Reporter.Report();
                }
                else
                {
                    Console.Write(0 + " ");
                }
            }
            Console.WriteLine();
        }
    }
}