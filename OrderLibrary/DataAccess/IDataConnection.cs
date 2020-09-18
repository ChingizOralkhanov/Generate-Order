using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderLibrary.DataAccess
{
    public interface IDataConnection
    {
        ProductModel CreateProduct(ProductModel model);
        List<ProductModel> GetProductsAll();
    }
}
