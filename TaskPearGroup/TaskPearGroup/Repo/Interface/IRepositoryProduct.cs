using TaskPearGroup.Models;
using TaskPearGroup.ViewModel;

namespace TaskPearGroup.Repo.Interface
{
    public interface IRepositoryProduct
    {
        public List<Product> GetProducts();
        public void AddNewProduct(ProductVm product);
        public void RemoveProduct(int Id);
        public void UpdateProduct(int oldId, ProductVm product);
        public Product GetById(int id);
    }
}
