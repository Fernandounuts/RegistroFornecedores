using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CustomerRegistration.Models; 
public class Supplier {
    [Key]
    public int SupplierId { get; set; }
    public string? TradingName { get; set; }
    public string? Email { get; set; }
    public string? PhoneNumber { get; set; }
    public string? BusinessName { get; set; }
    [ForeignKey("Adress")]
    public int AdressId { get; set; }
    public Adress? Adress { get; set; }
}
