using eShop.Application.Core.Models;
using eShop.UseCases.PluginInterfaces.DataStore;
using eShop.UseCases.ViewProductScreen.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShop.UseCases.ViewProductScreen
{
    public class ViewProductUseCase : IViewProductUseCase
    {
        private readonly IProductRepository _productRepository;
        public ViewProductUseCase(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public Product Execute(int id)
        {
            return _productRepository.GetProduct(id);
        }
    }
}
