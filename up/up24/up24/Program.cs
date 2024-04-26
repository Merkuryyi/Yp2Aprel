using System;
class Program
{
    static string ToRoman(int number)
    {
        string[] romanNumerals = {"I", "IV", "V", "IX", "X", "XL", "L", "XC", "C", "CD", "D", "CM", "M"};
        int[] numbers =          {1,    4,    5,    9,   10,  40,   50,  90,  100,  400,  500, 900, 1000};

        string result = " ";
        int i = 12;

        while (number > 0)
        {
            int div = number / numbers[i];
            number %= numbers[i];

            while (div > 0)
            {
                result += romanNumerals[i];
                div--;
            }
            i--;
        }
        return result;
    }
    static void Main()
    {
        Console.Write("Введите целое число: ");
        int number = int.Parse(Console.ReadLine());
        string romanNumber = ToRoman(number);
        Console.WriteLine($"Римское число: {romanNumber}");
    }
}