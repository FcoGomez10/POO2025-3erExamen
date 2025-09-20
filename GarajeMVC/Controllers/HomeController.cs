using System.Diagnostics;
using GarajeMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace GarajeMVC.Controllers
{
    public class HomeController : Controller
    {
        // Declaración e instanciación del objeto miGaraje
        public GarajeMVC.Models.Garaje miGaraje = new GarajeMVC.Models.Garaje();

        public IActionResult Index()
        {
            // Ejemplo: agregar un auto
            miGaraje.ingresarAuto(new Auto(1, "Toyota", "HYU 456"));
            miGaraje.ingresarAuto(new Auto(2, "Nissan", "ZXC 789"));
            miGaraje.ingresarAuto(new Auto(3, "Toyota", "TGB 951"));

            // Pasar la lista de autos a la vista
            var autos = miGaraje.getAutos();

            return View(miGaraje);
        }

    }
}
