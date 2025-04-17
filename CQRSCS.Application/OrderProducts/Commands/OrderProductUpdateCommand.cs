using System.Reflection.Metadata.Ecma335;

namespace CQRSCS.Application.OrderProducts.Commands; 
public sealed class OrderProductUpdateCommand : OrderProductCommand {
    public OrderProductUpdateCommand(int quantity) {
        this.Quantity = quantity;
    }
    public int Quantity { get; private set; }
}
