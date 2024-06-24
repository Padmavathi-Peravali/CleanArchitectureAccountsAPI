using CleanArchitectureAccountsAPI.Application.Responses;
using CleanArchitectureAccountsAPI.Domain.Entities;
using CleanArchitectureAccountsAPI.Domain.Specifications;
using AutoMapper;

namespace CleanArchitectureAccountsAPI.Application.Mappers;

public class AccountMappingProfile : Profile
{
    public AccountMappingProfile()
    {
        CreateMap<Account, AccountResponse>().ReverseMap();
        CreateMap<Pagination<Account>, Pagination<AccountResponse>>().ReverseMap();
    }
}