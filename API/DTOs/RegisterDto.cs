using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace API;

public class RegisterDto
{
    [MaxLength(100)]
    public required string Username { get; set; }

    public required string Password { get; set; }
}
