using MediatR;

namespace OnionCompany.Application.CqrsAndMediatr.Mediator.Commands
{
    public class UpdateDepartmentCommand : IRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
    }
}



