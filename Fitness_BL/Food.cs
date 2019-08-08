using System;
using System.Collections.Generic;
using System.Text;

namespace Fitness_BL
{
     public class Food
    {
        /// <summary>
        /// Название
        /// </summary>
        public string Name { get; set; }
        public double Proteins { get; }
        /// <summary>
        /// Жиры
        /// </summary>
        public double Fats { get; }

        /// <summary>
        /// Углеводы
        /// </summary>
        public double Carbohydrates { get; }
        /// <summary>
        /// Калории за 100 грамм
        /// </summary>
        public double Calories { get; }

      

        public Food(string name):this(name,0,0,0,0)
        {
            //TODO:check
            Name = name;

        }
        public Food(string name, double callories, double proteins, double fats, double carby)
        {
            //TODO: check
            Name = name;
            Calories = callories / 100.0;
            Proteins = proteins / 100.0;
            Fats = fats / 100.0;
            Carbohydrates = carby / 100.0;
        }

       public override
    }
}
