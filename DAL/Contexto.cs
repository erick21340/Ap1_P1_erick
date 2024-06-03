using Ap1_P1_erick.Models;
using Microsoft.EntityFrameworkCore;

namespace Ap1_P1_erick.DAL
{
    public class Contexto :DbContext
    {
        public  Contexto(DbContextOptions<Contexto> options)
            : base(options) { }

        public DbSet<Articulos> Articulos { get; set; }
    }
}
