using CQRSCS.Domain.Entities;
using Microsoft.VisualBasic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CQRSCS.Application.DTOs; 
public class ProductDTO {
    public int Id { get; set; }

    [Required(ErrorMessage = "Name is required.")]
    [DisplayName("Name")]
    public string Name { get; set; }

    [Required(ErrorMessage = "Description is required.")]
    [MaxLength(250)]
    [DisplayName("Description")]
    public string Description { get; set; }

    [Required(ErrorMessage = "Price is required.")]
    [Column(TypeName = "decimal(18,2")]
    [DisplayFormat(DataFormatString = "{0:C2}")]
    [DataType(DataType.Currency)]
    [DisplayName("Price")]
    public decimal Price { get; set; }

    [Required(ErrorMessage = "Stock is required.")]
    [Range(1,9999)]
    [DisplayName("Stock")]
    public int Stock { get; set; }
}
