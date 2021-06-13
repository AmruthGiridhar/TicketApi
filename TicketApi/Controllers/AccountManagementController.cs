using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ticket.Service.TicketInterface;

namespace TicketApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountManagementController : ControllerBase
    {
        private IAccountService _accountInterface;
        public AccountManagementController(IAccountService accountInterface)
        {
            this._accountInterface = accountInterface;
        }

        [HttpGet("valite-user/{email}/{password}")]
        public IActionResult validateUser(string email,string password)
        {
            var user = _accountInterface.validateAccess(email, password);
            if(user != null)
            {
                return Ok(user);
            }
            else
            {
                return NotFound();
            }

        }
    }
}
