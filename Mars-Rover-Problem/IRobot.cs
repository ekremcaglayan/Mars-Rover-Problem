interface IRobot
{
    public Direction Direction { get; set; }
    public int X { get; set; }
    public int Y { get; set; }
    public string M { get; set; }
    void Movement();
}
