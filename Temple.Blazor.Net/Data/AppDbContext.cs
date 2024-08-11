using Microsoft.EntityFrameworkCore;
using Temple.Blazor.Net.Components.Pages;
using Temple.Core;

namespace Temple.Net.Data;

public class AppDbContext : DbContext
{
    public DbSet<Core.Temple> Temples => Set<Core.Temple>();

    public DbSet<Parishioners> Parishioners => Set<Parishioners>();

    public DbSet<Parsonalion> Parsonalions => Set<Parsonalion>();

    public DbSet<TempleNote> TempleNotes => Set<TempleNote>();
    
    public DbSet<PersNote> PersNotes => Set<PersNote>();
    
    public DbSet<ParshNote> ParshNotes => Set<ParshNote>();
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=database.db");
    }
}