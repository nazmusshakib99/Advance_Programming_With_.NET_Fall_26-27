using System.ComponentModel.DataAnnotations;

namespace LabTaskThree.Validations
{
    public class MaximumAgeAttribute : ValidationAttribute
    {
        private readonly int _maximumAge;

        public MaximumAgeAttribute(int maximumAge)
        {
            _maximumAge = maximumAge;
            ErrorMessage = $"Student must not be older than {maximumAge} years";
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value is DateTime dateOfBirth)
            {
               
                if (dateOfBirth >= DateTime.Today)
                    return new ValidationResult("Date of birth must be in the past");

                int age = DateTime.Today.Year - dateOfBirth.Year;
                if (dateOfBirth > DateTime.Today.AddYears(-age)) age--;

                if (age > _maximumAge)
                    return new ValidationResult(ErrorMessage);
            }
            return ValidationResult.Success;
        }
    }
}