using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDBFirst.Service
{
    public class UserSerice
    {
        public List<User> GetAll()
        {
            using (var ctx = new Sessiob04Entities())
            {
                return ctx.Users.ToList();
            }
        }

        public void Add(User user)
        {
            using (var ctx = new Sessiob04Entities())
            {
                ctx.Users.Add(user);
                ctx.SaveChanges();
            }
        }

        public void Update(User user)
        {
            using (var ctx = new Sessiob04Entities())
            {
                var model = ctx.Users.FirstOrDefault(x=> x.Id == user.Id);
                if (model != null)
                {
                    model.LastName = user.LastName;
                    model.FirstName = user.FirstName;
                }
                ctx.SaveChanges();
            }
        }


        public void Remove(int id)
        {
            using (var ctx = new Sessiob04Entities())
            {
                var model = ctx.Users.FirstOrDefault(x => x.Id == id);
                ctx.Users.Remove(model);
                ctx.SaveChanges();
            }
        }
    }
}
