namespace CQRSCS.Application.Customers.Commands; 
public sealed class CustomerCreateCommand : CustomerCommand {
    public CustomerCreateCommand(int id) {
        this.Id = id;
    }
    public int Id { get; private set; }
}
