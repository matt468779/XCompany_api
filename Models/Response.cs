namespace XCompany_api.Models;
using System.ComponentModel.DataAnnotations;

public class Response
{
    [Key]
    public string? Status { get; set; }
    public string? Message { get; set; }
}
