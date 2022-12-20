
namespace Online2.Core
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }

        public DateTime CreateOn { get; set; }

        public DateTime? UpdateOn { get; set; }

        public bool isActive { get; set; }
    }
}
