﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp4.Models;

namespace WinFormsApp4.Repositories
{
    public interface IShopRepository
    {
        public List<Shop> GetShops();
        public void Create(Shop shop);
        public void Remove(Shop shop);
        public void CreateProduct(Shop shop, Product product);
        public void RemoveProduct(Product product);
    }
}
