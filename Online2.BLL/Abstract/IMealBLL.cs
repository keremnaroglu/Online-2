using Online2.Entity;
using Online2.Syst;
using Online2.ViewModels.MealViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online2.BLL.Abstract
{
    public interface IMealBLL : IBaseBLL<Meal>
    {
        ResultService<Meal> CreateMeal(MealCreateVM vm);

        ResultService<MealUpdateVM> UpdateMeal(MealUpdateVM vm);

        ResultService<MealBaseVM> DeleteMeal(int id);

        ResultService<Meal> GetMeal(string mealName);

        ResultService<Meal> GetMeal(int id);

        ResultService<MealBaseVM> GetAllMeal();

    }
}
