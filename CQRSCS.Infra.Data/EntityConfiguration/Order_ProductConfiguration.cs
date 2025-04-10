
using CQRSCS.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CQRSCS.Infra.Data.EntityConfiguration; 
public class Order_ProductConfiguration : IEntityTypeConfiguration<Order_Product> {
    public void Configure(EntityTypeBuilder<Order_Product> builder) {
        builder.HasKey(e => new { e.ProductId, e.OrderId });
        builder.Property(x => x.Quantity).IsRequired();
    }
}
