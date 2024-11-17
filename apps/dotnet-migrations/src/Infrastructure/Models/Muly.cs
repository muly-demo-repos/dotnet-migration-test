using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DotnetMigrations.Infrastructure.Models;

[Table("Mulies")]
public class MulyDbModel
{
    [Required()]
    public DateTime CreatedAt { get; set; }

    [Key()]
    [Required()]
    public string Id { get; set; }

    [StringLength(1000)]
    public string? Swim { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }
}
