using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductManager.Entites;
namespace ProductManager.Datalayers.Interface
{
    public interface IProductDAL
    {
        List<Product> list();
        bool Add(Product data);
        bool Update(Product data);
        bool Delete(int productId);

    }
}
