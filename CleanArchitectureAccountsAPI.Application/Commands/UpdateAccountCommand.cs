using CleanArchitectureAccountsAPI.Domain.Entities;
using MediatR;

namespace CleanArchitectureAccountsAPI.Application.Commands;

public class UpdateAccountCommand : IRequest<bool>
{
    public int Id { get; set; }
    public long AccountNumber { get; set; }
    public string SortCode { get; set; }
    public string Name { get; set; }
    public string EmailAddress { get; set; }
    public string AddressLine { get; set; }
    public string Country { get; set; }
    public string State { get; set; }
    public string ZipCode { get; set; }
    public AccountType AccountType { get; set; }
    public decimal Balance { get; set; }
}