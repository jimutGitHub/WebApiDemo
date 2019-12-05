using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SampleDataAccess;

namespace WebApiDemo.Controllers
{
    public class EmployeesController : ApiController
    {
        public IEnumerable<Employee> Get()
        {
            using(SampleDBEntities dbEntities = new SampleDBEntities())
            {
                return dbEntities.Employees.ToList();
            }
        }

        public Employee Get(int id)
        {
            using (SampleDBEntities dbEntities = new SampleDBEntities())
            {
                return dbEntities.Employees.FirstOrDefault(x => x.Id == id);
            }
        }
    }
}
