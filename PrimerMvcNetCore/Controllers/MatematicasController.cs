using Microsoft.AspNetCore.Mvc;
using PrimerMvcNetCore.Models;

namespace PrimerMvcNetCore.Controllers
{
    public class MatematicasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ConjeturaCollatz()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ConjeturaCollatz(int numero)
        {
            //DEBEMOS DEVOLVER UN OBJETO COMPLEJO 
            //CON UNA LISTA DE NUMEROS
            List<int> numeros = new List<int>();
            while (numero != 1)
            {
                if(numero % 2 == 0)
                {
                    numero = numero / 2;
                }
                else
                {
                    numero = (numero * 3) + 1;
                }
                numeros.Add(numero);
            }

            //DEVOLVEMOS EL MODEL A LA VISTA
            return View(numeros);
        }

        public IActionResult SumarNumerosGet
        (int numero1, int numero2)
        {
            int suma = numero1 + numero2;
            ViewData["SUMA"] = "La suma de "
                + numero1 + " + " + numero2
                + " = " + suma;
            return View();
        }


        public IActionResult SumarNumerosPost()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SumarNumerosPost
           (int num1, int num2)
        {
            int resultado = num1 + num2;
            ViewData["SUMA"] = num1
                + " + " + num2
                + " = " + resultado;
            return View();
        }
    }
}
