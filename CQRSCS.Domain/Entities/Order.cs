using CQRSCS.Domain.Enums;
using CQRSCS.Domain.Validation;

namespace CQRSCS.Domain.Entities; 

public sealed class Order : Entity {
    public Order(DateTime? date, OrderStatus status) {
        ValidateDate(date);
        ValidateStatus(status);

        this.Date = date;
        this.Status = status;
    }

    public Order(int id, DateTime? date, OrderStatus status) {
        ValidateId(id);
        ValidateDate(date);
        ValidateStatus(status);

        this.Id = id;
        this.Date = date;
        this.Status = status;
    }

    public DateTime? Date { get; private set; }
    public OrderStatus Status { get; private set; }

    public int CustomerId { get; set; }
    public Customer Customer { get; set; }

    public ICollection<OrderProduct> OrderProducts { get; set; } 

    public void Update(DateTime? date, OrderStatus status) {
        ValidateDate(date);
        ValidateStatus(status);

        this.Date = date;
        this.Status = status;
    }
    public void UpdateStatus(OrderStatus status) {
        ValidateStatus(status);

        this.Status = status;
    }

    private void ValidateId(int id) {
        DomainEntityValidation.When(id < 0,
                "Error: id must be positive.");
    }
    private void ValidateDate(DateTime? birthDate) {
        DomainEntityValidation.When(birthDate == null,
            "Error: birth date is required.");
    }
    private void ValidateStatus(OrderStatus? status) {
        DomainEntityValidation.When(status == null,
            "Error: status is required.");
    }
}
