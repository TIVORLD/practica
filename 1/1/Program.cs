using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите первое вещественное число:");
        double firstNumber = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите второе вещественное число:");
        double secondNumber = Convert.ToDouble(Console.ReadLine());

        double sum = firstNumber + secondNumber;

        Console.WriteLine($"Сумма чисел: {sum:F2}");
    }
}