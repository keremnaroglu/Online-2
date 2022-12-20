using Online2.DAL.Abstract;
using Online2.DAL.Base.EntityFrameWork;
using Online2.DAL.Concrete.Context;
using Online2.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online2.DAL.Concrete.Repositories
{
    public class CategoryRepository : EFRepositoryBase<Category, DiyetDbContext>, ICategoryDAL
    {
        public CategoryRepository(DiyetDbContext db) : base(db)
        {

        }
    }
}
