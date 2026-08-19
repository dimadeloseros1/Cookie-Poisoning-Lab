using System.ComponentModel.DataAnnotations;

namespace CookiePoisoningLab.Models;

public class LogginViewModel 
{
    [Required]
    public string UserName { get; set; } = string.Empty;

    [Required]
    [DataType(DataType.Password)]
    public string Password { get; set; } = string.Empty;
}