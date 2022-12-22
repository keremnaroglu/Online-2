using Online2.Entity;
using Online2.Syst;
using Online2.ViewModels.CategoryViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online2.BLL.Abstract
{
    public interface ICategoryBLL : IBaseBLL<Category>
    {
        ResultService<CategoryBaseVM> GetCategoryId(string categoryName);

        ResultService<Category> GetAllCategoryName();

        ResultService<Category> GetCategoryByName(string categoryName);

        ResultService<CategoryBaseVM> DeleteCategory(int id);

        ResultService<CategoryUpdateVM> UpdateCategory(CategoryUpdateVM vm);

        ResultService<Category> CreateCategory(CategoryCreateVM vm);

        ResultService<CategoryUpdateVM> GetCategory(int id);

        bool AnyCategory(string categoryName);
    }
}
