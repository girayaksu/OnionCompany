using MediatR;
using OnionCompany.Application.CqrsAndMediatr.Mediator.Commands;
using OnionCompany.Contract.RepositoryInterfaces;
using System.Threading;


namespace OnionCompany.Application.CqrsAndMediatr.Mediator.Handlers.Modify
{
    public class RemoveDepartmentCommandHandler : IRequestHandler<RemoveDepartmentCommand>
    {
        private readonly IDepartmentRepository _repository;

        public RemoveDepartmentCommandHandler(IDepartmentRepository repository)
        {
            _repository = repository;
        }

        public async System.Threading.Tasks.Task Handle(RemoveDepartmentCommand request, CancellationToken cancellationToken)
        {
            var department = await _repository.GetByIdAsync(request.Id);
            await _repository.DeleteAsync(department);
        }
    }
}



