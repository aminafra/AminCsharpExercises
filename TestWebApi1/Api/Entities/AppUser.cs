using System.ComponentModel.DataAnnotations;

namespace Api.Entities;

public class AppUser
{
    public int? Id { get; set; }

    public string? UserName { get; set; }

    public string? PhoneNumber { get; set; }
    
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{yyyy/MM/dd}")]
    public DateTime? BirthDate { get; set; }
    
    public int? Age { get; set; }

    public byte[]? PasswordHash { get; set; }

    public byte[]? PasswordSalt { get; set; }
}