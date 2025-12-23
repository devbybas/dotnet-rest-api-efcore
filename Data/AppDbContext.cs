using DotnetRestApiEfCore.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace DotnetRestApiEfCore.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Contact> Contacts => Set<Contact>();
}
