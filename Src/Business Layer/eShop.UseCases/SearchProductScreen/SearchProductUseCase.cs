using eShop.Application.Core.Models;
using eShop.UseCases.PluginInterfaces.DataStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShop.UseCases.SearchProductScreen
{
    public class SearchProductUseCase : ISearchProductUseCase
    {
        private readonly IProductRepository _productRepository;
        public SearchProductUseCase(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public IEnumerable<Product> Execute(string filter)
        {
            return _productRepository.GetProducts(filter);
        }
    }
}
