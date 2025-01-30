namespace ValidationAge.Core.Models
{
    public class UserAgeValidation
    {
        public int Age { get; }
        public bool IsAdult { get; }

        public UserAgeValidation(int age, bool isAdult)
        {
            Age = age;
            IsAdult = isAdult;
        }
    }
}
