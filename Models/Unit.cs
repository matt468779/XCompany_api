using System.ComponentModel.DataAnnotations;

namespace XCompany_api.Models;

public class Unit
{
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string? Name { get; set; }

    [Required]
    public String? description { get; set; }
    }