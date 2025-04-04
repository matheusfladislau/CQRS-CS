using CQRSCS.Domain.Validation;

namespace CQRSCS.Domain.Entities; 

public sealed class Product : Entity {
    public Product(int id, string name, string description,
            decimal price, int stock) {
        ValidateId(id);
        ValidateName(name);
        ValidateDescription(description);
        ValidatePrice(price);
        ValidateStock(stock);

        this.Id = id;
        this.Name = name;
        this.Description = description;
        this.Price = price;
        this.Stock = stock;
    }
    public Product(string name, string description,
            decimal price, int stock) {
        ValidateName(name);
        ValidateDescription(description);
        ValidatePrice(price);
        ValidateStock(stock);

        this.Name = name;
        this.Description = description;
        this.Price = price;
        this.Stock = stock;
    }

    public string Name { get; private set; }
    public string Description { get; private set; }
    public decimal Price { get; private set; }
    public int Stock { get; private set; }


    public void Update(string name, string description,
            decimal price, int stock) {
        ValidateName(name);
        ValidateDescription(description);
        ValidatePrice(price);
        ValidateStock(stock);

        this.Name = name;
        this.Description = description;
        this.Price = price;
        this.Stock = stock;
    }

    private void ValidateId(int id) {
        DomainEntityValidation.When(id < 0,
                "Error: id must be positive.");
    }

    private void ValidateName(string name) {
        DomainEntityValidation.When(string.IsNullOrEmpty(name),
                "Error: name is required.");
    }

    private void ValidateDescription(string description) {
        DomainEntityValidation.When(string.IsNullOrEmpty(description),
                "Error: description is required.");

        DomainEntityValidation.When(description.Length > 250,
                "Error: description is too long. Maximum 250 characters.");
    }

    private void ValidatePrice(decimal price) {
        DomainEntityValidation.When(price < 0,
                "Error: price must be positive.");
    }

    private void ValidateStock(decimal stock) {
        DomainEntityValidation.When(stock < 0,
                "Error: stock must be positive.");
    }
}
