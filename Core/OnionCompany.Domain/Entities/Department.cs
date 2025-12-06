using OnionCompany.Domain.Interfaces;

namespace OnionCompany.Domain.Entities
{
    public class Department : BaseEntity
    {
        public string Name { get; set; }
        public string Location { get; set; }

        public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
    }
}


