using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DateValidator.Models;

namespace DateValidator.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Submit(DateModel model)
    {
        if (ModelState.IsValid)
        {
            // El modelo es válido, puedes hacer lo que desees con la fecha.
            // En este ejemplo, simplemente mostramos la fecha en la vista.
            return View("Result", model);
        }

        // Si el modelo no es válido, vuelve a mostrar el formulario con los errores.
        return View("Index", model);
    }
}


