using CleanArchitectureAccountsAPI.Application.Responses;
using CleanArchitectureAccountsAPI.Application.Queries;
using CleanArchitectureAccountsAPI.Application.Commands;
using CleanArchitectureAccountsAPI.Domain.Specifications;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace CleanArchitectureAccountsAPI.Controllers
{
    public class AccountController : ApiController
    {
        private readonly IMediator _mediator;
        private readonly ILogger<AccountController> _logger;

        public AccountController(IMediator mediator, ILogger<AccountController> logger)
        {
            _mediator = mediator;
            _logger = logger;
            _logger.LogInformation("Test - from account controller");
        }

        [HttpGet]
        [Route("[action]/{id}", Name = "GetAccountById")]
        [ProducesResponseType(typeof(AccountResponse), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<ActionResult<AccountResponse>> GetAccountById(string id)
        {
            try
            {
                var query = new GetAccountByIdQuery(id);
                var result = await _mediator.Send(query);
                _logger.LogInformation("Requested account is fetched");
                return Ok(result);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An Exception has occured.");
                throw;
            }
        }

        [HttpGet]
        [Route("GetAllAccounts")]
        [ProducesResponseType(typeof(IList<AccountResponse>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<IList<AccountResponse>>> GetAllAccounts([FromQuery] AccountParams accountParams)
        {
            try
            {
                var query = new GetAllAccountsQuery(accountParams);
                var result = await _mediator.Send(query);
                _logger.LogInformation("All accounts retrieved");
                return Ok(result);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An Exception has occured.");
                throw;
            }
        }

        [HttpPut]
        [Route("UpdateAccount")]
        [ProducesResponseType(typeof(bool), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> UpdateAccount([FromBody] UpdateAccountCommand accountCommand)
        {
            try
            {
                var result = await _mediator.Send(accountCommand);
                return Ok(result);
            }
            catch (Exception e) 
            {
                _logger.LogError(e, "An Exception has occured.");
                throw;
            }

        }
    }
}
