using System;
using System.Collections.Generic;
using System.Text;

namespace Fitness_BL.Model
{
    [Serializable]
    public class User
    {
        #region Свойства User
        /// <summary>
        /// Имя
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Пол
        /// </summary>
        public Gender Gender { get; set; }

        /// <summary>
        /// Дата Рождения
        /// </summary>
        public DateTime DateOfBirth { get; set; }

        /// <summary>
        /// ВЕС
        /// </summary>
        public double Weight { get; set; }

        /// <summary>
        /// Рост
        /// </summary>
        public double Height { get; set; }
        
        /// <summary>
        /// Вычисляемое свойство Возраста User 
        /// </summary>
        public int Age { get { return DateTime.Now.Year - DateOfBirth.Year; } }

        /// <summary>
        /// Флаг плучения данных пользователя (новый или данные из файла)
        /// </summary>
        

        #endregion

        
        /// <summary>
        /// Инициализакия нового пользователя
        /// </summary>
        public User(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Имя пользователя не может быть пустым или null.", nameof(name));
            }

            Name = name;

        }

        public User(string name, Gender gender, DateTime birth, double weight, double height)
        {
            
            #region Проверка входных параметров
            
            
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Имя пользователя не может быть пустым или null.", nameof(name));
            }
            
            if (gender == null)
            {
                throw new ArgumentNullException("Пол не может быть null.", nameof(gender));

            }
            if ((birth < DateTime.Parse("01.01.1900"))||(birth>=DateTime.Now))
            {
                throw new ArgumentException("Невозможная дата Рождения.", nameof(birth));

            }

            if (weight<=0)
            {
                throw new ArgumentException("Вес не может быть меньше либо равен нулю.", nameof(weight));
            }

            if(height<=0)
            {
                throw new ArgumentException("Рос не может быть меньше либо равен нулю.", nameof(height));

            }

            #endregion

                                         Name = name;
                                        Gender = gender;
                                        DateOfBirth = birth;
                                        Weight = weight;
                                        Height = height;
                

        }

        public override string ToString()
        {
            return Name + @". Возраст: "+Age;
        }
    }
}
