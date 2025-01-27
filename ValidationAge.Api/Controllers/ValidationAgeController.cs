using Microsoft.AspNetCore.Mvc;
using ValidationAge.Core.Interfaces;
using ValidationAge.Core.Models;

namespace ValidationAge.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ValidationAgeController : ControllerBase
    {
        protected IValidationService ValidationService;

        public ValidationAgeController(IValidationService validationService)
        {
            ValidationService = validationService;
        }

        [HttpPost("ValidateAge")]
        public async Task<IActionResult> IsAdult([FromBody] Age age)
        {
            if (age.UserAge >= 18)
            {
                return Ok("Entrada Liberada");
            }
            else
            {
                return Ok("Entrada Proibida");
            }
        }
    }
}
