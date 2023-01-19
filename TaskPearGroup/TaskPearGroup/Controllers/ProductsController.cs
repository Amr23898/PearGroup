using Microsoft.AspNetCore.Mvc;
using TaskPearGroup.Repo.Interface;
using TaskPearGroup.ViewModel;

namespace TaskPearGroup.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IRepositoryProduct _repositoryProduct;
        private readonly IRepositorySuplier _repositorySuplier;

        public ProductsController(IRepositoryProduct repositoryProduct,IRepositorySuplier repositorySuplier)
        {
            _repositoryProduct = repositoryProduct;
              _repositorySuplier = repositorySuplier;
        }
       public IActionResult GetAllProducts()
        {
            ViewBag.AppSuppliers=_repositorySuplier.GetSuppliers();
            ViewBag.AllProducts=_repositoryProduct.GetProducts();
            return View();
        }
        [HttpPost]
        public IActionResult AddNewProduct(ProductVm model)
        {
            if (ModelState.IsValid)
            {
                _repositoryProduct.AddNewProduct(model);
            }
            return RedirectToAction("GetAllProducts");
        }

        [HttpGet]
        public IActionResult EditeProduct(int id)
        {
            ViewBag.AppSuppliers = _repositorySuplier.GetSuppliers();
            var item = _repositoryProduct.GetById(id);
            ProductVm model = new ProductVm()
            {
                ProductId = id,
               ProductName=item.ProductName,
               QauantityPerUnit=(decimal)item.QauantityPerUnit,
               ReorderLevel= (decimal)item.ReorderLevel,
               UnitPrice= (decimal)item.UnitPrice,
               UnitsInStock=(int)item.UnitsInStock,
               UnitsOnOrder=(int)item.UnitsOnOrder,
               SupplierId=(int)item.SupplierId
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult EditeProductindata(int id, ProductVm model)
        {
            if (id != 0)
            {
                if (model != null)
                {
                    _repositoryProduct.UpdateProduct(id, model);
                }
            }
            return RedirectToAction("GetAllProducts");
        }
        public IActionResult DeleteSupplier(int Id)
        {
            if (Id != 0)
            {
                 _repositoryProduct.RemoveProduct(Id);
            }
            return RedirectToAction("GetAllProducts");
        }


    }
}
