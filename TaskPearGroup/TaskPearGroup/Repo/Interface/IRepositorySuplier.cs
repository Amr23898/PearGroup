using TaskPearGroup.Models;
using TaskPearGroup.ViewModel;

namespace TaskPearGroup.Repo.Interface
{
    public interface IRepositorySuplier
    {
        public List<Supplier> GetSuppliers();
        public void AddNewSupplier(SupplierVM supplier);
        public void RemoveNewSupplier(int supplierId);
        public void UpdateSuppliers(int oldId,SupplierVM supplier);
        public Supplier GetById(int id);
    }
}
