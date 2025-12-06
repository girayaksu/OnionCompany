using MediatR;
using Microsoft.AspNetCore.Mvc;
using OnionCompany.Application.CqrsAndMediatr.Mediator.Commands;
using OnionCompany.Application.CqrsAndMediatr.Mediator.Queries;

namespace OnionCompany.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IMediator _mediator;

        public EmployeeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _mediator.Send(new GetEmployeeQuery());
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _mediator.Send(new GetEmployeeByIdQuery { Id = id });
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateEmployeeCommand command)
        {
            await _mediator.Send(command);
            return Ok(new { Message = "Employee başarıyla oluşturuldu" });
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateEmployeeCommand command)
        {
            await _mediator.Send(command);
            return Ok(new { Message = "Employee başarıyla güncellendi" });
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _mediator.Send(new RemoveEmployeeCommand { Id = id });
            return Ok(new { Message = "Employee başarıyla silindi" });
        }
    }
}



