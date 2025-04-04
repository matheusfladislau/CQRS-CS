using System;

namespace CQRSCS.Domain.Entities; 

public sealed class Order : Entity {
    
    public DateTime? Date { get; private set; }


//     OrderId: Unique identifier.
//
// CustomerId: Link to the customer.
//
// OrderDate: Date when the order was created.
//
// OrderItems: List of items that are part of the order.
//
// Status: e.g., Pending, Shipped, Delivered, etc.
//
// TotalAmount: The total price of the order.
}
