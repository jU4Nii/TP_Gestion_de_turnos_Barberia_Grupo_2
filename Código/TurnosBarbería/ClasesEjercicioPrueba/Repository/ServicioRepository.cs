using System.Collections.Generic;
using System.Linq;
using ClasesEjercicioPrueba.Data1;
using ClasesEjercicioPrueba.Models;

namespace ClasesEjercicioPrueba.Repository
{
    public static class ServicioRepository
    {
        public static void Agregar(Servicio servicio)
        {
            using var context = new ApplicationDbContext();
            context.listaServicios.Add(servicio);
            context.SaveChanges();
        }

        public static List<Servicio> ObtenerTodos()
        {
            using var context = new ApplicationDbContext();
            return context.listaServicios.ToList();
        }

        public static Servicio ObtenerPorId(int id)
        {
            using var context = new ApplicationDbContext();
            return context.listaServicios.Find(id);
        }

        public static void Actualizar(Servicio servicio)
        {
            using var context = new ApplicationDbContext();
            context.listaServicios.Update(servicio);
            context.SaveChanges();
        }

        public static void Eliminar(int id)
        {
            using var context = new ApplicationDbContext();
            var servicio = context.listaServicios.Find(id);
            if (servicio != null)
            {
                context.listaServicios.Remove(servicio);
                context.SaveChanges();
            }
        }
    }
}