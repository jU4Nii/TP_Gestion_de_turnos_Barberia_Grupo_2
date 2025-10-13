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
            context.Servicios.Add(servicio);
            context.SaveChanges();
        }

        public static List<Servicio> ObtenerTodos()
        {
            using var context = new ApplicationDbContext();
            return context.Servicios.ToList();
        }

        public static Servicio ObtenerPorId(int id)
        {
            using var context = new ApplicationDbContext();
            return context.Servicios.Find(id);
        }

        public static void Actualizar(Servicio servicio)
        {
            using var context = new ApplicationDbContext();
            context.Servicios.Update(servicio);
            context.SaveChanges();
        }

        public static void Eliminar(int id)
        {
            using var context = new ApplicationDbContext();
            var servicio = context.Servicios.Find(id);
            if (servicio != null)
            {
                context.Servicios.Remove(servicio);
                context.SaveChanges();
            }
        }
    }
}