using System;
class MyClass
{
    public int Property1 {get; set;}
    public string Property2 {get; set;}
    public MyClass(int value1, string value2)
    {
        Property1 = value1;
        Property2 = value2;
    }
    public MyClass()
    {
        Property1 = 0;
        Property2 = "default";
    }
    ~MyClass()
    {
        Console.WriteLine("Объект удален.");
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Введите свойство 1: ");
        int property1 = int.Parse(Console.ReadLine());
        Console.Write("Введите свойство 2: ");
        string property2 = Console.ReadLine();
        MyClass obj1 = new MyClass(property1, property2);
        Console.WriteLine($"Объект: Свойство 1 = {obj1.Property1}, Свойство 2 = {obj1.Property2}");

        MyClass obj2 = new MyClass();
        Console.WriteLine($"Объект 2 по умолчанию: Свойство 1 = {obj2.Property1}, Свойство 2 = {obj2.Property2}");
    }
}