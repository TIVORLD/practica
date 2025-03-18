class Program
{
    static void Main()
    {
        Console.WriteLine("Двухзначные числа, равные утроенному произведению своих цифр:");

        for (int number = 10; number < 100; number++)
        {
            int numb = number / 10;
            int per = number % 10;  

            if (number == 3 * (numb * per))
            {
                Console.WriteLine(number);
            }
        }
    }
}