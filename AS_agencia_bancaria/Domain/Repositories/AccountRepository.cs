
using agenciaBancaria.Data.Context;
using agenciaBancaria.Domain.Entities;
using agenciaBancaria.Domain.Interfaces;

namespace agenciaBancaria.Domain.Repositories
{
    public class AccountRepository : IAccountRepository
    {

        private readonly DataContext context;

        public AccountRepository(DataContext context){
            this.context = context;
        }

        
        public void Delete(int entityId)
        {
            var a = GetById(entityId);
            context.Accounts.Remove(a);
            context.SaveChanges();
            System.Console.WriteLine("Conta deletada com sucesso");
        }

        public IList<Account> GetAll()
        {
              return context.Accounts.ToList();
        }

        public Account GetById(int entityId)
        {
            return context.Accounts.SingleOrDefault(x => x.Id == entityId);
        }


     public void Save(Account entity, string cpf)
        {
            var existingPerson = context.Peoples.SingleOrDefault(x => x.Cpf == cpf);
            if (existingPerson != null)
            {
                entity.People = existingPerson;
                context.Accounts.Add(entity);
                context.SaveChanges();
             Console.WriteLine("Conta criada com sucesso e vinculada ao cliente.");
            }
            else
            {
                Console.WriteLine("Cliente não encontrado. A conta não pode ser criada.");
            }
        }


        public void Update(Account entity)
        {
            context.Accounts.Update(entity);
            context.SaveChanges();
        }
    }
}