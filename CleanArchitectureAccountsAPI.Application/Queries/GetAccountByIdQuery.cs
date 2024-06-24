using CleanArchitectureAccountsAPI.Application.Responses;
using MediatR;

namespace CleanArchitectureAccountsAPI.Application.Queries;

public class GetAccountByIdQuery: IRequest<AccountResponse>
{
    public string Id { get; set; }

    public GetAccountByIdQuery(string id)
    {
        Id = id;
    }
}