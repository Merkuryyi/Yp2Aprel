using System;
class Counter
{
    private int count;
    public Counter() 
    {
        count = 1; 
    }
    public Counter(int initialValue)
    {
        count = initialValue; 
    }
    public int Increment()
    {
        return ++count;
    }
    public int Decrement() 
    {
        return --count;
    }
    public int GetCount(){
        return count;
    }
}
class Program
{
    static void Main()
    {
        Counter counter1 = new Counter();
        Console.WriteLine($"Счетчик по умолчанию: {counter1.GetCount()}");
        Console.WriteLine($"Счетчик + 1: {counter1.Increment()}");
        
        counter1.Decrement();
        Console.WriteLine($"Счетчик - 1: {counter1.Decrement()}");
        
        Console.WriteLine("Введите произвольный счетчик:");
        int initialValue = int.Parse(Console.ReadLine());
        Counter counter2 = new Counter(initialValue);
        
        Console.WriteLine($"Произвольный счетчик + 1: {counter2.Increment()}");
        counter2.Decrement();
        Console.WriteLine($"Произвольный счетчик - 1: {counter2.Decrement()}");
    }
}