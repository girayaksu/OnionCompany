using MediatR;

namespace OnionCompany.Application.CqrsAndMediatr.Mediator.Commands
{
    public class RemoveDepartmentCommand : IRequest
    {
        public int Id { get; set; }
    }
}



