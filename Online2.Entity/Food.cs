using Online2.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Online2.Entity
{
    public class Food : BaseEntity
    {
        public string FoodName { get; set; }

        public string Description { get; set; }

        public double Calorie { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }


        public virtual ICollection<MealFood> MealFoods { get; set; }

        public Food()
        {
            isActive = true;
            MealFoods = new HashSet<MealFood>();
        }
    }
}
