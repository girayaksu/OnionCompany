using MediatR;
using Microsoft.AspNetCore.Mvc;
using OnionCompany.Application.CqrsAndMediatr.Mediator.Commands;
using OnionCompany.Application.CqrsAndMediatr.Mediator.Queries;

namespace OnionCompany.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IMediator _mediator;

        public DepartmentController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _mediator.Send(new GetDepartmentQuery());
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _mediator.Send(new GetDepartmentByIdQuery { Id = id });
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateDepartmentCommand command)
        {
            await _mediator.Send(command);
            return Ok(new { Message = "Department başarıyla oluşturuldu" });
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateDepartmentCommand command)
        {
            await _mediator.Send(command);
            return Ok(new { Message = "Department başarıyla güncellendi" });
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _mediator.Send(new RemoveDepartmentCommand { Id = id });
            return Ok(new { Message = "Department başarıyla silindi" });
        }
    }
}



