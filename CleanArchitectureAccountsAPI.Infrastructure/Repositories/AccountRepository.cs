using CleanArchitectureAccountsAPI.Domain.Interfaces;
using CleanArchitectureAccountsAPI.Domain.Entities;
using CleanArchitectureAccountsAPI.Infrastructure.Data;
using CleanArchitectureAccountsAPI.Domain.Specifications;

namespace CleanArchitectureAccountsAPI.Infrastructure.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        //by passing database connectivity in this layer and using hard-coded data context.
        public async Task<Pagination<Account>> GetAllAccounts(AccountParams accountParams)
        {
            return await Task.Run(() =>
            {
                List<Account> accounts = AccountContext.SeedData();
                return new Pagination<Account>
                {
                    PageSize = accountParams.PageSize,
                    PageIndex = accountParams.PageIndex,
                    Data = accounts
                           .Skip(accountParams.PageSize * (accountParams.PageIndex - 1))
                           .Take(accountParams.PageSize)
                           .ToList(),
                    Count = accounts.Count
                };
            });
        }

        public async Task<Account> GetAccountById(int id)
        {
            return await Task.Run(() =>
            {
                List<Account> accounts = AccountContext.SeedData();
                return accounts.FirstOrDefault(a => a.Id.Equals(id));
            });
        }
        public async Task<bool> UpdateAccountDetails(Account account)
        {
            return await Task.Run(() =>
            {
                List<Account> accounts = AccountContext.SeedData();
                //dummy update which returns a success flag
                accounts.Where(a => a.Id == account.Id).ToList().ForEach(a => a.Name = account.Name);
                bool result = true;
                return result;
            });

        }
    }
}