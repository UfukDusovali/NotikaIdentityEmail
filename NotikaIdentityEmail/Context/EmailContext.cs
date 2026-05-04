using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace NotikaIdentityEmail.Context
{
    public class EmailContext:IdentityDbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;initial Catalog=NotikaMailDB;integrated security=true;trust server certificate=true;");
        }
    }
}
