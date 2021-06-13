using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket.Service
{
    public interface IConnectionFactory
    {
        IDbConnection GetConnection { get; }
        string getConnectionString();
    }
}
