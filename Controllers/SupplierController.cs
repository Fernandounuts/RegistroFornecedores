using CustomerRegistration.Infra.Data;
using Microsoft.AspNetCore.Mvc;

namespace CustomerRegistration.Controllers; 
public class SupplierController : Controller{
    private readonly AppDbContext _context;

    public SupplierController(AppDbContext context)
    {
        _context = context;
    }

    //[HttpPost]

}
