using EMPLOYEES_DETAILS_DATAOBJECTS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EMPLOYEES_DETAILS_DATACONTRACTS
{
    public class get_employee_details_list_op
    {
        public List<tbl_employees_details> ml_employees { get; set; }
        public get_employee_details_list_op()
        {
            ml_employees = new List<tbl_employees_details>();
        }
    }
}
