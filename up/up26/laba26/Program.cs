using System;
namespace laba26
{
    public class Programm
    {
        static void Main()
        {
            Console.WriteLine("login");
            string login = Console.ReadLine();
            Console.WriteLine("password");
            string password = Console.ReadLine();
           
            var conn = connectDatabase.GetSqlConnection();
            Console.WriteLine("Авторизация - 1, регистрация - 2");
            int com = int.Parse(Console.ReadLine());
            
            if (com == 1)
            {
                
                dailyPlanner.authorization(login, password);
                if (dailyPlanner.authorization(login, password))
                {
                    Console.WriteLine("Введите команду:\n" +
                                      "0 - выйти\n" +
                                      "1 - добавить задачу, 2 - удалить задачу, 3 - редактировать задачу\n" +
                                      "Показать задачи на 4 - сегодня, 5 - завтра, 6 - неделю\n" +
                                      "Показать все задачи - 7 , прошедшие - 8, будущие - 9");

                    while (true)
                    {     
                        int comm = int.Parse(Console.ReadLine());
                        if (comm == 0)
                        {
                            break;
                        }

                       

                            switch (comm)
                            {
                                case 1:
                                    dailyPlanner.addTasks(login);
                                    break;
                                case 2:
                                    dailyPlanner.deleteTasks(login);
                                    break;
                                case 3:
                                    dailyPlanner.updateTasks(login);
                                    break;
                                case 4:
                                    dailyPlanner.tasksTimeToday(login);
                                    break;
                                case 5:
                                    dailyPlanner.tasksTimeTomorrow(login);
                                    break;
                                case 6:
                                    dailyPlanner.tasksTimeWeek(login);
                                    break;
                                case 7:
                                    dailyPlanner.tasksAll(login);
                                    break;
                                case 8:
                                    dailyPlanner.tasksPast(login);
                                    break;
                                case 9:
                                    dailyPlanner.tasksUpcoming(login);
                                    break;
                                default:
                                    Console.WriteLine("Команда не найдена");
                                    break;

                            }
                        
                    }
                    
                }
                if (!dailyPlanner.authorization(login, password))
                {
                    Console.WriteLine("Логин или пароль неверны");
                }
                
            }
            else if (com == 2)
            {
                dailyPlanner.registration(login, password);
                
            }
            else
            {
                 Console.WriteLine("Команда не найдена");
            }
           
      
        }
    }

}


