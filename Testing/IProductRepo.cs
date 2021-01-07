using Microsoft.Build.Tasks.Deployment.Bootstrapper;
using System.Collections.Generic;
using Testing.Models;
using MySql.Data;
using Dapper;
using Microsoft.Build.Tasks;

namespace Testing
{
    public interface IProductRepo
    {
        public IEnumerable<Models.Product> GetAllProducts();

        
        public Models.Product GetProduct(int id);
        public void UpdateProduct(Models.Product product);
       
        public IEnumerable<Category> GetCategories();
        public Models.Product AssignCategory();
       
        public void InsertProduct(Models.Product productToInsert);
        public void Deleteproduct(Models.Product product);
    }
}