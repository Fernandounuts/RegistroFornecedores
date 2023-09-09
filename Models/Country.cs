using System.ComponentModel.DataAnnotations;

namespace CustomerRegistration.Models; 
public class Country {
    [Key]
    public int CountryId { get; set; }

    [MaxLength(50)]
    public string? Name { get; set; }
}
