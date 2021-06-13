using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket.BusinessModel.BusinessModel
{
   public class EmployeeValidate
    {
        public string  employeeEmail { get; set; }
        public string employeePassword { get; set; }
    }
    public class employeeValidateAccess //return type
    {
        public int? employeeId { get; set; }
        public bool? employeeAccess { get; set; } //true is valid
        public int? employeeRole { get; set; }
    }

}
