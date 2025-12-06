using MediatR;
using OnionCompany.Application.CqrsAndMediatr.Mediator.Results;
namespace OnionCompany.Application.CqrsAndMediatr.Mediator.Queries
{
    public class GetEmployeeQuery : IRequest<List<GetEmployeeQueryResult>>
    {
    }
}