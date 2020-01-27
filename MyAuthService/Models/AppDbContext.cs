using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Npgsql.EntityFrameworkCore.PostgreSQL;

namespace MyAuthService.Models
{
    public class AppDbContext : DbContext
    {
        private static string ConnectionString = "Server=172.27.3.2; Port=5432; Username=postgres; Password=Techno2018; Database=template1; SearchPath=\"netCoreAuth\";";

        public DbSet<User> users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("netCoreAuth");
        }

    }
}
