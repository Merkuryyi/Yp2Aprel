using System;

class Worker
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public double Rate { get; set; }
    public int Days { get; set; }
    
    public double GetSalary()
    {
        return Rate * Days;
        
    }

}

class Program
{
    static void Main()
    {
        Console.WriteLine("Веедите последовательно Имя, Фамилию, ставка за рабочий день и количетсво отработанных дне");
        Worker worker = new Worker
        {
            Name = Console.ReadLine(),
            Surname = Console.ReadLine(),
            Rate = double.Parse(Console.ReadLine()),
            Days = int.Parse(Console.ReadLine())
        };

        Console.WriteLine($"Зарплата работника {worker.Name} {worker.Surname}: {worker.GetSalary()}");
    }
}    