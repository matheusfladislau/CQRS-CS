namespace CQRSCS.Application.Customers.Commands; 
public sealed class CustomerUpdateCommand : CustomerCommand {
    public CustomerUpdateCommand(int id) {
        this.Id = id;
    }
    public int Id { get; private set; }
}
