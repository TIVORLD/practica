class Program
{
    static void Main()
    {
        Console.Write("Введите цену 1 кг конфет (1 <= A <= 100): ");
        int pricePerKg = Convert.ToInt32(Console.ReadLine());
 
        if (pricePerKg < 1 || pricePerKg > 100)
        {
            Console.WriteLine("Ошибка: цена должна быть в диапазоне от 1 до 100.");
            return;
        }

        Console.WriteLine("Стоимость конфет:");
        for (int kg = 1; kg <= 10; kg++)
        {
            int totalCost = pricePerKg * kg;
            Console.WriteLine($"{kg} кг конфет = {totalCost} рублей");
        }
    }
}