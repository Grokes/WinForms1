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

        public void Create(Shop user)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                string sqlQuery = $@"INSERT INTO [dbo].[Users] (Login, Password) VALUES(
                                    @{nameof(User.Login)},
                                    @{nameof(User.Password)}); 
                                    SELECT CAST(SCOPE_IDENTITY() as int)";
                int? userId = db.Query<int>(sqlQuery, user).FirstOrDefault();
                user.ShopId = userId.Value;
            }
        }

        public List<Shop> GetShops()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var sql = @"SELECT s.ShopId, s.Name, p.ProductId, p.Name FROM [dbo].[Shops] s 
                            INNER JOIN [dbo].[ShopProducts] sp ON sp.ShopId = s.ShopId
                            INNER JOIN [dbo].[Products] p ON p.ProductId = sp.ProductId"
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
