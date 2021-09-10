using eShop.Application.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShop.UseCases.ViewProductScreen.Interfaces
{
    public interface IViewProductUseCase
    {
        Product Execute(int id);
    }
}
