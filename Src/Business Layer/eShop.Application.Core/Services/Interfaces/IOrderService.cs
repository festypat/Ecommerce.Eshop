using eShop.Application.Core.Models;

namespace eShop.Application.Core.Services.Interfaces
{
    public interface IOrderService
    {
        bool ValidateCreateOrder(Order order);
        bool ValidateCustomerInformation(string name, string address, string city, string province, string country);
        bool ValidateProcessOrder(Order order);
        bool ValidateUpdateOrder(Order order);
    }
}