using System;
class Train
{
    public string Destination {get; set;}
    public string TrainNumber {get; set;}
    public DateTime DepartureTime {get; set;}
    public Train(string destination, string trainNumber, DateTime departureTime)
    {
        Destination = destination;
        TrainNumber = trainNumber;
        DepartureTime = departureTime;
    }
    public void DisplayTrainInfo() 
    {
        Console.WriteLine($"Номер поезда: {TrainNumber}");
        Console.WriteLine($"Место назначения: {Destination}");
        Console.WriteLine($"Время отправления: {DepartureTime}");
    }
}
class Program
{
    static void Main()
    {
        Train train1 = new Train("Москва", "1", new DateTime(2024, 4, 7, 12, 0, 0));
        Train train2 = new Train("Санкт-Петербург", "2", new DateTime(2024, 4, 8, 8, 30, 0));
        Train train3 = new Train("Челябинск", "3", new DateTime(2024, 6, 1, 10, 45, 0));
        Console.WriteLine("Введите номер поезда:");
        string userInput = Console.ReadLine();
        if (userInput == train1.TrainNumber){
            train1.DisplayTrainInfo();
        }
        else if (userInput == train2.TrainNumber) 
        {
            train2.DisplayTrainInfo();
        }
        else if (userInput == train3.TrainNumber)
        {
            train3.DisplayTrainInfo();
        }
        else{
            Console.WriteLine("Неверный номер поезда");
        }
    }
}