using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online2.ViewModels.MealViewModels
{
    public class MealCreateVM 
    {
        public string MealName { get; set; }

        public DateTime CreateOn => DateTime.Now;


    }
}
