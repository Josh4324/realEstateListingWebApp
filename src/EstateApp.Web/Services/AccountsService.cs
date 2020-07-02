using System.Text;
using System;
using System.Threading.Tasks;
using EstateApp.Data.Entities;
using EstateApp.Web.Interfaces;
using EstateApp.Web.Models;
using Microsoft.AspNetCore.Identity;

namespace EstateApp.Web.Services
{
    public class AccountsService : IAccountsService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        public AccountsService(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        
        public async Task<ApplicationUser> CreateUserAsync(RegisterModel model)
        {
            if(model is null) throw new ArgumentNullException(message: "Invald details provided", null);
            var user = new ApplicationUser
            {
                UserName = model.Email,
                Email = model.Email,
                Fullname = model.FullName,
            };

            var result = await _userManager.CreateAsync(user, model.Password);
            if (!result.Succeeded)
            {
                throw new InvalidOperationException(message: AddErrors(result), null);
            }
            return user;
        }

        private string AddErrors(IdentityResult result)
        {   StringBuilder sb = new StringBuilder();
            foreach(var error in result.Errors)
            {
                sb.Append(error.Description + " ");
            }
            return sb.ToString();
        }
    }
}