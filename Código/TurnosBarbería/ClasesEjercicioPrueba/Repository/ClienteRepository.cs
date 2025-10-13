using System.Collections.Generic;
using System.Linq;
using ClasesEjercicioPrueba.Data1;
using ClasesEjercicioPrueba.Models;

namespace ClasesEjercicioPrueba.Repository
{
    public static class ClienteRepository
    {
        public static void Agregar(Cliente cliente)
        {
            using var context = new ApplicationDbContext();
            context.Clientes.Add(cliente);
            context.SaveChanges();
        }

        public static List<Cliente> ObtenerTodos()
        {
            using var context = new ApplicationDbContext();
            return context.Clientes.ToList();
        }

        public static Cliente ObtenerPorId(int id)
        {
            using var context = new ApplicationDbContext();
            return context.Clientes.Find(id);
        }

        public static void Actualizar(Cliente cliente)
        {
            using var context = new ApplicationDbContext();
            context.Clientes.Update(cliente);
            context.SaveChanges();
        }

        public static void Eliminar(int id)
        {
            using var context = new ApplicationDbContext();
            var cliente = context.Clientes.Find(id);
            if (cliente != null)
            {
                context.Clientes.Remove(cliente);
                context.SaveChanges();
            }
        }
    }
}