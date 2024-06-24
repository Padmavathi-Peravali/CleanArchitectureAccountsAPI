using System.Text.Json;
using CleanArchitectureAccountsAPI.Domain.Entities;

namespace CleanArchitectureAccountsAPI.Infrastructure.Data;

public static class AccountContext
{
    public static List<Account> SeedData()
    {
        //string path = Path.Combine("Data", "SeedData", "accounts.json");
        //var accountsData = File.ReadAllText(path);
        var accounts = new List<Account>()
        {
            new Account(1,55801512609,"25-20-22","David","David@virtusa.com","Roden street,London","UK", "England","2Z12ZP",new AccountType(1,"Current"),10000),
            new Account(2,55801512608,"25-20-21","Ian","Ian@virtusa.com","Blegrave Lane, London","UK", "England","2Z12ZP",new AccountType(1,"Savings"),2000),
            new Account(3,55801512607,"25-20-20","Declan","Declan@virtusa.com","Liverpool Street, London","UK", "England","2Z12ZP",new AccountType(1,"Current"),3000),
        };
        return accounts;
    } 
}