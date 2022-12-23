using Microsoft.Extensions.DependencyInjection;
using Online2.BLL.Abstract;
using Online2.BLL.Concrete;
using Online2.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online2.BLL
{
    public static class EFContextBLL
    {
        public static void AddScopeBLL(this IServiceCollection services)
        {
            services.AddScopedDal();
            services.AddScoped<IUserBLL, UserService>();
            services.AddScoped<IMealBLL, MealService>();
        }
    }
}
//Dependency Injection