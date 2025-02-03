using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WL.Domain.Entities;

namespace WL.Data.Mappings;

public static class BaseMap
{
    public static void BaseProperties<T>(EntityTypeBuilder<T> builder) where T : BaseEntity
    {
        builder.HasKey(x => x.Id);
    }
}
