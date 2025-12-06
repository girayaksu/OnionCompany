using MediatR;
namespace OnionCompany.Application.CqrsAndMediatr.Mediator.Commands
{
    public class UpdateTaskCommand : IRequest
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsCompleted { get; set; }
        public int ProjectId { get; set; }
        public int? AssignedToEmployeeId { get; set; }
    }
}