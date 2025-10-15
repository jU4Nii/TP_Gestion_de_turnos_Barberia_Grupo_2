using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ClasesEjercicioPrueba.Models;

namespace ClasesEjercicioPrueba.Data1
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Cliente> listaClientes { get; set; }

        public DbSet<Peluquero> listaPeluqueros { get; set; }

        public DbSet<Servicio> listaServicios { get; set; }

        public DbSet<Turno> listaTurnos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=JUANI\\SQLEXPRESS04;Database=BarberiaDB;Trusted_Connection=True;TrustServerCertificate=True;"
            );
        }



    }
}
