class Program
{
    static void Main()
    {
        Console.WriteLine("Введите целое число N (1 <= N <= 20):");
        int N = Convert.ToInt32(Console.ReadLine());
 
        if (N < 1 || N > 20)
        {
            Console.WriteLine("Ошибка: N должно быть в диапазоне от 1 до 20.");
            return;
        }

        double sum = 0.0;

        for (int i = 1; i <= N; i++)
        {
            sum += 1.0 / i;   
        }

        Console.WriteLine($"Сумма 1 + 1/2 + ... + 1/{N} = {sum:F4}");
    }
}