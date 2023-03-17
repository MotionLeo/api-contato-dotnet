using Microsoft.EntityFrameworkCore;
using Modulo_Api.Entites;

namespace Modulo_Api.Context;

public class AgendaContext : DbContext
{
    public AgendaContext(DbContextOptions<AgendaContext> options) : base(options) {}
    public DbSet<Contato> Contatos { get; set;}
}