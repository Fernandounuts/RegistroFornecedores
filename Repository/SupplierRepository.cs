using CustomerRegistration.Infra.Data;
using CustomerRegistration.Interfaces;
using CustomerRegistration.Models;

namespace CustomerRegistration.Repository {

    public class SupplierRepository : ISupplierRepository {
        private readonly AppDbContext _context;

        public SupplierRepository(AppDbContext context)
        {
            _context = context;
        }
        public bool CreateSupplier(Supplier supplier) {
            _context.Add(supplier);
            return Save();
        }

        public Supplier GetSupplier(int id) {
            var supplier = _context.Suppliers.Where(s => s.SupplierId == id).FirstOrDefault();
            if (supplier == null) {
                return null;
            }
            return supplier;
        }

        public ICollection<Supplier> GetSuppliers() {
            return _context.Suppliers.OrderBy(s => s.SupplierId).ToList();
        }

        public bool Save() {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool SupplierExists(int id) {
            return _context.Suppliers.Any(s => s.SupplierId == id);
        }
    }
}
