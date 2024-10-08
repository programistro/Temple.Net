﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Temple.Net.Models;

namespace Temple.Net.Data;

public class UserDbContext : IdentityDbContext<User>
{
    public DbSet<User> Users => Set<User>();
    
    public UserDbContext(DbContextOptions<UserDbContext> options)
        : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
    {
        optionsBuilder.UseSqlite("Data Source=users.db");
    }
}