using ConsoleApp1.Model;
using ConsoleApp1.SqlDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Service
{
    public class UserService
    {
        private SqlDbContextClass dbContext = new SqlDbContextClass();
        public void CreateNew()
        {
            var user = new Users() { 
                username = "trunggg",
                password = "hihihi",
                deviceToken = "cxcxcxcxc"
            };
            dbContext.users.Add(user);
            dbContext.SaveChanges();
        }
    }
}
