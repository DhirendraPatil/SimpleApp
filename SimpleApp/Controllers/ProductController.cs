using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace SimpleApp.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult Index()
        {
            return View(Repository.GetProducts()); ;
        }

       
    }

    public class Repository
    {

        static readonly List<Product> products = new List<Product>();
        static int s_counter = 1;
        static Random random = new Random();
    internal    static IEnumerable<Product> GetProducts()
        {
            products.Add(new Product() { Id = s_counter, Price = random.NextDouble(), ProductName = "product " + s_counter, ProductDesc = "This is description for product " + s_counter });
            s_counter++;
            return products;
        }

    }

   public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string ProductDesc { get; set; }
        public double Price { get; set; }
        public Product[] RelatedProducts { get; set; }
    }
}