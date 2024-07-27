using Microsoft.EntityFrameworkCore;
using Temple.Core;

namespace Temple.Net.Data;

public class AppDbContext : DbContext
{
    public DbSet<Core.Temple> Temples => Set<Core.Temple>();

    public DbSet<Parishioners> Parishioners => Set<Parishioners>();

    public DbSet<Parsonalion> Parsonalions => Set<Parsonalion>();
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=database.db");
    }
}