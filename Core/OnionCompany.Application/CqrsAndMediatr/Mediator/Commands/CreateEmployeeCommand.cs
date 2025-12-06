using MediatR;
namespace OnionCompany.Application.CqrsAndMediatr.Mediator.Commands
{
    public class CreateEmployeeCommand : IRequest
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int DepartmentId { get; set; }
    }
}