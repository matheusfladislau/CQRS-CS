namespace CQRSCS.Application.OrderProducts.Commands; 
public sealed class OrderProductCreateCommand : OrderProductCommand {
    public OrderProductCreateCommand(int quantity) {
        this.Quantity = quantity;
    }
    public int Quantity { get; private set; }
}