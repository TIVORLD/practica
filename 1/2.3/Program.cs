class Program
{
    static void Main()
    {
        Console.WriteLine("Введите значение m:");
        double m = Convert.ToDouble(Console.ReadLine());

        if (m <= 0)
        {
            Console.WriteLine("Значение m должно быть положительным и больше нуля.");
            return;
        }

        double z1 = Math.Sqrt(Math.Pow(3 * m + 2, 2) - 24 * m) / (3 * Math.Sqrt(m) - 2 / Math.Sqrt(m));

        double z2 = -Math.Sqrt(m);

        Console.WriteLine($"z1 = {z1}");
        Console.WriteLine($"z2 = {z2}");
    }
}