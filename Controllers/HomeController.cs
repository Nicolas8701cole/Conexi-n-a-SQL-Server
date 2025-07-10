using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP03.Models;

namespace TP03.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
    public IActionResult AdministrarMovimientosEntrePestañas(int eleccion)
    {
        if (eleccion == 1)
        {
            BD.LevantarClientes();
            return View("LevantarClientes");
        }
        else if (eleccion == 2)
        {
            BD.EliminarClientes();
            return View("EliminarClientes");
        }
        else if (eleccion == 3)
        {
            return View("Index");
        }
        else if (eleccion == 4)
        {
            return View("AgregarComidas");
        }
        else if (eleccion == 5)
        {
            BD.LevantarMesas();
            return View("LevantarMesas");
        }
        else
        {
            return View();
        }
    }
    public IActionResult AgregarComida(string Nombre, int IdTipoComida, double Precio, bool SinGluten)
    {
        Comidas coco = new Comidas(Nombre, IdTipoComida, Precio, SinGluten);
        BD.AgregarComidas(coco);
        return RedirectToAction("Index");
    }
}
