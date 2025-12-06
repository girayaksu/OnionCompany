using MediatR;
using OnionCompany.Application.CqrsAndMediatr.Mediator.Results;
namespace OnionCompany.Application.CqrsAndMediatr.Mediator.Queries
{
    public class GetEmployeeByIdQuery : IRequest<GetEmployeeByIdQueryResult>
    {
        public int Id { get; set; }
    }
}