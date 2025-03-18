class Program
{
    static void Main()
    {
        Console.WriteLine("Введите стороны a, b, c:");
        double a = Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());
        double c = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine((a + b > c && a + c > b && b + c > a) ? "Треугольник существует." : "Треугольник не существует.");
    }
}