using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Tasks.Deployment.Bootstrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Testing.Models;

namespace Testing.Controllers
{
    public class ProductController : Controller
    {
       
        private readonly IProductRepo repo;

        public ProductController(IProductRepo repo)
        {
            this.repo = repo;
        }
        public IActionResult Index()
        {
            var products = repo.GetAllProducts();


            return View(products);
        }
        public IActionResult ViewProduct(int id)
        {
            var product = repo.GetProduct(id);

            return View(product);
        }
        public IActionResult UpdateProduct(int id)
        {
            Models.Product prod = repo.GetProduct(id);

            if(prod == null)
            {
                return View("ProductNotFound");
                
            }
            return View(prod);
        }
        public IActionResult UpdateProductToDatabase(Models.Product product)
        {
            repo.UpdateProduct(product);

            return RedirectToAction("ViewProduct", new { id = product.ProductID });
        }
        public IActionResult UpdateProductModel(int id)
        {
            Models.Product prod = repo.GetProduct(id);
            repo.UpdateProduct(prod);

            if(prod == null)
            {
                return View("ProductNotFound");
            }
            return View(prod);


        }
       
        public IActionResult InsertProduct()
        {
            var prod = repo.AssignCategory();

            return View(prod);
        }
        public IActionResult InsertProductToDatabase(Models.Product productToInsert)
        {
            repo.InsertProduct(productToInsert);

            return RedirectToAction("Index");
        }
        public IActionResult DeleteProduct(Models.Product product)
        {
            repo.Deleteproduct(product);
            return RedirectToAction("Index");
        }
    }
}
