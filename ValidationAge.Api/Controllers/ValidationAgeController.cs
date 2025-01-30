using Microsoft.AspNetCore.Mvc;
using ValidationAge.Core.Interfaces;

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
        public async Task<IActionResult> IsAdult([FromBody] int age)
        {
            var validationAge = await ValidationService.IsAdult(age);
            return Ok(validationAge);
        }
    }
}
