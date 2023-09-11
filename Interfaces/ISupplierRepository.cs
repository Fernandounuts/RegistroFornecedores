using CustomerRegistration.Models;

namespace CustomerRegistration.Interfaces; 
public interface ISupplierRepository {

    ICollection<Supplier> GetSuppliers();
    Supplier GetSupplier(int id);
    bool SupplierExists(int id);
    bool CreateSupplier(Supplier supplier);
    bool Save();
}
