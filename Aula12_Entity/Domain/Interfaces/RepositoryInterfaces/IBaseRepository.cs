using System.Linq.Expressions;

namespace Aula12_Entity.Domain.Interfaces.RepositoryInterfaces
{
    public interface IBaseRepository<Entity> : IDisposable where Entity : class
    {
        Task<IList<Entity>> SearchAll(Expression<Func<Entity, bool>>predicate);
        Task<Entity> GetByIdAsync(int antityId);
        Task<IList<Entity>> GetAllAsync();
        void Save(Entity entity);
        void Delete(int entityId);
        void Update(Entity entity);
    }
}