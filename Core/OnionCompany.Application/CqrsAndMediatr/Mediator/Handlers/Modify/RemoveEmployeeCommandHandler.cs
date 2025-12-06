using MediatR;
using OnionCompany.Application.CqrsAndMediatr.Mediator.Commands;
using OnionCompany.Contract.RepositoryInterfaces;
using System.Threading;

namespace OnionCompany.Application.CqrsAndMediatr.Mediator.Handlers.Modify
{
    public class RemoveEmployeeCommandHandler : IRequestHandler<RemoveEmployeeCommand>
    {
        private readonly IEmployeeRepository _repository;
        public RemoveEmployeeCommandHandler(IEmployeeRepository repository)
        {
            _repository = repository;
        }
        public async System.Threading.Tasks.Task Handle(RemoveEmployeeCommand request, CancellationToken cancellationToken)
        {
            var employee = await _repository.GetByIdAsync(request.Id);
            await _repository.DeleteAsync(employee);
        }
    }
}