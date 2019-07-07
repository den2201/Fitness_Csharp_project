using Fitness_BL.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;

/// <summary>
///  Создаем Контроллер, который работает с пользователем.
/// </summary>
namespace Fitness_BL.Controller
{
    public class UserController
    {
        /// <summary>
        /// создаем Свойство типа User в контроллере
        /// </summary>
        public List<User> Users { get; }
        public User CurrentUser { get; set; }

        public bool IsNewUserFlag { get; } = false;
        /// <summary>
        /// Создание нового  контроллера поьзователя
        /// </summary>
        /// <param name="user"></param>
        public UserController(string userName)

        {
            if(string.IsNullOrWhiteSpace(userName))
            {
                throw new ArgumentNullException("Имя пользователя не может быть пустым", nameof(userName));
            }
            //TODO: проверка

            Users = GetUserData();
            CurrentUser = Users.SingleOrDefault(u => u.Name==userName);
          if(CurrentUser==null)
            {
                IsNewUserFlag = true;
        CurrentUser = new User(userName);
                if (IsNewUserFlag)
                {
                    Console.WriteLine("Введите пол нового пользователя: ");
                    string gender = Console.ReadLine();
                    DateTime birthDay;
                    while (true)
                    {
                        Console.WriteLine("Введите возраст дату рождения нового пользователя: ");
                        if (DateTime.TryParse(Console.ReadLine(), out birthDay))
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Неверный формат даты");
                        }
                        
                        
                    }
                    SetNewData(gender,birthDay);
                    Users.Add(CurrentUser);
                    Save();

                }


            }
        }

        
        public static double TryParseDouble(string name)
        {
            while(true)
            Console.WriteLine(@"Введите {name}: ");
            if (double.TryParse(Console.ReadLine(), out double tryPardedouble))
            {
                return tryPardedouble;
            }
            else
            {
                Console.WriteLine("Неверный формат ввода");
            }
        }


        /// <summary>
        /// Получить список пользователей
        /// </summary>
        /// <returns></returns>
        private List<User> GetUserData()
        {
            /// <summary>
            /// Загружаем данные пользователя из файла
            /// </summary>
            /// <returns></returns>

            var formatter = new BinaryFormatter();
            using (var fs = new FileStream("users.dat", FileMode.OpenOrCreate))
            {
                if (formatter.Deserialize(fs) is List<User> users)
                {
                    return users;
                }
               
                    else
                {
                    return new List<User>();
                }
                               // TODO: Что делать, если пользователя не прочитали


            }

        }
        /// <summary>
        /// Метод добавления данных новому пользователю
        /// </summary>
        /// <param name="genderName"></param>
        /// <param name="birthDate"></param>
        /// <param name="weight"></param>
        /// <param name="height"></param>

        public  void SetNewData(string genderName, DateTime birthDate, double weight = 1, double height = 1)
        {
            CurrentUser.Gender = new Gender(genderName);
            CurrentUser.DateOfBirth = birthDate;
            CurrentUser.Weight = weight;
            CurrentUser.Height = height;


        }

        /// <summary>
        ///Сохранить данные пользователя
        /// </summary>
        /// <returns></returns>
        public void Save()
        {
            var formatter = new BinaryFormatter();
            using (var fs = new FileStream("users.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, Users);

            }
        }
    }

   
   

}

       
    

