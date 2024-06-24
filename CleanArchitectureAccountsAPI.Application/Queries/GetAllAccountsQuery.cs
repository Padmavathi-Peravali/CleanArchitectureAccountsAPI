using CleanArchitectureAccountsAPI.Application.Responses;
using CleanArchitectureAccountsAPI.Domain.Specifications;
using MediatR;

namespace CleanArchitectureAccountsAPI.Application.Queries;

public class GetAllAccountsQuery : IRequest<Pagination<AccountResponse>>
{
    public AccountParams AccountParams { get; set; }

    public GetAllAccountsQuery(AccountParams accountParams)
    {
        AccountParams = accountParams;
    }
}