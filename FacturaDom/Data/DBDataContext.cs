using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Sqlite;
using Microsoft.EntityFrameworkCore;
using FacturaDom.BDO.Modelos;
using System.Configuration;
using Microsoft.Data.Sqlite;

namespace FacturaDom.Data
{
    public class DBDataContext : DbContext
    {
        private static DbContext instance;
        private static readonly object lockObject = new object();
        private DBDataContext(DbContextOptions<DBDataContext> options) : base(options) {
            
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Sesiones> Sesiones { get; set; }
        public DbSet<Factura> Factura { get; set; }
        public DbSet<Articulo> Articulo { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<DetalleFactura> detalleFacturas { get; set; }
        public DbSet<Movimientos> Movimientos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Data Source=DBDataContext.db");
            }



        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var eliminar = false;

            if (eliminar == true)
            {
                var Files = Directory.EnumerateFiles(Directory.GetCurrentDirectory());
                foreach (var file in Files)
                {
                    if (file.EndsWith(".db"))
                    {
                        try
                        {
                            File.Delete(file);
                        }
                        catch
                        {

                        }
                        
                    }
                }
            }

            base.OnModelCreating(modelBuilder);
        }

        public static DBDataContext Instance
        {
            get
            {
                    if (instance == null)
                    {
                        lock (lockObject)
                        {
                            if (instance == null)
                            {
                                instance = new DBDataContext(new DbContextOptionsBuilder<DBDataContext>()
            .UseSqlite(ConfigurationManager.ConnectionStrings["DBDataContext"].ConnectionString)
            .Options);
                            }
                        }
                    }
                return (DBDataContext)instance;
            }
        }
    }
}
