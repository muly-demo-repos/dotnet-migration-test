using DotnetMigrations.Infrastructure.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DotnetMigrations.Infrastructure;

public class DotnetMigrationsDbContext : IdentityDbContext<IdentityUser>
{
    public DotnetMigrationsDbContext(DbContextOptions<DotnetMigrationsDbContext> options)
        : base(options) { }

    public DbSet<MulyDbModel> Mulies { get; set; }
}
