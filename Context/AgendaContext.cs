using AspNetDioMe.Models;
using Microsoft.EntityFrameworkCore;

namespace AspNetDioMe.Context
{
    public class AgendaContext : DbContext
    {
       
        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options)
        {

        }

        public DbSet<Contato> Contatos { get; set; }

    }
}
