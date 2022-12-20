using Online2.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online2.Entity
{
    public class Category : BaseEntity
    {
        public string CategoryName { get; set; }

        public virtual ICollection<Food> Foods { get; set; }

        public Category()
        {
            isActive = true;
            Foods = new HashSet<Food>();
        } 
    }
}
