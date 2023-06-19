using AS_biblioteca.Data.Context;
using AS_biblioteca.Domain.Entities;
using AS_biblioteca.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AS_biblioteca.Domain.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext context;

        public UserRepository()
        {
            this.context = new DataContext();
        }

        public UserRepository(DataContext context)
        {
            this.context = context;
        }
        public void Delete(int entityId)
        {
            var user = GetById(entityId);
            context.Users.Remove(user);
            context.SaveChanges();
            System.Console.WriteLine("Usuário deletado com sucesso!");
        }

        public IList<User> GetAll()
        {
            return context.Users.Include(p => p.Book).ToList();
        }

        public User GetById(int entityId)
        {
            return context.Users.SingleOrDefault(x => x.Id == entityId);
        }

        public void Save(User entity)
        {
            context.Add(entity);
            context.SaveChanges();
        }

        public void Save(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(User entity)
        {
            context.Users.Update(entity);
            context.SaveChanges();
        }
    }
}