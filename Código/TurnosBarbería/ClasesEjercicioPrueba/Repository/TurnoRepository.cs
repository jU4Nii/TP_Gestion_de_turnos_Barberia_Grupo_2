using System.Collections.Generic;
using System.Linq;
using ClasesEjercicioPrueba.Data1;
using ClasesEjercicioPrueba.Models;
using Microsoft.EntityFrameworkCore;


namespace ClasesEjercicioPrueba.Repository
{
    public static class TurnoRepository
    {
        public static void Agregar(Turno turno)
        {
            using var context = new ApplicationDbContext();
            context.listaTurnos.Add(turno);
            context.SaveChanges();
        }

        public static List<Turno> ObtenerTodos()
        {
            using (var context = new ApplicationDbContext())
            {
                return context.listaTurnos
                    .Include(t => t.Cliente)
                    .Include(t => t.Peluquero)
                    .Include(t => t.Servicio)
                    .ToList();
            }
        }

        public static List<Turno> ObtenerPorPeluqueroId(int peluqueroId)
        {
            return ObtenerTodos().Where(t => t.PeluqueroId == peluqueroId).ToList();
        }


        public static Turno ObtenerPorId(int id)
        {
            using var context = new ApplicationDbContext();
            return context.listaTurnos.Find(id);
        }

        public static void Actualizar(Turno turno)
        {
            using var context = new ApplicationDbContext();

            context.listaTurnos.Attach(turno);
            context.Entry(turno).State = EntityState.Modified;
            context.SaveChanges();
        }


        public static void Eliminar(Turno turno)
        {
            using var context = new ApplicationDbContext();
            context.listaTurnos.Remove(turno);
            context.SaveChanges();
        }

    }
}