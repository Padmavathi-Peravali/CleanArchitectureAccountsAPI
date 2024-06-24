using CleanArchitectureAccountsAPI.Application.Mappers;
using CleanArchitectureAccountsAPI.Application.Queries;
using CleanArchitectureAccountsAPI.Application.Responses;
using CleanArchitectureAccountsAPI.Domain.Interfaces;
using CleanArchitectureAccountsAPI.Domain.Specifications;
using MediatR;

namespace Catalog.Application.Handlers;

public class GetAllAccountsHandler: IRequestHandler<GetAllAccountsQuery, Pagination<AccountResponse>>
{
    private readonly IAccountRepository _accountRepository;

    public GetAllAccountsHandler(IAccountRepository accountRepository)
    {
        _accountRepository = accountRepository;
    }
    public async Task<Pagination<AccountResponse>> Handle(GetAllAccountsQuery request, CancellationToken cancellationToken)
    {
        var accountList = await _accountRepository.GetAllAccounts(request.AccountParams);
        var accountResponseList = AccountMapper.Mapper.Map<Pagination<AccountResponse>>(accountList);
        return accountResponseList;
    }
}