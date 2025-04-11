﻿using CQRSCS.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CQRSCS.Infra.Data.EntityConfiguration;
public class OrderConfiguration : IEntityTypeConfiguration<Order> {
    public void Configure(EntityTypeBuilder<Order> builder) {
        builder.HasKey(p => p.Id);

        builder.Property(x => x.Date).IsRequired();
        builder.Property(x => x.Status).IsRequired();

        builder.HasOne(x => x.Customer)
               .WithMany(x => x.Orders)
               .HasForeignKey(x => x.CustomerId)
               .OnDelete(DeleteBehavior.Cascade)
               .IsRequired();
        
        builder.HasMany(x => x.OrderProducts)
               .WithOne(x => x.Order)
               .HasForeignKey(x => x.OrderId)
               .OnDelete(DeleteBehavior.Cascade)
               .IsRequired();
    }
}
