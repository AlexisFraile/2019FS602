using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using _2019FS602.Models;
namespace _2019FS602
{
    public class _2019FS602Context : DbContext
    {
        public _2019FS602Context(DbContextOptions<_2019FS602Context> options) : base(options)
        {
            
        }
        public DbSet<equipos> equipos {get; set;}
        public DbSet<estados_equipo> estados_equipo {get; set;}
        public DbSet<marcas> marcas {get; set;}
        public DbSet<tipo_equipo> tipo_equipo {get; set;}
    }
}