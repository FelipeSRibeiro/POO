using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using agenciaBancaria.Data.Context;
using agenciaBancaria.Domain.Entities;
using agenciaBancaria.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace agenciaBancaria.Domain.Repositories
{
    public class PeopleRepository : IPeopleRepository
    {
        private readonly DataContext context;

        public PeopleRepository(DataContext context){
            this.context = context;
        }


        void IBaseRepository<People>.Delete(int entityId)
        {
            var people = GetById(entityId);

            if(people != null && people.Account.Count > 0)
            {
                System.Console.WriteLine("Não foi excluir o cliente. Existen contas vinculadas ele");
            }
            else
            {
                context.Peoples.Remove(people);
                context.SaveChanges();
                 System.Console.WriteLine("Cliente deletado com sucesso");
            }
        }

        public IList<People> GetAll()
        {
            return context.Peoples.Include(p => p.Account).ToList();
        }

        public People GetById(int entityId)
        {
            return context.Peoples.SingleOrDefault(x => x.Id == entityId);
        }

        public void Save(People entity)
        {
            context.Add(entity);
            context.SaveChanges();
        }

        public void Update(People entity)
        {
            context.Peoples.Update(entity);
            context.SaveChanges();
        }
    }
}