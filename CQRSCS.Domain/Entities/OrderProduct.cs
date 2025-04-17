
using CQRSCS.Domain.Validation;

namespace CQRSCS.Domain.Entities; 
public class OrderProduct {
    public OrderProduct(int quantity, int productId, int orderId) {
        ValidateQuantity(quantity);
        ValidateId(productId);
        ValidateId(orderId);

        this.Quantity = quantity;
        this.ProductId = productId;
        this.OrderId = orderId;
    }

    public int Quantity { get; private set; }

    public int ProductId { get; set; }
    public Product Product { get; set; }

    public int OrderId { get; set; }
    public Order Order { get; set; }

    public void Update(int quantity) {
        ValidateQuantity(quantity);

        this.Quantity = quantity;
    }

    private void ValidateId(int id) {
        DomainEntityValidation.When(id < 0,
                "Error: id must be positive.");
    }
    private void ValidateQuantity(int quantity) {
        DomainEntityValidation.When(quantity < 0,
                "Error: quantity must be positive.");
    }
}
