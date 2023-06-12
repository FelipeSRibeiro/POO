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

        public PeopleRepository(){
            this.context = new DataContext();
        }


         void IBaseRepository<People>.Delete(int entityId)
        {
            var people = GetById(entityId);
            context.Peoples.Remove(people);
            context.SaveChanges();

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