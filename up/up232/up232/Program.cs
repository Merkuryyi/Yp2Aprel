using System;
class Worker
{
    private string name;
    private string surname;
    private double rate;
    private int days;

    public Worker(string name, string surname, double rate, int days)
    {
        this.name = name;
        this.surname = surname;
        this.rate = rate;
        this.days = days;
    }


    public double GetSalary()
    {
        return rate * days;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Веедите последовательно Имя, Фамилию, ставка за рабочий день и количетсво отработанных дней");
        string name = Console.ReadLine();
        string surname = Console.ReadLine();
        double rate = double.Parse(Console.ReadLine());
        int days = int.Parse(Console.ReadLine());
        Worker worker = new Worker(name, surname, rate, days);
        Console.WriteLine($"Зарплата работника {name} {surname}: {worker.GetSalary()}");        
    }
}