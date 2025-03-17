class Program
{
    static void Main()
    {
        double x = 2.7;  
        double y = 3 * Math.Pow(x, 2) + Math.Exp(Math.Sqrt(x)) / (2 * Math.PI) - Math.Log(Math.Sqrt(3 - Math.Pow(Math.Sin(x), 2)));
        Console.WriteLine($"Значение y при x={x}: {y}");
    }
}