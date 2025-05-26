using BancoSimpleProyecto.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoSimpleProyecto.Data
{
    public class BancoSimpleFreeContext : DbContext
    {
        public DbSet<ClienteClase> ClienteTabla { get; set; }

        public DbSet<CuentaClase> CuentaTabla { get; set; }

        public DbSet<TransaccionClase> TransaccionTabla { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server = DESKTOP-EKHN4JU; database = BancoSimpleFree;  Trusted_Connection = true; Encrypt = false; TrustServerCertificate = true;");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CuentaClase>().HasQueryFilter(c => c.Activo);
        }
    }
}
