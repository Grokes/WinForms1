using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp4.Models;

namespace WinFormsApp4.Repositories
{
    internal class ShopRepository : IShopRepository
    {
        private readonly string _connectionString;
        public static List<Product> Users = new List<Product>();

        public ShopRepository(string conn)
        {
            _connectionString = conn;
        }

        public void Create(Shop shop)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                string sqlQuery = $@"INSERT INTO [dbo].[Shops] (Name) VALUES(
                                    @{nameof(Shop.Name)});";
                db.Execute(sqlQuery, shop);
            }
        }

        public void CreateProduct(Shop shop, Product product)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                string sqlQuery = $@"INSERT INTO [dbo].[Products] (Name) VALUES(
                                    @{nameof(Product.Name)});
                                    SELECT scope_identity();";
                //db.Execute(sqlQuery, product);
                product.ProductId = db.Query<int>(sqlQuery, product).FirstOrDefault();

                sqlQuery = $@"INSERT INTO [dbo].[ShopProducts] (ShopId, ProductId) VALUES(
                                    @{nameof(Shop.ShopId)}, @{nameof(Product.ProductId)});";
                db.Execute(sqlQuery, new { shop.ShopId, product.ProductId});
            }
        }

        public List<Shop> GetShops()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var sql = @"SELECT s.ShopId, s.Name, p.ProductId, p.Name FROM [dbo].[Shops] s 
                            LEFT JOIN [dbo].[ShopProducts] sp ON sp.ShopId = s.ShopId
                            LEFT JOIN [dbo].[Products] p ON p.ProductId = sp.ProductId"
                ;

                var shops = connection.Query<Shop, Product, Shop>(sql, (shop, product) => {
                    shop.Products = new List<Product> { product };
                    return shop;
                }, splitOn: "ProductId").ToList();

                var result = shops.GroupBy(p => p.ShopId).Select(g =>
                {
                    var groupedShop = g.First();
                    groupedShop.Products = g.Select(p => p.Products.Single()).ToList();
                    return groupedShop;
                }).ToList();

                return result;
            }
        }
    }
}
