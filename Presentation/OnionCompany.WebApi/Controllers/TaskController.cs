using MediatR;
using Microsoft.AspNetCore.Mvc;
using OnionCompany.Application.CqrsAndMediatr.Mediator.Commands;
using OnionCompany.Application.CqrsAndMediatr.Mediator.Queries;

namespace OnionCompany.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        private readonly IMediator _mediator;
        public TaskController(IMediator mediator) { _mediator = mediator; }

        [HttpGet]
        public async System.Threading.Tasks.Task<IActionResult> GetAll()
        {
            var result = await _mediator.Send(new GetTaskQuery());
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async System.Threading.Tasks.Task<IActionResult> GetById(int id)
        {
            var result = await _mediator.Send(new GetTaskByIdQuery { Id = id });
            return Ok(result);
        }

        [HttpPost]
        public async System.Threading.Tasks.Task<IActionResult> Create(CreateTaskCommand command)
        {
            await _mediator.Send(command);
            return Ok(new { Message = "Task başarıyla oluşturuldu" });
        }

        [HttpPut]
        public async System.Threading.Tasks.Task<IActionResult> Update(UpdateTaskCommand command)
        {
            await _mediator.Send(command);
            return Ok(new { Message = "Task başarıyla güncellendi" });
        }

        [HttpDelete("{id}")]
        public async System.Threading.Tasks.Task<IActionResult> Delete(int id)
        {
            await _mediator.Send(new RemoveTaskCommand { Id = id });
            return Ok(new { Message = "Task başarıyla silindi" });
        }
    }
}




