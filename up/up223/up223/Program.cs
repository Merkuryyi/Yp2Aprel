using System;
class NumberHolder
{
    private int Number1 { get; set; }
    private int Number2 { get; set; }
    public void ChangeNumbers(int newNumber1, int newNumber2)
    {
        Number1 = newNumber1;
        Number2 = newNumber2;
    }
    public void DisplayNumbers(){
        Console.WriteLine($"Число 1: {Number1}");
        Console.WriteLine($"Число 2: {Number2}");
    }

    public int CalculateSum()
    {
        return Number1 + Number2;
    }

    public int FindMaxNumber()
    {
        return Math.Max(Number1, Number2);
    }
}
class Program
{
    static void Main()
    {
        NumberHolder numbers = new NumberHolder();
        Console.WriteLine("Число 1:");
        int inputNumber1 = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Число 2:");
        int inputNumber2 = int.Parse(Console.ReadLine());
        
        numbers.ChangeNumbers(inputNumber1, inputNumber2);
        numbers.DisplayNumbers();
        Console.WriteLine($"Сумма: {numbers.CalculateSum()}");
        Console.WriteLine($"Максимальное: {numbers.FindMaxNumber()}");
    }
}