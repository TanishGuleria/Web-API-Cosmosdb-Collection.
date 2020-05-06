using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Azure.Documents.Client;
using Microsoft.Azure.Documents;
using WebApiWithCosmosDBCollection.Models;

namespace WebApiWithCosmosDBCollection.Services
{
    public class EmployeeRepositorycs : IEmployee
    {


        static string DatabaseName = "maindb";
        static string CollectionName = "employee";
        static DocumentClient dc;

        static string endpoint = "https://employeecosmosdbtest.documents.azure.com:443/";
        static string key = "TBvoCKM8icUTyjtD3XWlJE1hQGhNEUxYP6OVmHb7a3FjpgJ8NCw5EGP2e7BRz0IpgzGzPxsJmEfRJa3KQ2Cvuw==";
        public IEnumerable<EmployeeEntity> get()
        {

           
            dc = new DocumentClient(new Uri(endpoint), key);
            
            FeedOptions queryOption = new FeedOptions { MaxItemCount = -1, EnableCrossPartitionQuery = true };
        
            IQueryable<EmployeeEntity> query = dc.CreateDocumentQuery<EmployeeEntity>(UriFactory.CreateDocumentCollectionUri(DatabaseName, CollectionName), queryOption);
            return query;
            
        }

        public void add(Employee e)
        {
            dc = new DocumentClient(new Uri(endpoint), key);
            EmployeeEntity et = new EmployeeEntity(e);

            var result = dc.CreateDocumentAsync(UriFactory.CreateDocumentCollectionUri(DatabaseName, CollectionName), et).GetAwaiter().GetResult();
        }
    }
}
