using Microsoft.EntityFrameworkCore;
using System;

namespace APIGestores.Context
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
        }

        // Muy importante que "gestores_bd" sea el mismo nombre de la tabla que hay en la BD
        public DbSet<Models.GestoresBD> gestores_bd { get; set; }
    }
}