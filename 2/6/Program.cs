class Program
{
    static void Main()
    {
        Console.Write("Введите номер дня: ");
        int day = Convert.ToInt32(Console.ReadLine());

        int daysInMonth = 31; 

        if (day < 1 || day > daysInMonth)
        {
            Console.WriteLine("Некорректный номер дня.");
        }
        else
        {
            int daysRemaining = daysInMonth - day;
            Console.WriteLine($"Осталось дней до конца месяца: {daysRemaining}");
        }
    }
}