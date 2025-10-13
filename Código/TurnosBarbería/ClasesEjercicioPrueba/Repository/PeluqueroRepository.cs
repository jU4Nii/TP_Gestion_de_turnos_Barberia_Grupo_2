using System.Collections.Generic;
using System.Linq;
using ClasesEjercicioPrueba.Data1;
using ClasesEjercicioPrueba.Models;

namespace ClasesEjercicioPrueba.Repository
{
    public static class PeluqueroRepository
    {
        public static void Agregar(Peluquero peluquero)
        {
            using var context = new ApplicationDbContext();
            context.Peluqueros.Add(peluquero);
            context.SaveChanges();
        }

        public static List<Peluquero> ObtenerTodos()
        {
            using var context = new ApplicationDbContext();
            return context.Peluqueros.ToList();
        }

        public static Peluquero ObtenerPorId(int id)
        {
            using var context = new ApplicationDbContext();
            return context.Peluqueros.Find(id);
        }

        public static void Actualizar(Peluquero peluquero)
        {
            using var context = new ApplicationDbContext();
            context.Peluqueros.Update(peluquero);
            context.SaveChanges();
        }

        public static void Eliminar(int id)
        {
            using var context = new ApplicationDbContext();
            var peluquero = context.Peluqueros.Find(id);
            if (peluquero != null)
            {
                context.Peluqueros.Remove(peluquero);
                context.SaveChanges();
            }
        }
    }
}