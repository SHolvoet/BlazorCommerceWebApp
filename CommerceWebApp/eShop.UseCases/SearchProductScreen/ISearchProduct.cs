using eShop.CoreBusiness.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.UseCases.SearchProductScreen
{
    public interface ISearchProduct
    {
        IEnumerable<Product> Execute(string filter = null);
    }
}
