using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticket.BusinessModel.BusinessModel;

namespace Ticket.Service.TicketInterface
{
   public interface IAccountService
    {
        employeeValidateAccess validateAccess(string email, string password);
    }
}
