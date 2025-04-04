using CQRSCS.Domain.Enums;
using CQRSCS.Domain.Validation;

namespace CQRSCS.Domain.Entities; 

public sealed class Order : Entity {
    public Order(int id, DateTime? date, OrderStatus status) {
        ValidateId(id);
        ValidateDate(date);
        //ValidateStatus(status);
    }

    public DateTime? Date { get; private set; }
    public OrderStatus Status { get; private set; }

    public int CustomerId { get; set; }
    public Customer Customer { get; set; }

    private void ValidateId(int id) {
        DomainEntityValidation.When(id < 0,
                "Error: Id must be positive.");
    }
    private void ValidateDate(DateTime? birthDate) {
        DomainEntityValidation.When(birthDate == null,
            "Error: birthDate is required.");
    }
    
}
