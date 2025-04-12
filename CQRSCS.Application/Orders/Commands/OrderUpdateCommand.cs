namespace CQRSCS.Application.Orders.Commands; 
public class OrderUpdateCommand : OrderCommand {
    public int Id { get; set; }
    public OrderUpdateCommand(int id) {
        this.Id = id;
    }
}
