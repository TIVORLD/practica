using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите трехзначное число с различными цифрами:");
        int number = Convert.ToInt32(Console.ReadLine());
 
        if (IsValid(number))
        {
            List<int> permutations = new List<int>();
            GeneratePermutations(number.ToString().ToCharArray(), 0, permutations);

            Console.WriteLine("Перестановки цифр:");
            foreach (var perm in permutations)
            {
                Console.WriteLine(perm);
            }
        }
        else
        {
            Console.WriteLine("Введите корректное трехзначное число с различными цифрами.");
        }
    }

    static bool IsValid(int number)
    {  
        if (number < 100 || number > 999)
            return false;

        string strNum = number.ToString();
        return strNum[0] != strNum[1] && strNum[0] != strNum[2] && strNum[1] != strNum[2];
    }

    static void GeneratePermutations(char[] array, int startIndex, List<int> result)
    {
        if (startIndex == array.Length - 1)
        {
            result.Add(Convert.ToInt32(new string(array)));
            return;
        }

        for (int i = startIndex; i < array.Length; i++)
        {
            Swap(ref array[startIndex], ref array[i]);
            GeneratePermutations(array, startIndex + 1, result);
            Swap(ref array[startIndex], ref array[i]);
        }
    }

    static void Swap(ref char a, ref char b)
    {
        char temp = a;
        a = b;
        b = temp;
    }
}