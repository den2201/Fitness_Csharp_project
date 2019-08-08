using Fitness_BL.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fitness_BL.Controller
{
   public class EatingControler
    {
        private readonly User user;
        public EatingControler(User user)
        {
            this.user = user ?? throw new ArgumentNullException("Пользователь не может быть пустым", nameof(user));
            
        }
    }
}
