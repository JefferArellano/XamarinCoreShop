namespace VirtualShop.Web.Helpers
{
    using Microsoft.AspNetCore.Identity;
    using System.Threading.Tasks;
    using Data.Entities;
    using Models;

    public interface IUserHelper
    {
        Task<User> GetUserByEmailAsync(string email);

        Task<IdentityResult> AddUserAsync(User user, string password);

        Task<SignInResult> LoginAsync(LoginViewModel model);

        Task LogoutAsync();
    }
}
