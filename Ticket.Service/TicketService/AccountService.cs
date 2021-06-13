using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticket.BusinessModel.BusinessModel;
using Ticket.Service.TicketInterface;

namespace Ticket.Service.TicketService
{
  public  class AccountService : IAccountService
    {
        private IConnectionFactory _connectionFactory;
        public AccountService(IConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

        public employeeValidateAccess validateAccess(string email,string password)
        {
            employeeValidateAccess employeeValidatedDetails = new employeeValidateAccess();
            var procName = "validateUser";
            var param = new DynamicParameters();
            param.Add("@email", email);
            param.Add("@password", password);

            employeeValidatedDetails = SqlMapper.QueryFirstOrDefault<employeeValidateAccess>(_connectionFactory.GetConnection, procName, param, commandType: CommandType.StoredProcedure);
            return employeeValidatedDetails;
        }
    }
}
