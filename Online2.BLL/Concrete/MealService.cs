using Online2.BLL.Abstract;
using Online2.DAL.Abstract;
using Online2.Entity;
using Online2.Syst;
using Online2.ViewModels.MealViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online2.BLL.Concrete
{
    public class MealService : IMealBLL
    {
        private readonly IMealDAL _mealDAL;

        public MealService(IMealDAL mealDAL)
        {
            _mealDAL = mealDAL;
        }

        public ResultService<Meal> CreateMeal(MealCreateVM vm)
        {
            ResultService<Meal> result = new ResultService<Meal>();

            Meal newMeal = new Meal()
            {
                 MealName = vm.MealName,
                 CreateOn = vm.CreateOn
            };

            Meal addMeal = _mealDAL.Add(newMeal);

            if (addMeal == null)
            {
                result.AddError("Hata oluştu", "Ekleme işlemi başarısız");
            }

            result.Data = addMeal ?? newMeal;

            return result;
  
        }

        public ResultService<MealUpdateVM> UpdateMeal(MealUpdateVM vm)
        {
            ResultService<MealUpdateVM> result = new ResultService<MealUpdateVM>();

            try
            {
                Meal meal = _mealDAL.Get(x => x.isActive && x.Id == vm.Id);
                meal.MealName = vm.MealName;
                meal.UpdateOn = vm.UpdateOn;

                Meal updateMeal = _mealDAL.Update(meal);
                result.Data = vm;
            }
            catch (Exception)
            {

                result.Data = vm;
                result.AddError("Güncelleme başarısız", "Kayıt bulunamadı");
            }

            return result;
        }

        public ResultService<MealBaseVM> DeleteMeal(int id)
        {
            ResultService<MealBaseVM> result = new ResultService<MealBaseVM>();

            try
            {
                Meal meal = _mealDAL.Get(x => x.isActive && x.Id == id);
                meal.isActive = false;

                result.Data = new MealBaseVM
                {
                    MealName = meal.MealName
                };

                _mealDAL.Delete(meal);
            }
            catch (Exception)
            {

                result.AddError("Silme işlemi başarısız", "Kayıt bulunamadı");
            }

            return result;
        }

        public ResultService<MealBaseVM> GetAllMeal()
        {
            ResultService<MealBaseVM> result = new ResultService<MealBaseVM>();

            List<MealBaseVM> baseList = _mealDAL.GetAll(x => x.isActive)
                                                .Select(x => new MealBaseVM() 
                                                {
                                                    Id = x.Id,
                                                    MealName = x.MealName

                                                }).ToList();

            if (baseList.Count > 0)
            {
                result.ListData = baseList; 
            }
            else
            {
                result.AddError("Hata", "Verilere ulaşılamadı");
            }

            return result;
        }

        public ResultService<Meal> GetMeal(string mealName)
        {
            ResultService<Meal> result = new ResultService<Meal>();

            result.Data = _mealDAL.Get(x => x.isActive && x.MealName.Equals(mealName));

            if (result.Data == null)
            {
                result.AddError("Kayıt bulunamadı", "Kayıt bulunamadı");
            }

            return result;
        }

        public ResultService<Meal> GetMeal(int id)
        {
            ResultService<Meal> result = new ResultService<Meal>();

            result.Data = _mealDAL.Get(x => x.isActive && x.Id.Equals(id));

            if (result.Data == null)
            {
                result.AddError("Kayıt bulunamadı", "Kayıt bulunamadı");
            }

            return result;
        }

        
    }
}
