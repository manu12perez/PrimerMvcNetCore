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

        public IActionResult TablaMultiplicar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult TablaMultiplicar(int numero)
        {
            List<int> tabla = new List<int>();

            for (int i = 1; i <= 10; i++)
            {
                tabla.Add(numero * i);
            }

            return View(tabla);
        }

        public IActionResult TablaMultiplicarModel()
        {
            return View();
        }

        [HttpPost]
        public IActionResult TablaMultiplicarModel(int numero)
        {
            List<FilaTablaMultiplicar> filas = new List<FilaTablaMultiplicar>();
            for(int i = 1; i <= 10; i++)
            {
                FilaTablaMultiplicar fila = new FilaTablaMultiplicar();
                fila.Operacion = numero + " * " + i;
                fila.Resultado = numero * i;
                filas.Add(fila);
            }
            return View(filas);
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
