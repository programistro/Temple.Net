using Microsoft.EntityFrameworkCore;
using Temple.Net.Models;

namespace Temple.Net.Data;

public class AppDbContext : DbContext
{
    public DbSet<Models.Temple> Temples => Set<Models.Temple>();

    public DbSet<Parishioners> Parishioners => Set<Parishioners>();

    public DbSet<Parsonalion> Parsonalions => Set<Parsonalion>();
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=database.db");
    }
}