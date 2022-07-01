using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TPVOTO.Models;

namespace TPVOTO.Controllers
{
    public class HomeController : Controller
    {
    
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ConsultaPadron(int DNI){
            
            ViewBag.Persona=BD.ConsultaPadron(DNI);
            if(ViewBag.Persona==null){
                ViewBag.Error="DNI EQUIVOCADO";
                return View("index");
            }else{
                ViewBag.MiEstablecimiento=BD.ConsultaEstablecimiento(ViewBag.Persona.IdEstablecimiento);
                return View("Votar");
            }
        }
        
        [HttpPost] 
            public IActionResult Votar(int DNI, int NumeroTramite){
            ViewBag.Persona=BD.ConsultaPadron(DNI);
            if(NumeroTramite==ViewBag.Persona.NumeroTramite){
                if(ViewBag.Persona.Voto==true){
                    ViewBag.MiEstablecimiento=BD.ConsultaEstablecimiento(ViewBag.Persona.IdEstablecimiento);
                    ViewBag.Persona=BD.ConsultaPadron(DNI);
                    ViewBag.YaVoto="No puede votar de vuelta";
                    return View();
                }else{
                    ViewBag.Persona.Voto=BD.Votar(DNI,NumeroTramite);
                    ViewBag.Correcto="Se ha realizado el voto correctamente";
                    return View("Index");
                }
            }else{
                ViewBag.MiEstablecimiento=BD.ConsultaEstablecimiento(ViewBag.Persona.IdEstablecimiento);
                ViewBag.Persona=BD.ConsultaPadron(DNI);                
                ViewBag.Nocoincide="El número de trámite no coincide.";
                return View();
            }
        }
    }
}
