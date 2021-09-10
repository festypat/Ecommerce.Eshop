using eShop.Application.Core.Models;
using System.Threading.Tasks;

namespace eShop.UseCases.ShoppingCartScreen.Interfaces
{
    public interface IViewShoppingCartUseCase
    {
        Task<Order> Execute();
    }
}