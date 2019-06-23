using Fitness_BL.Model;
using Fitness_BL.Controller;
using System;

namespace Fitness_CMD
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\n\n\n\t\t\tВас приветствует приложение Fitness!!! \n\n\t\t\tНаписано Никифоровым Денисом на интенсиве youtube канала CODEBLOG!");

            Console.WriteLine("\n\n\n\n\n\n\n\nPress any key");
            
            Console.ReadKey();
            Console.Beep();

            Console.Clear();
            Console.WriteLine("Введите имя пользователя: ");
            var userName = Console.ReadLine();
            Console.WriteLine("Введите пол: ");
            string gender = Console.ReadLine();
            Console.WriteLine("Введите дату Вашего рождения: ");
            var birthDay =  DateTime.Parse(Console.ReadLine()); //TODO: Переписать на TRYPARSE
            Console.WriteLine("Введите Ваш вес: ");
            double weight = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите Ваш рос: ");
            double height = double.Parse(Console.ReadLine());

            var userController = new UserController(userName, gender, birthDay, weight, height);
            userController.Save();



            


        }
    }
}
