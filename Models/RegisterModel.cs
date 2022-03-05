using System.ComponentModel.DataAnnotations;

namespace XCompany_api.Models;

public class RegisterModel
{
    [Key]
    [Required(ErrorMessage = "User Name is required")]
    public string? Username { get; set; }

    [EmailAddress]
    [Required(ErrorMessage = "Email is required")]
    public string? Email { get; set; }

    [Required(ErrorMessage = "Password is required")]
    public string? Password { get; set; } 
    public string? Role{ get; set; }
}
