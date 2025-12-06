using MediatR;

namespace OnionCompany.Application.CqrsAndMediatr.Mediator.Commands
{
    public class CreateDepartmentCommand : IRequest
    {
        public string Name { get; set; }
        public string Location { get; set; }
    }
}



