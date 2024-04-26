using System;

namespace up25
{
    public class Program
    {
       
        static void Main()
        {
            Console.WriteLine("1 - Просмотр типов машин (type_car), 2  - добавление новых типов машин");
            Console.WriteLine("3 - Просмотр водителей и прав,       4  - Добавление водителей и прав");
            Console.WriteLine("5 - Просмотр машин (car),            6  - добавление машин");
            Console.WriteLine("7 - Просмотр маршрутов (itinerary),  8  - добавление маршрутов");
            Console.WriteLine("9 - Просмотреть рейс (route),        10 - добавить рейс");
            int comm = int.Parse(Console.ReadLine());
            switch (comm)
            {
                case 1:
                    transport.getType_car();
                    break;
                case 2:
                    transport.writeType_Car();
                    break;
                case 3:
                    transport.getDriversAndRights();
                    break;
                case 4:
                    transport.writeDrivers();
                    transport.writeRightsForDriver();
                    break;
                case 5:
                    transport.getCar();
                    break;
                case 6:
                    transport.writeCar();
                    break;
                case 7:
                    transport.getItinerary();
                    break;
                case 8:
                    transport.writeItinerary();
                    break;
                case 9:
                    transport.getRoute();
                    break;
                case 10:
                    transport.writeRote();
                    break;
            }


        }

    }
}