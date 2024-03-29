﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Fitness_BL.Model
{
    [Serializable]
    /// <summary>
    /// Описываем класс Gender
    /// </summary>
    public class Gender
    {

        /// <summary>
        ///  Название
        /// </summary>
        public string Name { get; }
    
        /// <summary>
        /// Создаем новый пол
        /// </summary>
        /// <param name="name"> Имя пола </param>
       public Gender(string name)
        {
            if(string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Имя пола не может быть пустым или null",nameof(name));
            }
            Name = name;

        }

        public override string ToString()
        {
            return Name;
        }
    }
}
