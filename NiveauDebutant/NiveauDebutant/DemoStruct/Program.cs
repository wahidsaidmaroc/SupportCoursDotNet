



Point point = new Point(10, 20);

point.Display();

point.X = 100;
point.Y = 200;

point.Display();



public struct Point
{
    public int X { get; set; }
    public int Y { get; set; }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public void Display()
    {
        Console.WriteLine($"Point: ({X}, {Y})");
    }
}