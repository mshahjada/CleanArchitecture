using CleanArchitecture.Application.Features.Departments.Command.CreateDepartment;
using CleanArchitecture.Application.Features.Departments.Command.UpdateDepartment;
using CleanArchitecture.Application.Features.Departments.Queries.GetDepartmentList;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CleanArchitecture.Api.Controllers
{
    [Route("api/department")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        protected readonly IMediator _mediator;
        public DepartmentController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("all", Name = "GetAllDepartments")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<DepartmentListVm>>> GetAllDepartments()
        {
            var result = await _mediator.Send(new GetDepartmentListQuery());
            return Ok(result);
        }


        [HttpPost("add", Name = "AddDepartment")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<CreateDepartmentResponse>> AddDepartment([FromBody] CreateDepartmentCommand createDepartmentCommand)
        {

            var result = await _mediator.Send(createDepartmentCommand);
            return Ok(result);
        }

        [HttpPut("edit", Name = "editDepartment")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> Edit([FromBody] UpdateDepartmentCommand createDepartmentCommand)
        {

            await _mediator.Send(createDepartmentCommand);
            return NoContent();
        }
    }
}
