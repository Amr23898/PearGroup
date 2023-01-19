using System.Data.Entity;
using TaskPearGroup.Models;
using TaskPearGroup.Repo.Interface;
using TaskPearGroup.ViewModel;

namespace TaskPearGroup.Repo.Repository
{
    public class ProductRepository : IRepositoryProduct
    {
        private readonly PearGroupContext _context;

        public ProductRepository(PearGroupContext context)
        {
          _context = context;
        }
        public void AddNewProduct(ProductVm productvm)
        {
           if(productvm != null)
            {
                Product product = new Product()
                {
                    ProductName= productvm.ProductName,
                    QauantityPerUnit= productvm.QauantityPerUnit,
                    ReorderLevel= productvm.ReorderLevel,
                    UnitPrice= productvm.UnitPrice,
                    UnitsInStock = productvm.UnitsInStock,
                    SupplierId= productvm.SupplierId,
                    UnitsOnOrder = productvm.UnitsOnOrder
                    

                };
                _context.Products.Add(product);
                _context.SaveChanges();
            }

        }

        public Product GetById(int id)
        {
        
            return _context.Products.FirstOrDefault(x => x.ProductId == id);

        }

        public List<Product> GetProducts()
        {
            return _context.Products.ToList();
        }

        public void RemoveProduct(int Id)
        {
          var product = GetById(Id);
            _context.Products.Remove(product);
            _context.SaveChanges();
        }

        public void UpdateProduct(int oldId, ProductVm productvm)
        {
           var product = GetById(oldId);
            product.SupplierId = productvm.SupplierId;
            product.UnitsOnOrder = productvm.UnitsOnOrder;
            product.UnitsInStock = productvm.UnitsInStock;
            product.UnitsOnOrder = productvm.UnitsOnOrder;
            product.UnitPrice= productvm.UnitPrice;
            product.ProductName= productvm.ProductName;
            product.QauantityPerUnit= productvm.QauantityPerUnit;
            _context.Products.Update(product);
            _context.SaveChanges();
            

        }
    }
}
