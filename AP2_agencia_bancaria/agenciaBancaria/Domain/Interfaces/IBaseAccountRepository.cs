
namespace agenciaBancaria.Domain.Interfaces
{
    public interface IBaseAccountRepository<Entity> where Entity : class
    {
        Entity GetById(int entityId);
        IList<Entity> GetAll();
        void Save(Entity entity, string cpf);
        void Delete(int entityId);
        void Update(Entity entity);
    }
}