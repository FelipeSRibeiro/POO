using agenciaBancaria.Domain.Entities;

namespace agenciaBancaria.Domain.Interfaces
{
    public interface IAccountRepository
    {
        void Delete(int idDeleteAccount);
        void Save(Account account, string idAccount);

        public interface IAccountRepository: IBaseAccountRepository<Account>
        {
            
        }
    }
}