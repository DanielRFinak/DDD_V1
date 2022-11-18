using Finaktiva.DDD_1.API.AplicationServices;
using Finaktiva.DDD_1.API.Commands;
using Finaktiva.DDD_1.Domain.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Finaktiva.DDD_1.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly FinaktivaServices finaktivaServices;

        public PersonController(FinaktivaServices finaktivaServices)
        {
            this.finaktivaServices = finaktivaServices;
        }

        [HttpPost]
        public async Task<IActionResult> AddPerson(CreatePersonCommand createPersonCommand)
        {
            await finaktivaServices.HandleCommand(createPersonCommand);
            return Ok(createPersonCommand);
        }

        [HttpGet]
        public async Task<IActionResult> GetPerson(Guid id)
        {
            var response = await finaktivaServices.GetPerson(id);
            return Ok(response);
        }
    }
}
