using Microsoft.AspNetCore.Mvc;
using PrimerMvcNetCore.Models;

namespace PrimerMvcNetCore.Controllers
{
    public class InformacionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult VistaControllerPost()
        {
            return View();
        }

        [HttpPost]
        public IActionResult VistaControllerPost
            (Persona persona, string aficiones)
        {
            ViewData["DATA"] = "Nombre: " + persona.Nombre
                + ", Email: " + persona.Email
                + ", Edad: " + persona.Edad
                + ", Aficiones: " + aficiones;
            return View();
        }

        //VAMOS A RECIBIR DOS PARAMETROS
        public IActionResult VistaControllerGet
            (string saludo, int year)
        {
            if (saludo != null)
            {
                ViewData["DATA"] = "Hola " + saludo
                    + " en el año " + year;
            }
            else
            {
                ViewData["DATA"] = "Aquí nadie saluda ya...";
            }
            return View();
        }

        public IActionResult ControladorVista()
        {
            //VAMOS A ENVIAR INFORMACION SIMPLE A NUESTRA VISTA
            ViewData["NOMBRE"] = "Alumno";
            ViewData["EDAD"] = 24;
            ViewBag.DiaSemana = "Lunes";
            return View();
        }

        public IActionResult ControladorVistaModel()
        {
            Persona persona = new Persona();
            persona.Nombre = "Alumno";
            persona.Email = "alumno@email.com";
            persona.Edad = 27;
            return View();
        }
    }
}
