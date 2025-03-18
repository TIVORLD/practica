class Program
{
    static void Main()
    {
        Console.WriteLine("Введите четырехзначное число:");
        string input = Console.ReadLine();

        if (input.Length == 4 && int.TryParse(input, out int number))
        {
            if (input[0] == input[3] && input[1] == input[2])
            {
                Console.WriteLine("Да, число является палиндромом.");
            }
            else
            {
                Console.WriteLine("Нет, число не является палиндромом.");
            }
        }
        else
        {
            Console.WriteLine("Ошибка: введите корректное четырехзначное число.");
        }
    }
}