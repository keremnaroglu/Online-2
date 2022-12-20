using Online2.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online2.Entity
{
    public class User : BaseEntity
    {
        public string UserName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public UserTypes UserTypes { get; set; }

        public virtual ICollection<MealFood> MealFoods { get; set; }


        public User()
        {
            isActive = true;
            MealFoods = new HashSet<MealFood>();
        }
    }
}
