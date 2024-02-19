using AppCodeFirst.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCodeFirst.Service
{
    public class UserService
    {
        public void Add(User user)
        {            
            using var ctx = new AppDbContext();
            ctx.Users.Add(user);
            ctx.SaveChanges();
        }

        public List<User> GetAll()
        {
            using var ctx = new AppDbContext();
            return ctx.Users.ToList();
        }
    }
}
