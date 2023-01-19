using Microsoft.AspNetCore.Mvc;
using TaskPearGroup.Models;
using TaskPearGroup.Repo.Interface;
using TaskPearGroup.ViewModel;

namespace TaskPearGroup.Controllers
{
    public class SupplierController : Controller
    {
        private readonly IRepositorySuplier _repositorySuplier;

        public SupplierController(IRepositorySuplier repositorySuplier)
        {
            _repositorySuplier = repositorySuplier;
        }
        [HttpGet]
        public IActionResult GetAllSupplier()
        {
           ViewBag.Suppliers= _repositorySuplier.GetSuppliers();
           
            
            return View();
        }
       
        [HttpPost]
        public IActionResult AddNewSupplier(SupplierVM model)
        {
            if (model.SupplierName != null)
            {
                _repositorySuplier.AddNewSupplier(model);
            }

            return RedirectToAction("GetAllSupplier");
        }
        [HttpGet]
        public IActionResult EditeSupplier(int id)
        {
            var item = _repositorySuplier.GetById(id);
            SupplierVM model = new SupplierVM()
            {
                SupplierId=item.SupplierId,
                SupplierName=item.SupplierName
            };
            return View(model);
        }

         public IActionResult EditeSupplierindata(int id, SupplierVM model)
        {
            if (id != 0)
            {
                if(model != null)
                {
                    
                    _repositorySuplier.UpdateSuppliers(id, model);
                }
            }
            return RedirectToAction("GetAllSupplier");
        }
        public IActionResult DeleteSupplier(int Id)
        {
            if (Id != 0)
            {
                //var item=_repositorySuplier.GetById(id);
                _repositorySuplier.RemoveNewSupplier(Id);
            }
            return RedirectToAction("GetAllSupplier");
        }

    }
}
