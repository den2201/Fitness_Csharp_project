using System;
using System.Collections.Generic;
using System.Text;

namespace Fitness_BL.Model
{
    /// <summary>
    /// Прием пищи
    /// </summary>
    public class Eating
    {

        public DateTime Moment { get; }

       public Dictionary<Food,double> Foods { get; }
        public User User { get; }
      
        public Eating(User user)
        {
            User = user ?? throw new ArgumentNullException("Пользователь не может быть пустым", nameof(user));
            Moment = DateTime.UtcNow;
            Foods = new Dictionary<Food, double>();
        }
        public void Add(Food food,double weight)
        {
            var product = Foods.ContainsKey(food);
            if(product==false)
            {
                Foods.Add(food, weight);
            }
            else
            {
                Foods[food] += weight;
            }
        }
    }
}
