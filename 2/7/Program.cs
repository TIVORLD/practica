class Program
{
    static void Main()
    {
        Console.Write("Введите текущий курс доллара: ");
        double exchangeRate = Convert.ToDouble(Console.ReadLine());

        PrintWithWhile(exchangeRate);
        PrintWithDoWhile(exchangeRate);
        PrintWithFor(exchangeRate);
    }

    static void PrintWithWhile(double exchangeRate)
    {
        Console.WriteLine("Таблица перевода долларов в рубли (цикл while):");
        int dollars = 5;
        while (dollars <= 500)
        {
            double rubles = dollars * exchangeRate;
            Console.WriteLine($"{dollars} долларов США = {rubles} рублей");
            dollars += 5;
        }
        Console.WriteLine();
    }

    static void PrintWithDoWhile(double exchangeRate)
    {
        Console.WriteLine("Таблица перевода долларов в рубли (цикл do while):");
        int dollars = 5;
        do
        {
            double rubles = dollars * exchangeRate;
            Console.WriteLine($"{dollars} долларов США = {rubles} рублей");
            dollars += 5;
        } while (dollars <= 500);
        Console.WriteLine();
    }

    static void PrintWithFor(double exchangeRate)
    {
        Console.WriteLine("Таблица перевода долларов в рубли (цикл for):");
        for (int dollars = 5; dollars <= 500; dollars += 5)
        {
            double rubles = dollars * exchangeRate;
            Console.WriteLine($"{dollars} долларов США = {rubles} рублей");
        }
    }
}