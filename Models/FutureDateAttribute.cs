using System;
using System.ComponentModel.DataAnnotations;

public class FutureDateAttribute : ValidationAttribute
{
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        if (value is DateTime date)
        {
            if (date > DateTime.Now)
            {
                return new ValidationResult(ErrorMessage ?? "La fecha no puede ser futura.");
            }
        }

        return ValidationResult.Success;
    }
}

