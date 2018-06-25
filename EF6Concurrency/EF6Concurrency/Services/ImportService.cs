using EF6Concurrency.Models;
using System.IO;
using System.Transactions;

namespace EF6Concurrency.Services
{
    public class ImportService
    {
        public void Execute()
        {
            // Create db context
            var context = new ApplicationDbContext();

            // Create transaction scope
            using (TransactionScope scope = new TransactionScope())
            {
                string fileContents = File.ReadAllText(@"C:\Users\paddy\Documents.txt");

                var person = new Person
                {

                };
            }

            
        }
    }
}