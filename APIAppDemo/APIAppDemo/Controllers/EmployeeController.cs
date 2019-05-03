using APIAppDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace APIAppDemo.Controllers
{
    public class EmployeeController : ApiController
    {
        private Employee[] emps = new Employee[] {

            new Employee{EmpId=101,EmpName="shailaja",EmpCell="98678",EmpEmail="shail@gmail.com", EmpDesig="Analyst"},
            new Employee{EmpId=102,EmpName="deepika",EmpCell="1234",EmpEmail="deep@gmail.com",EmpDesig="Analyst" },
            new Employee{EmpId=103,EmpName="bandyaa",EmpCell="87543",EmpEmail="bandyaa@gmail.com",EmpDesig="Analyst"},
            new Employee{EmpId=104,EmpName="akash",EmpCell="8173526",EmpEmail="akash@gmail.com",EmpDesig="Analyst"},
            new Employee{EmpId=105,EmpName="naati",EmpCell="97252",EmpEmail="naati@gmail.com",EmpDesig="Analyst"},
            new Employee{EmpId=106,EmpName="pittal-khaasi",EmpCell="826483",EmpEmail="khaasi@gmail.com",EmpDesig="Analyst"},
            new Employee{EmpId=107,EmpName="tushar",EmpCell="372648",EmpEmail="tushar@gmail.com",EmpDesig="Analyst"},

        };
        // GET: api/Employee
        [ResponseType(typeof(IEnumerable<Employee>))]
        public IEnumerable<Employee> Get()
        {
            return emps;
        }

        public IHttpActionResult Get(int ID)
        {
            var emp=emps.FirstOrDefault((p)=>p.EmpId == ID);
            if (emp == null)
            {
                return NotFound();
            }
            return Ok(emp);
        }

      

        // POST: api/Employee
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Employee/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Employee/5
        public void Delete(int id)
        {
        }
    }
}
