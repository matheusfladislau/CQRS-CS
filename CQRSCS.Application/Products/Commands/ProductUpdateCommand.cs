namespace CQRSCS.Application.Products.Commands; 
public sealed class ProductUpdateCommand : ProductCommand {
    public ProductUpdateCommand(int id) {
        this.Id = id;
    }

    public int Id { get; set; }
}
