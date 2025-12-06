using OnionCompany.Domain.Interfaces;

namespace OnionCompany.Domain.Entities
{
    public class Employee : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int DepartmentId { get; set; }

        public virtual Department? Department { get; set; }
        public virtual ICollection<Task> Tasks { get; set; } = new List<Task>();
    }
}


