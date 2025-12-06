using MediatR;
using OnionCompany.Application.CqrsAndMediatr.Mediator.Results;

namespace OnionCompany.Application.CqrsAndMediatr.Mediator.Queries
{
    public class GetDepartmentByIdQuery : IRequest<GetDepartmentByIdQueryResult>
    {
        public int Id { get; set; }
    }
}



