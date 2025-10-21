using ClasesEjercicioPrueba.Models;
using ClasesEjercicioPrueba.Repository;

namespace WinformABM
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (!ServicioRepository.ObtenerTodos().Any())
            {
                ServicioRepository.Agregar(new Servicio { Nombre = "Corte", Precio = 100 });
                ServicioRepository.Agregar(new Servicio { Nombre = "Barba", Precio = 50 });
                ServicioRepository.Agregar(new Servicio { Nombre = "Tintura", Precio = 200 });
            }

            if (!PeluqueroRepository.ObtenerTodos().Any())
            {
                PeluqueroRepository.Agregar(new Peluquero { Nombre = "Juan Ignacio Bonora", Telefono = "3493549439" });
                PeluqueroRepository.Agregar(new Peluquero { Nombre = "Mariano Aressi", Telefono = "3493549439" });
            }

            Application.Run(new FormListaTurnos());
        }
    }
}