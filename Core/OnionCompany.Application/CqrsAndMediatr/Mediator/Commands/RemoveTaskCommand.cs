using MediatR;
namespace OnionCompany.Application.CqrsAndMediatr.Mediator.Commands
{
    public class RemoveTaskCommand : IRequest
    {
        public int Id { get; set; }
    }
}