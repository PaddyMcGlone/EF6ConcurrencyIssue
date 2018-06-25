using EF6Concurrency.Models;
using System;
using System.IO;
using System.Transactions;

namespace EF6Concurrency.Services
{
    public class ImportService
    {
        private Person PersonOfInterest;

        public void Execute()
        {
            // Create db context
            var context = new ApplicationDbContext();

            try
            {
                // Create transaction scope
                using (TransactionScope scope = new TransactionScope())
                {
                    // Read the contents of the file
                    string fileContents = File.ReadAllText(@"C:\Users\paddy\Documents\MyTestFile.txt");

                    // Populate an object with file contents
                    PersonOfInterest = new Person
                    {
                        FullName = fileContents.ToLower(),
                        Status   = "Done"
                    };

                    // Add object to EF tracking & save
                    context.Persons.Add(PersonOfInterest);

                    // Save changes 
                    context.SaveChanges();

                    // Raise some unknown issue
                    throw new Exception("Houston we have a problem.");

                    // Complete transaction - code never reaches here..
                    scope.Complete();
                }
            }
            // Catch the problem raised in the try
            catch (Exception)
            {
                // Change the record perviously saved
                PersonOfInterest.Status = "Failed";
                context.SaveChanges();
            }                        
        }
    }
}