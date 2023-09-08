using CleanArchitecture.Application.Contracts.Infrastructure;
using CleanArchitecture.Application.Features.Departments.Queries.GetDepartmentList;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.Api.Controllers
{
    [Route("api/client")]
    [ApiController]
    public class ApiClientController : ControllerBase
    {
        private readonly IProductClient _productClient;
        private readonly IUserClient _userClient;
        public ApiClientController(IProductClient productClient, IUserClient userClient)
        {
            _productClient = productClient;
            _userClient = userClient;
        }

        [HttpGet("get-product", Name = "GetProduct")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<object>> GetProductAsync(int productId)
        {
            var result = await _productClient.GetProductByIdAsync(productId);
            return Ok(result);
        }

        [HttpGet("get-user", Name = "GetUser")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<object>> GetUserAsync(int userId)
        {
            var result = await _userClient.GetUserByIdAsync(userId);
            return Ok(result);
        }
    }
}
