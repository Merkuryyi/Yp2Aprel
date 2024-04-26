using System;

class Calculation
{
    private string calculationLine;
    public void SetCalculationLine(string newValue)
    {
        calculationLine = newValue;
    }
    public void SetLastSymbolCalculationLine(string symbol)
    {
        calculationLine += symbol;
    }
    public string GetCalculationLine()
    {
        return calculationLine;
    }
    public char GetLastSymbol()
    {
        if (!string.IsNullOrEmpty(calculationLine))
        {
            return calculationLine[calculationLine.Length - 1];
        }
        return '\0'; 
    }

    public void DeleteLastSymbol()
    {
        if (!string.IsNullOrEmpty(calculationLine))
        {
            calculationLine = calculationLine.Substring(0, calculationLine.Length - 1);
        }
    }
}

class Program
{
    static void Main()
    {
        Calculation calculation = new Calculation();
        Console.WriteLine("Введите строку");
        calculation.SetCalculationLine(Console.ReadLine());
        Console.WriteLine("Введите последний символ");
        calculation.SetLastSymbolCalculationLine(Console.ReadLine());
       
        Console.WriteLine($"Current Calculation Line: {calculation.GetCalculationLine()}");

        Console.WriteLine($"Последний символ: {calculation.GetLastSymbol()}");

        calculation.DeleteLastSymbol();
        Console.WriteLine($"Calculation Line после удаления последнего символа: {calculation.GetCalculationLine()}");
    }
}