using Microsoft.AspNetCore.Mvc.ModelBinding;
using TaskPearGroup.Models;
using TaskPearGroup.Repo.Interface;
using TaskPearGroup.ViewModel;

namespace TaskPearGroup.Repo.Repository
{
    public class SupplierRepo : IRepositorySuplier
    {
        private readonly PearGroupContext context;

        public SupplierRepo(PearGroupContext _context)
        {
            context = _context;
        }

        public void AddNewSupplier(SupplierVM supplier)
        {
            if (supplier != null)
            {
                var newSupplier = new Supplier()
                {
                    SupplierName=supplier.SupplierName,
                };
                context.Suppliers.Add(newSupplier);
                context.SaveChanges();
            }
        }

        public Supplier GetById(int id)
        {
            var item = context.Suppliers.FirstOrDefault(x => x.SupplierId == id);
            return item;

        }

        public List<Supplier> GetSuppliers()
        {
            
            return context.Suppliers.ToList();
        }

        public void RemoveNewSupplier(int supplierId)
        {
            var deletedsupplier = context.Suppliers.FirstOrDefault(x => x.SupplierId == supplierId);
            if(deletedsupplier != null)
            {
                context.Remove(deletedsupplier);
                context.SaveChanges();
            }
            
        }

        public void UpdateSuppliers(int oldId, SupplierVM supplier)
        {
            var oldedsupplier = context.Suppliers.FirstOrDefault(x => x.SupplierId == oldId);
            if (oldedsupplier != null)
            {
                oldedsupplier.SupplierName = supplier.SupplierName;
                context.Suppliers.Update(oldedsupplier);
                context.SaveChanges();
            }

        }
    }
}
