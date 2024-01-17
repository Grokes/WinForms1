using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;
using Dapper;

namespace WinFormsApp4
{
    public class UserRepository: IUserRepository
    {
        private readonly string _connectionString;
        public static List<User> Users = new List<User>();

        public UserRepository(string conn)
        {
            _connectionString = conn;
        }

        public void Create(User user)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                string sqlQuery = $@"INSERT INTO [dbo].[Users] (Login, Password) VALUES(
                                    @{nameof(User.Login)},
                                    @{nameof(User.Password)}); 
                                    SELECT CAST(SCOPE_IDENTITY() as int)";
                int? userId = db.Query<int>(sqlQuery, user).FirstOrDefault();
                user.Id = userId.Value;
            }
        }

        public List<User> GetUsers()
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                return db.Query<User>("SELECT * FROM [dbo].[Users]").ToList();
            }
        }
    }
}
