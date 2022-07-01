using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TP9.Models;

namespace TP9.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.ListadoPizza = Pizzeria.ListarPizzas();
            return View();
        }

        public IActionResult AgregarPizza()
        {
            ViewBag.ListadoIngredientes = Pizzeria.ListarIngredientes();
            return View();
        }

        [HttpPost]
        public IActionResult GuardarPizza(string Nombre, int Precio, string Tamaño, string UrlFoto, List<int> Ingredientes){
                Pizza MiPizza = new Pizza(Nombre,Precio,Tamaño,UrlFoto);
                List<ingredientes> ListaIngredientes = Pizzeria.DevolverIngredientes(Ingredientes);
                MiPizza.AgregarIngredientes(ListaIngredientes);
                Pizzeria.AgregarPizza(MiPizza);
                ViewBag.ListadoPizza = Pizzeria.ListarPizzas();
                return View("index");
        }

        public IActionResult EliminarPizza(int IdPizza){
            bool Pude = false;
            Pizza PizzaElegida=new Pizza();
            List<Pizza> ListaPizzas = Pizzeria.ListarPizzas();
            foreach(Pizza UnaPizza in ListaPizzas){
                if (UnaPizza.IdPizza == IdPizza){
                    PizzaElegida = UnaPizza;
                }
            }
            Pizzeria.EliminarPizza(PizzaElegida);
            ViewBag.ListadoPizza = Pizzeria.ListarPizzas();
            return View("Index");
        }

        public IActionResult detallePizza(int IdPizza){
            List<Pizza> ListaPizzas = Pizzeria.ListarPizzas();
            foreach(Pizza UnaPizza in ListaPizzas){
                if (UnaPizza.IdPizza == IdPizza){
                    ViewBag.PizzaElegida=UnaPizza;
                }
            }
            return View("VerPizza");
        }
    }
}