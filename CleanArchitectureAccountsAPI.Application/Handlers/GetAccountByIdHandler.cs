using CleanArchitectureAccountsAPI.Application.Mappers;
using CleanArchitectureAccountsAPI.Application.Queries;
using CleanArchitectureAccountsAPI.Application.Responses;
using CleanArchitectureAccountsAPI.Domain.Interfaces;
using MediatR;

namespace CleanArchitectureAccountsAPI.Application.Handlers;

public class GetAccountByIdHandler : IRequestHandler<GetAccountByIdQuery, AccountResponse>
{
    private readonly IAccountRepository _accountRepository;

    public GetAccountByIdHandler(IAccountRepository accountRepository)
    {
        _accountRepository = accountRepository;
    }
    public async Task<AccountResponse> Handle(GetAccountByIdQuery request, CancellationToken cancellationToken)
    {
        var account = await _accountRepository.GetAccountById(Convert.ToInt32(request.Id));
        var accountResponse = AccountMapper.Mapper.Map<AccountResponse>(account);
        return accountResponse;
    }
}