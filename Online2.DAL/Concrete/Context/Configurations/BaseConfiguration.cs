using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Online2.Core;

namespace Online2.DAL.Concrete.Context.Configurations
{
    public abstract class BaseConfiguration<T> : IEntityTypeConfiguration<T> where T : BaseEntity
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.CreateOn).HasColumnType("datetime").IsRequired();

            builder.Property(x => x.UpdateOn).HasColumnType("datetime").IsRequired(false);

            builder.Property(x => x.isActive).HasColumnType("bit");

            builder.HasKey(x => x.Id);
        }
    }
}
