using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CQRSCS.Application.DTOs; 
public class CustomerDTO {
    public int Id { get; set; }

    [Required(ErrorMessage = "Name is required")]
    [DisplayName("Name")]
    public string Name { get; set; }

    [Required(ErrorMessage = "Email is required")]
    [DisplayName("Email")]
    public string Email { get; set; }

    [Required(ErrorMessage = "Birthdate is required")]
    [DisplayName("Birthdate")]
    [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}")]
    public DateTime? BirthDate { get; set; }

}
