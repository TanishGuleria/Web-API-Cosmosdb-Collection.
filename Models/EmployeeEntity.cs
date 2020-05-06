using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiWithCosmosDBCollection.Models
{
    public class EmployeeEntity
    {
     
        public string EmployeeName { get; set; }
        public string JobTitle { get; set; }


        public EmployeeEntity()
        {

        }
        public EmployeeEntity(Employee e)
        {
            
            this.EmployeeName = e.EmployeeName;
            this.JobTitle = e.JobTitle;
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }

}
