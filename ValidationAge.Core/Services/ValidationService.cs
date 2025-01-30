using ValidationAge.Core.Interfaces;
using ValidationAge.Core.Models;

namespace ValidationAge.Core.Services
{
    public class ValidationService : IValidationService
    {
        public async Task<UserAgeValidation> IsAdult(int age)
        {
            var validation = age >= 18;
            return await Task.FromResult(new UserAgeValidation(age, validation));
        }
    }
}
