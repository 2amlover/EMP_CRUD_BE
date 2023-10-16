using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMPLOYEES_DETAILS_DATAOBJECTS
{
    public class tbl_employees_details
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Department { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string JobTitle { get; set; }
        public decimal Salary { get; set; }
        public int EmployeeId { get; set; }  
        public string Gender { get; set; }
        public DateTime HireDate { get; set; }
    }
 }
