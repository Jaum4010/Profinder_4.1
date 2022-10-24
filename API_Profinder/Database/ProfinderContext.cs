using Microsoft.EntityFrameworkCore;
using Profinder_Domain.Models;

namespace API_Profinder.Database
{
    public class ProfinderContext :DbContext

    {
        public ProfinderContext(DbContextOptions<ProfinderContext> options): base(options)
            { 
        
            }

        public DbSet<User> Users { get; set; }

        public DbSet<Materia> Materias { get; set; }
    }
}
