using Microsoft.AspNetCore.Mvc;
using System.Data;
using EMPLOYEES_DETAILS_DATACONTRACTS;
using EMPLOYEES_DETAILS_DATAOBJECTS;
using EMPLOYEES_DETAILS_BL;

namespace EMPLOYEES_DETAILS_WEBAPI.Controllers

{

    [Route("[controller]")]
    [ApiController]

    public class DashboardController : ControllerBase
    {

        private readonly IConfiguration Configuration;

        public DashboardController(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        [HttpGet]
        [Route("get_EmployeesList")]
        public JsonResult get_Employees_List()
        {
            String connectionString = Configuration["DBConnection"];

            get_employee_details_list_ip ip = new get_employee_details_list_ip();
            get_employee_details_list_op op = new get_employee_details_list_op();

            employees_details_bl bl = new employees_details_bl();

            bl.get_Employees_List(ref ip, ref op, connectionString);

            return new JsonResult(op);
        }



        [HttpGet]
        [Route("get_Employee_Detail")]
        public JsonResult get_Employee_Detail(String Id)
        {
            String connectionString = Configuration["DBConnection"];

            get_employee_detail_ip ip = new get_employee_detail_ip();
            ip.m_ID = Convert.ToInt64(Id);
            get_employee_detail_op op = new get_employee_detail_op();

            employees_details_bl bl = new employees_details_bl();

            bl.get_Employees_Detail(ref ip, ref op, connectionString);

            return new JsonResult(op);
        }


        [HttpPost]
        [Route("post_Employee_Details")]
        public JsonResult post_Employees_Details(post_employee_detail_ip ip)
        {
            String connectionString = Configuration["DBConnection"];
            post_employee_detail_op op = new post_employee_detail_op();

            employees_details_bl bl = new employees_details_bl();

            bl.post_Employees_Details(ref ip, ref op, connectionString);
            return new JsonResult(op);
        }
        [HttpPut]
        [Route("put_Employee_Details")]
        public JsonResult put_Employees_Details(put_employee_detail_ip ip)
        {
            String connectionString = Configuration["DBConnection"];
            put_employee_detail_op op = new put_employee_detail_op();

            employees_details_bl bl = new employees_details_bl();

            bl.put_Employees_Details(ref ip, ref op, connectionString);
            return new JsonResult(op);
        }

        [HttpDelete]
        [Route("delete_employee")]
        public JsonResult delete_EmployeeDetails(String Id)
        {
            String connectionString = Configuration["DBConnection"];
            delete_employee_detail_ip ip = new delete_employee_detail_ip();
            ip.m_ID = Convert.ToInt64(Id);
            delete_employee_detail_op op = new delete_employee_detail_op();

            employees_details_bl bl = new employees_details_bl();

            bl.delete_EmployeeDetails(ref ip, ref op, connectionString);
            return new JsonResult(op);
        }



    }
}