using OnionCompany.Domain.Interfaces;

namespace OnionCompany.Domain.Entities
{
    public class Project : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public virtual ICollection<Task> Tasks { get; set; } = new List<Task>();
    }
}


