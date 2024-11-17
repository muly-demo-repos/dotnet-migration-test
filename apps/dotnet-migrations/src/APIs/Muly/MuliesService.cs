using DotnetMigrations.Infrastructure;

namespace DotnetMigrations.APIs;

public class MuliesService : MuliesServiceBase
{
    public MuliesService(DotnetMigrationsDbContext context)
        : base(context) { }
}
