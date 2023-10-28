using System;
using System.ComponentModel.DataAnnotations;
namespace DateValidator.Models;
public class DateModel
{
    [FutureDate(ErrorMessage = "La fecha no puede ser futura.")]
    [Display(Name = "Fecha")]
    public DateTime Date { get; set; }
}
