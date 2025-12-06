using MediatR;
namespace OnionCompany.Application.CqrsAndMediatr.Mediator.Commands
{
    public class RemoveProjectCommand : IRequest
    {
        public int Id { get; set; }
    }
}