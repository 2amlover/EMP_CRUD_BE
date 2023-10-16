using EMPLOYEES_DETAILS_DATAOBJECTS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EMPLOYEES_DETAILS_DATACONTRACTS
{
    public class get_employee_detail_op
    {
        [DataMember]
        public tbl_employees_details m_employee { get; set; }
        public get_employee_detail_op()
        {
            m_employee = new tbl_employees_details();
        }
    }
}


