using MediatR;
using OnionCompany.Application.CqrsAndMediatr.Mediator.Commands;
using OnionCompany.Contract.RepositoryInterfaces;
using System.Threading;


namespace OnionCompany.Application.CqrsAndMediatr.Mediator.Handlers.Modify
{
    public class UpdateDepartmentCommandHandler : IRequestHandler<UpdateDepartmentCommand>
    {
        private readonly IDepartmentRepository _repository;

        public UpdateDepartmentCommandHandler(IDepartmentRepository repository)
        {
            _repository = repository;
        }

        public async System.Threading.Tasks.Task Handle(UpdateDepartmentCommand request, CancellationToken cancellationToken)
        {
            var department = await _repository.GetByIdAsync(request.Id);
            department.Name = request.Name;
            department.Location = request.Location;
            department.UpdatedDate = DateTime.Now;
            department.Status = Domain.Enums.DataStatus.Updated;
            await _repository.SaveChangesAsync();
        }
    }
}



