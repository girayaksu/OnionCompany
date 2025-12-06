using OnionCompany.Domain.Interfaces;

namespace OnionCompany.Domain.Entities
{
    public class Task : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsCompleted { get; set; }
        public int ProjectId { get; set; }
        public int? AssignedToEmployeeId { get; set; }

        public virtual Project? Project { get; set; }
        public virtual Employee? AssignedToEmployee { get; set; }
    }
}


