using Microsoft.AspNetCore.Mvc;
using TestArchitecture.API.Contracts;

namespace TestArchitecture.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public partial class MembersController : ControllerBase
    {
        

        [HttpGet]
        [ProducesResponseType(typeof(Member[]), 200)] // При каком статусе мы выдаём эту информацию
        public async Task<IActionResult> Get() // IActionResult - позволяет методы для возврата статуса
        {
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> Create(NewMember newMember)
        {
            return Ok();
        }
    }
}
