using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace CleanArchitectureAccountsAPI.Domain.Entities
{
    public class Account
    {
        //Specifies a unique Id for the account
        public int Id { get; set; }

        //Specifies the bank's account number
        public long AccountNumber { get; set; }

        //Specifies the sort code for the account
        public string? SortCode { get; set; }

        //Specifies the name of the account holder
        public string? Name { get; set; }

        //Specifies an email address of the account holder
        public string? EmailAddress { get; set; }

        //Specifies an address of the account holder
        public string? AddressLine { get; set; }

        //Specifies country of the account holder 
        public string? Country { get; set; }

        //Specifies state of the account holder 
        public string? State { get; set; }

        //Specifies the zipcode of the account holder 
        public string? ZipCode { get; set; }

        //Specifies the type of bank account
        public AccountType AccountType { get; set; }

        //Specifies the account balance
        public decimal Balance { get; set; }

        public Account(int id, long accountNumber, string sortCode, string name, string emailAddress, string addressLine, string country, string state, string zipCode, AccountType accountType, decimal balance)
        {
            Id = id;
            AccountNumber = accountNumber;
            SortCode = sortCode;
            Name = name;
            EmailAddress = emailAddress;
            AddressLine = addressLine;
            Country = country;
            State = state;
            ZipCode = zipCode;
            AccountType = accountType;
            Balance = balance;
        }
    }
}
