using Microsoft.EntityFrameworkCore;
using USAPrimeAPI.BusinessModels;

namespace USAPrimeAPI.Context
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using USAPrimeAPI.BusinessModels;
    public class ApplicationContext : IdentityDbContext<ApplicationUser>
    {

        public ApplicationContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Years> T_Years { get; set; }



    }
}
