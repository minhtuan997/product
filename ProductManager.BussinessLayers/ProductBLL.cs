using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductManager.Entites;

namespace ProductManager.BussinessLayers
{
    public class ProductBLL
    {
        private Datalayers.Interface.IProductDAL product { get; set; }
        
        public ProductBLL(string connectionString, DatabaseType dbType)
        {

            switch (dbType)
            {
                case DatabaseType.MongoDB:
                    product = new Datalayers.MongGoDB.ProductDAL(connectionString);
                    break;
                case DatabaseType.MySql:
                    product = new Datalayers.MySQL.ProductDAL(connectionString);
                    break;
                case DatabaseType.SqlServer:
                    product = new Datalayers.SQL.ProductDAL(connectionString);
                    break;
                default:
                    throw new Exception("Database not supported!");
            }
        }

        public List<Product> Product_List()
        {
            return product.list();
        }
    }
}
