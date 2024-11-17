using DotnetMigrations.APIs.Dtos;
using DotnetMigrations.Infrastructure.Models;

namespace DotnetMigrations.APIs.Extensions;

public static class MuliesExtensions
{
    public static Muly ToDto(this MulyDbModel model)
    {
        return new Muly
        {
            CreatedAt = model.CreatedAt,
            Id = model.Id,
            Swim = model.Swim,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static MulyDbModel ToModel(this MulyUpdateInput updateDto, MulyWhereUniqueInput uniqueId)
    {
        var muly = new MulyDbModel { Id = uniqueId.Id, Swim = updateDto.Swim };

        if (updateDto.CreatedAt != null)
        {
            muly.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            muly.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return muly;
    }
}
