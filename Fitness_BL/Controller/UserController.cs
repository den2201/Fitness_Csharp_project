using Fitness_BL.Model;
using System;
using System.IO;
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
        public User User { get; }

        /// <summary>
        /// Создание нового  контроллера поьзователя
        /// </summary>
        /// <param name="user"></param>
        public UserController(string userName, string genderName, DateTime birthDay,double weigth,double height)
        {
            //TODO: проверка
            var gender = new Gender(genderName);
             User = new User(userName,gender,birthDay,weigth,height);
            
        }

        public UserController()
        {
            /// <summary>
            /// Загружаем данные пользователя из файла
            /// </summary>
            /// <returns></returns>

            var formatter = new BinaryFormatter();
            using (var fs = new FileStream("user.dat", FileMode.OpenOrCreate))
            {
                if (formatter.Deserialize(fs) is User user)
                {
                    User = user;
                }
                // TODO: Что делать, если пользователя не прочитали


            }

        }
        public void Save()
        {
            var formatter = new BinaryFormatter();
            using (var fs = new FileStream("users.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, User);

            }
        }
    }

    /// <summary>
    ///Сохранить данные пользователя
    /// </summary>
    /// <returns></returns>
   

}

       
    

