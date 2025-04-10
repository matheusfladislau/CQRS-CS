using CQRSCS.Domain.Entities;
using CQRSCS.Domain.Enums;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CQRSCS.Application.DTOs; 
public class OrderDTO {
    public int Id { get; set; }

    [Required(ErrorMessage = "Date is required.")]
    [DisplayName("Date")]
    public DateTime? Date { get; private set; }

    [Required(ErrorMessage = "Status is required.")]
    [DisplayName("Status")]
    public OrderStatus Status { get; private set; }

    [DisplayName("Customer")]
    public int CustomerId { get; set; }
    public Customer Customer { get; set; }
}
