using CQRSCS.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage;

namespace CQRSCS.Infra.Data.EntityConfiguration;
public class CustomerConfiguration : IEntityTypeConfiguration<Customer> {
    public void Configure(EntityTypeBuilder<Customer> builder) {
        builder.HasKey(p => p.Id);

        builder.Property(x => x.Name).IsRequired();
        builder.Property(x => x.BirthDate).IsRequired();
    }
}
