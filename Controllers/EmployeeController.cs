using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiWithCosmosDBCollection.Services;
using WebApiWithCosmosDBCollection.Models;
namespace WebApiWithCosmosDBCollection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        IEmployee employeeRepository = new EmployeeRepositorycs();
        [HttpGet]
        public  IEnumerable<EmployeeEntity> Get()
        {

            return employeeRepository.get();
          
           
        }

        // POST: api/Employee
        [HttpPost]
        public void Post([FromBody] Employee e)
        {
            employeeRepository.add(e);
        }

    }
}
