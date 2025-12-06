using MediatR;
using OnionCompany.Application.CqrsAndMediatr.Mediator.Results;
namespace OnionCompany.Application.CqrsAndMediatr.Mediator.Queries
{
    public class GetTaskByIdQuery : IRequest<GetTaskByIdQueryResult>
    {
        public int Id { get; set; }
    }
}