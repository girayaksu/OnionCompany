using MediatR;
using Microsoft.AspNetCore.Mvc;
using OnionCompany.Application.CqrsAndMediatr.Mediator.Commands;
using OnionCompany.Application.CqrsAndMediatr.Mediator.Queries;

namespace OnionCompany.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ProjectController(IMediator mediator) { _mediator = mediator; }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _mediator.Send(new GetProjectQuery());
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _mediator.Send(new GetProjectByIdQuery { Id = id });
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateProjectCommand command)
        {
            await _mediator.Send(command);
            return Ok(new { Message = "Project başarıyla oluşturuldu" });
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateProjectCommand command)
        {
            await _mediator.Send(command);
            return Ok(new { Message = "Project başarıyla güncellendi" });
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _mediator.Send(new RemoveProjectCommand { Id = id });
            return Ok(new { Message = "Project başarıyla silindi" });
        }
    }
}




