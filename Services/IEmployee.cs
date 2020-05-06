using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiWithCosmosDBCollection.Models;

namespace WebApiWithCosmosDBCollection.Services
{
  public  interface IEmployee
    {
        IEnumerable<EmployeeEntity> get();
        void add(Employee e);
    }
}
