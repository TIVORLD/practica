class Program
{
    static void Main()
    {
        Console.WriteLine("Введите величину временного интервала (в минутах):");
        int minutes = Convert.ToInt32(Console.ReadLine());

        int hours = minutes / 60; 
        int remainingMinutes = minutes % 60;

        Console.WriteLine($"{minutes} минут — это {hours}ч. {remainingMinutes} мин.");
    }
}