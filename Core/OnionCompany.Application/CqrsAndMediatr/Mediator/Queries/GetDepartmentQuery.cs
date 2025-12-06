using MediatR;
using OnionCompany.Application.CqrsAndMediatr.Mediator.Results;

namespace OnionCompany.Application.CqrsAndMediatr.Mediator.Queries
{
    public class GetDepartmentQuery : IRequest<List<GetDepartmentQueryResult>>
    {
    }
}



