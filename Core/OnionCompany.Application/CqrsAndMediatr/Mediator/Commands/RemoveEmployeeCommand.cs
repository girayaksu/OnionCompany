using MediatR;
namespace OnionCompany.Application.CqrsAndMediatr.Mediator.Commands
{
    public class RemoveEmployeeCommand : IRequest
    {
        public int Id { get; set; }
    }
}