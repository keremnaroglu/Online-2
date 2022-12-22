using Online2.BLL.Abstract;
using Online2.DAL.Abstract;
using Online2.Entity;
using Online2.Syst;
using Online2.ViewModels.CategoryViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online2.BLL.Concrete
{
    public class CategoryService : ICategoryBLL
    {
        private readonly ICategoryDAL _categoryDAL;

        public CategoryService(ICategoryDAL categoryDAL)
        {
            _categoryDAL = categoryDAL;
        }

        public bool AnyCategory(string categoryName)
        {
            bool validCategory = _categoryDAL.GetAll(x => x.isActive).Any(x => x.CategoryName.Equals(categoryName));

            return validCategory;
        }

        public ResultService<Category> CreateCategory(CategoryCreateVM vm)
        {
            ResultService<Category> result = new ResultService<Category>();

            bool checkCategory = AnyCategory(vm.CategoryName);

            if (!checkCategory)
            {
                Category newCategory = new Category
                {
                    CategoryName = vm.CategoryName
                };

                Category addCategory = _categoryDAL.Add(newCategory);

                result.Data = addCategory ?? newCategory;

                if (addCategory == null)
                {
                    result.AddError("Hata oluştu", "Ekleme işlemi başarısız");
                }
            }
            else
            {
                result.Data = new Category
                {
                    CategoryName = vm.CategoryName
                };

                result.AddError("Kayıt mevcut", "Ekleme başarısız");
            }

            return result;
        }

        public ResultService<CategoryBaseVM> DeleteCategory(int id)
        {
            ResultService<CategoryBaseVM> result = new ResultService<CategoryBaseVM>();

            try
            {
                Category category = _categoryDAL.Get(x => x.Id.Equals(id) && x.isActive);
                category.isActive = false;
                _categoryDAL.Delete(category);

                result.Data = new CategoryBaseVM
                {
                    Id = category.Id,
                    Name = category.CategoryName
                };
            }
            catch (Exception)
            {
                result.AddError("Silme işlemi başarısız", "Kayıt bulunamadı");
            }

            return result;
        }

        public ResultService<Category> GetAllCategoryName()
        {
            throw new NotImplementedException();
        }

        public ResultService<CategoryUpdateVM> GetCategory(int id)
        {
            throw new NotImplementedException();
        }

        public ResultService<Category> GetCategoryByName(string categoryName)
        {
            throw new NotImplementedException();
        }

        public ResultService<CategoryBaseVM> GetCategoryId(string categoryName)
        {
            ResultService<CategoryBaseVM> result = new ResultService<CategoryBaseVM>();

            Category category = _categoryDAL.Get(x => x.isActive && x.CategoryName == categoryName);

            if (category != null)
            {
                result.Data = new CategoryBaseVM
                {
                    Id = category.Id,
                    Name = category.CategoryName
                };
            }
            else
            {
                result.Data = new CategoryBaseVM
                {
                    Id = -1,
                    Name = categoryName
                };

                result.AddError("Kayıt bulunamadı", "Bu isimde bir kategori yok");
            }

            return result;
        }

        public ResultService<CategoryUpdateVM> UpdateCategory(CategoryUpdateVM vm)
        {
            ResultService<CategoryUpdateVM> result = new ResultService<CategoryUpdateVM>();

            Category category = _categoryDAL.Get(x => x.isActive && x.Id == vm.Id);

            if (!AnyCategory(vm.Name))
            {
                category.CategoryName = vm.Name;
                category.UpdateOn = vm.UpdateDate;

                Category updateCategory = _categoryDAL.Update(category);

                if (updateCategory != null)
                {
                    result.Data = new CategoryUpdateVM
                    {
                        Id = updateCategory.Id,
                        Name = updateCategory.CategoryName
                    };
                }
                else
                {
                    result.AddError("Hata", "Güncelleme başarısız");
                }
            }
            else
            {
                result.Data = vm;
                result.AddError("Güncelleme başarısız", "Kayıt bulunamadı");
            }

            return result;
        }
    }
}
