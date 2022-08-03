using System.ComponentModel.DataAnnotations;

namespace Api.DTO;

public class BirthdayDto
{
    public int? Id { get; set; }
    
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{yyyy-MM-dd}")]
    public DateTime? BirthDate { get; set; }
    
    public int? Age
    {
        get
        {
            if (BirthDate == null)
                return null;
            var age = DateTime.Today.Year - BirthDate.Value.Year;
            if (BirthDate.Value.AddYears(age) > DateTime.Today)
                age--;
            return age;
        }
    }
}

