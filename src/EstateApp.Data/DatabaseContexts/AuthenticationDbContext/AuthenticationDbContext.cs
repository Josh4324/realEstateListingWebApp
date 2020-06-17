using System.Net.Mime;
using EstateApp.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EstateApp.Data.DatabaseContexts.Authentication
{
    public class AuthenticationDbContext : IdentityDbContext<ApplicationUser> 
    {

        public AuthenticationDbContext(DbContextOptions<AuthenticationDbContext> options)
            : base(options)
            {

            }
    }
}