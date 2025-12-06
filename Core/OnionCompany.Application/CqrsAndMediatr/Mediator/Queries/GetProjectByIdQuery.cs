using MediatR;
using OnionCompany.Application.CqrsAndMediatr.Mediator.Results;
namespace OnionCompany.Application.CqrsAndMediatr.Mediator.Queries
{
    public class GetProjectByIdQuery : IRequest<GetProjectByIdQueryResult>
    {
        public int Id { get; set; }
    }
}