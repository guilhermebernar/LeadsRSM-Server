using Microsoft.EntityFrameworkCore;
using rsmapp.Model;

namespace LeadsRSMserver.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options):base(options)
        {
        
        }

        public DbSet<Lead> Leads { get; set; }
    }
}
