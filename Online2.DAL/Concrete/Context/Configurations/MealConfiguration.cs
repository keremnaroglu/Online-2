using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Online2.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online2.DAL.Concrete.Context.Configurations
{
    public class MealConfiguration : BaseConfiguration<Meal>
    {
        public override void Configure(EntityTypeBuilder<Meal> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.MealName).IsRequired().HasMaxLength(50);

            builder.HasIndex(x => x.MealName).IsUnique();

            builder.HasMany(x => x.MealFoods).WithOne(x => x.Meal).HasForeignKey(x => x.MealId).OnDelete(DeleteBehavior.NoAction);

            builder.HasData(
                new Meal { Id = 1, MealName = "Kahvaltı", CreateOn = DateTime.Now, isActive = true },
                new Meal { Id = 2, MealName = "Öğle Yemeği", CreateOn = DateTime.Now, isActive = true },
                new Meal { Id = 3, MealName = "Akşam Yemeği", CreateOn = DateTime.Now, isActive = true }
                );
        }
    }
}
