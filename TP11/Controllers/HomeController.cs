using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TP11.Models;

namespace TP11.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.ListaCurso=BD.ListarCursos(-1);
            return View();
        }

        public IActionResult MostrarCursosxEspecialidad(int IdEspecialidad)
        {
            ViewBag.ListaCurso=BD.ListarCursos(IdEspecialidad);
            return View("Index");
        }

        public IActionResult VerCurso(int IdCurso){
            ViewBag.Curso=BD.ConsultaCurso(IdCurso);
            return View("DetalleCurso");
        }

        public IActionResult Calificar(int IdCurso, bool Gusta){
            BD.CalificarCurso(IdCurso, Gusta);
            ViewBag.Curso=BD.ConsultaCurso(IdCurso);
            return View("DetalleCurso");
        }

        public IActionResult AgregarCurso(){
            
            ViewBag.Especialidades=BD.ListarEspecialidades();
            return View();
        }

        [HttpPost]
        public IActionResult GuardarCurso(string Nombre, int IdEspecialidad, string Descripcion, string Imagen, string UrlCurso){
            Curso MiCurso = new Curso(0, Nombre,IdEspecialidad,Descripcion,Imagen,UrlCurso,0,0);
            BD.AgregarCurso(MiCurso);
            ViewBag.ListaCurso=BD.ListarCursos(-1);
            return View("Index");
        }

    }
}
