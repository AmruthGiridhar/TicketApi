using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketApi.ViewModel
{
    public class AccountViewModel
    {
        public class employeeValidateAccessViewModel //return type
        {
            public int? employeeId { get; set; }
            public bool? employeeAccess { get; set; } //true is valid
            public int? employeeRole { get; set; }
        }

    }
}
