using eShop.Application.Core.Models;
using eShop.UseCases.PluginInterfaces.DataStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShop.DataStore
{
    public class ProductRepository : IProductRepository
    {
        private List<Product> products;
        public ProductRepository()
        {
            products = new List<Product>
            {
                new Product { ProductId = 12, Brand = "cars", Name = "benz", Description ="My benz", Price = 294, ImageLink = "https://media.istockphoto.com/photos/building-a-strong-team-wooden-blocks-with-people-icon-on-pink-human-picture-id1163789606?s=612x612"},
                new Product { ProductId = 13, Brand = "Cloth", Name = "Polo", Description ="Short polo", Price = 645, ImageLink = "https://images.freeimages.com/images/large-previews/825/linked-hands-1308777.jpg"},
                new Product { ProductId = 14, Brand = "Food", Name = "Rice", Description ="Fried rice", Price = 154, ImageLink = "https://unsplash.com/photos/Wm0R21IWbZI"},
            };
        }
        public IEnumerable<Product> GetProducts(string filter = null)
        {
            if (string.IsNullOrEmpty(filter)) return products;

            return products.Where(x => x.Name.ToLower().Contains(filter.ToLower()));
        }
        public Product GetProduct(int id)
        {
            return products.FirstOrDefault(x => x.ProductId == id);
        }
    }
}
