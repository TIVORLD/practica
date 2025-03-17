class Program
{
    static void Main()
    {
        Console.WriteLine("Введите начальную скорость v0 (м/с):");
        double v0 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите ускорение a (м/с²):");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите время t (с):");
        double t = Convert.ToDouble(Console.ReadLine());
 
        double S = v0 * t + 0.5 * a * t * t;
        double v = v0 + a * t;

        Console.WriteLine($"Пройденное расстояние S: {S} м");
        Console.WriteLine($"Конечная скорость v: {v} м/с");
    }
}