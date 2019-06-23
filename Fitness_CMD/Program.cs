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
            var userController = new UserController(userName);
          

            Console.WriteLine(userController.CurrentUser);

            Console.ReadKey();
           


            


        }
    }
}
