using InscripcionesWebApp.Modelo;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InscripcionesWebApp.DAL
{
    public class ApplicationDbContext : DbContext   
    {
        public DbSet<Aspirante> Aspirantes { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
    }
}
