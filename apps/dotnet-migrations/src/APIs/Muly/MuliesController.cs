using Microsoft.AspNetCore.Mvc;

namespace DotnetMigrations.APIs;

[ApiController()]
public class MuliesController : MuliesControllerBase
{
    public MuliesController(IMuliesService service)
        : base(service) { }
}
