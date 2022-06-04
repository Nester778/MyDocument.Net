using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyDocument4.Domain
{
    public class UserRepository
    {
        private readonly AppDbContext context;

        public UserRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IQueryable<User> GetUsers()
        {
            return context.user.OrderBy(x => x.Number);
        }

        public User GetLastUser(IQueryable<User> users)
        {
            User LastUser = new User();
            int a = 0;
            foreach (User user in users)
            {
                a++;
            }
            foreach (User user in users)
            {
                if (user.Number == a)
                    LastUser = user;
            }
            return LastUser;
        }

        public User GetUserById(Guid id)
        {
            return context.user.Single(x => x.Id == id);
        }

        public Guid SaveUser(User entity, IQueryable<User> users)
        {
            int a = 1;
            foreach (User user in users)
            {
                a++;
            }
            entity.Number = a;
            if (entity.Id == default)
                context.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Added;
            else
                context.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;

            context.SaveChanges();

            context.SaveChanges();


            return entity.Id;
        }

        public void DeleteArticle(User entity)
        {
            context.user.Remove(entity);
            context.SaveChanges();
        }

    }
}
