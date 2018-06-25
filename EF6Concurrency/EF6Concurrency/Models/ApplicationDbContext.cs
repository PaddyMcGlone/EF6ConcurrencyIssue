using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace EF6Concurrency.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        #region Properties

        public DbSet<Person> Persons { get; set; }

        #endregion

        #region Constructor
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }
        #endregion

        #region Helper methods
        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
        #endregion
    }
}