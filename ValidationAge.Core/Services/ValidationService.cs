using ValidationAge.Core.Interfaces;

namespace ValidationAge.Core.Services
{
    public class ValidationService : IValidationService
    {
        public bool IsAdult(int Age)
        {
            return Age >= 18;
        }
    }
}
