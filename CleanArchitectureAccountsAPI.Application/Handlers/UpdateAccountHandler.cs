using CleanArchitectureAccountsAPI.Application.Commands;
using CleanArchitectureAccountsAPI.Domain.Entities;
using CleanArchitectureAccountsAPI.Domain.Interfaces;
using MediatR;

namespace CleanArchitectureAccountsAPI.Application.Handlers;

public class UpdateAccountHandler : IRequestHandler<UpdateAccountCommand, bool>
{
    private readonly IAccountRepository _accountRepository;

    public UpdateAccountHandler(IAccountRepository accountRepository)
    {
        _accountRepository = accountRepository;
    }
    public async Task<bool> Handle(UpdateAccountCommand request, CancellationToken cancellationToken)
    {
        var account = await _accountRepository.UpdateAccountDetails(new Account
        (request.Id, request.AccountNumber, request.SortCode, request.Name, request.EmailAddress
        , request.AddressLine, request.Country, request.State, request.ZipCode, request.AccountType, request.Balance));
           
        return account;
    }
}