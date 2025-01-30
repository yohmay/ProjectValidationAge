using ValidationAge.Core.Models;

namespace ValidationAge.Core.Interfaces
{
    public interface IValidationService
    {
        Task<UserAgeValidation> IsAdult(int Age);
    }
}
