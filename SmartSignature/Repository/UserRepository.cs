using SmartSignature.Models;
using SmartSignature.Repository.Context;
using System.Collections.Generic;
using System.Linq;

namespace SmartSignature.Repository
{
    public class UserRepository
    {
        private readonly DataBaseContext context;

        public UserRepository()
        {
            context = new DataBaseContext();
        }


        public IList<User> List()
        {
            return context.User.ToList();
        }


        public User Find(int id)
        {
            return context.User.Find(id);
        }

        public void Add(User user)
        {
            context.User.Add(user);
            context.SaveChanges();
        }

        public void Update(User user)
        {
            context.User.Update(user);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var user = new User()
            {
                CaixaAccount = id
            };

            context.User.Remove(user);
            context.SaveChanges();
        }

    }
}