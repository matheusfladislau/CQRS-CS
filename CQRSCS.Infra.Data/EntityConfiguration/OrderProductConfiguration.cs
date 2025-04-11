
using CQRSCS.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CQRSCS.Infra.Data.EntityConfiguration; 
public class OrderProductConfiguration : IEntityTypeConfiguration<OrderProduct> {
    public void Configure(EntityTypeBuilder<OrderProduct> builder) {
        builder.HasKey(e => new { e.ProductId, e.OrderId });
        builder.Property(x => x.Quantity).IsRequired();
    }
}
