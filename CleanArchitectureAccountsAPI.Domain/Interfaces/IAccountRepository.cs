using CleanArchitectureAccountsAPI.Domain.Entities;
using CleanArchitectureAccountsAPI.Domain.Specifications;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureAccountsAPI.Domain.Interfaces
{
    public interface IAccountRepository
    {
        Task<Pagination<Account>> GetAllAccounts(AccountParams accountParams);
        Task<Account> GetAccountById(int id);
        Task<bool> UpdateAccountDetails(Account account);
    }
}
