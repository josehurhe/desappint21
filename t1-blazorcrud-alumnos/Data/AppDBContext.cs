using System;
using Microsoft.EntityFrameworkCore;

namespace t1_blazorcrud_alumnos.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options){}
        public DbSet<Alumno> Alumnos { get; set; }
    }
}