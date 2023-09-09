using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CustomerRegistration.Models; 
public class Adress {
    [Key]
    public int AdrrressId { get; set; }
    [MaxLength(50)]
    public string? State { get; set; }

    [MaxLength(70)]
    public string? City { get; set; }

    [MaxLength(70)]
    public string? Street { get; set; }

    [MaxLength(5)]
    public string? Number { get; set; }

    [ForeignKey("Country")]
    public int CountryId { get; set; }
    public Country? Country { get; set; }
}
