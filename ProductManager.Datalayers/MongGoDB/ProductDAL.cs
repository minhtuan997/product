﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductManager.Datalayers.Interface;
using ProductManager.Entites;

namespace ProductManager.Datalayers.MongGoDB
{
    public class ProductDAL : IProductDAL
    {
        private string connectionString;
        public ProductDAL(string connectionString)
        {

        }

        public bool Add(Product data)
        {
            return true;
        }

        public bool Delete(int productId)
        {
            return true;
        }

        public List<Product> list()
        {
            List<Product> list = new List<Product>();
            list.Add(new Product()
            {
                ProductId = 1,
                ProductName = "MongGoDB"
            });
            return list;
        }

        public bool Update(Product data)
        {
            return true;
        }
    }
}
