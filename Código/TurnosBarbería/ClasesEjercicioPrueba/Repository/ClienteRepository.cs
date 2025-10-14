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
            context.listaClientes.Add(cliente);
            context.SaveChanges();
        }

        public static List<Cliente> ObtenerTodos()
        {
            using var context = new ApplicationDbContext();
            return context.listaClientes.ToList();
        }

        public static Cliente ObtenerPorId(int id)
        {
            using var context = new ApplicationDbContext();
            return context.listaClientes.Find(id);
        }

        public static void Actualizar(Cliente cliente)
        {
            using var context = new ApplicationDbContext();
            context.listaClientes.Update(cliente);
            context.SaveChanges();
        }

        public static void Eliminar(int id)
        {
            using var context = new ApplicationDbContext();
            var cliente = context.listaClientes.Find(id);
            if (cliente != null)
            {
                context.listaClientes.Remove(cliente);
                context.SaveChanges();
            }
        }
    }
}