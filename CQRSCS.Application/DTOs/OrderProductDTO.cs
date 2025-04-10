using CQRSCS.Domain.Entities;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CQRSCS.Application.DTOs; 
public class OrderProductDTO {
    [Required(ErrorMessage = "Quantity is required.")]
    [DisplayName("Quantity")]
    public int Quantity { get; set; }

    [DisplayName("Product")]
    public int ProductId { get; set; }
    public Product Product { get; set; }

    [DisplayName("Order")]
    public int OrderId { get; set; }
    public Order Order { get; set; }
}
