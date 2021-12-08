using Login.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Login.Services.Command
{
    public class UserCommandService
    {

        private readonly UserContext _userContext;

        public UserCommandService(UserContext userContext)
        {
            _userContext = userContext;
        }

        public async Task<ActionResult<User>> CreateUser(User user)
        {
            _userContext.Users.Add(user);
            await _userContext.SaveChangesAsync();

           return user;
        }
    }
}
