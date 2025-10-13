using System.Collections.Generic;
using System.Linq;
using ClasesEjercicioPrueba.Data1;
using ClasesEjercicioPrueba.Models;

namespace ClasesEjercicioPrueba.Repository
{
    public static class TurnoRepository
    {
        public static void Agregar(Turno turno)
        {
            using var context = new ApplicationDbContext();
            context.Turnos.Add(turno);
            context.SaveChanges();
        }

        public static List<Turno> ObtenerTodos()
        {
            using var context = new ApplicationDbContext();
            return context.Turnos.ToList();
        }

        public static Turno ObtenerPorId(int id)
        {
            using var context = new ApplicationDbContext();
            return context.Turnos.Find(id);
        }

        public static void Actualizar(Turno turno)
        {
            using var context = new ApplicationDbContext();
            context.Turnos.Update(turno);
            context.SaveChanges();
        }

        public static void Eliminar(int id)
        {
            using var context = new ApplicationDbContext();
            var turno = context.Turnos.Find(id);
            if (turno != null)
            {
                context.Turnos.Remove(turno);
                context.SaveChanges();
            }
        }
    }
}