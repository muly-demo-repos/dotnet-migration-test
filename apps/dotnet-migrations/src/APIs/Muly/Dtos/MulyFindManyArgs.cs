using DotnetMigrations.APIs.Common;
using DotnetMigrations.Infrastructure.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotnetMigrations.APIs.Dtos;

[BindProperties(SupportsGet = true)]
public class MulyFindManyArgs : FindManyInput<Muly, MulyWhereInput> { }
