namespace CQRSCS.Application.Orders.Commands; 
public sealed class OrderUpdateStatusCommand : OrderCommand {
    public int Id { get; set; }
    public OrderUpdateStatusCommand(int id) {
        this.Id = id;
    }
}
