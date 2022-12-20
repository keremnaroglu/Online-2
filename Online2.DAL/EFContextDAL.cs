using Microsoft.Extensions.DependencyInjection;
using Online2.DAL.Abstract;
using Online2.DAL.Concrete.Context;
using Online2.DAL.Concrete.Repositories;

namespace Online2.DAL
{
    public static class EFContextDAL
    {
        public static void AddScopedDal(this IServiceCollection services)
        {
            services.AddDbContext<DiyetDbContext>()
                .AddScoped<ICategoryDAL, CategoryRepository>()
                .AddScoped<IFoodDAL, FoodRepository>()
                .AddScoped<IMealDAL, MealRepository>()
                .AddScoped<IUserDAL, UserRepository>()
                .AddScoped<IMealFoodDAL, MealFoodRepository>();
                            
        }
    }
}
//Dependency Injection