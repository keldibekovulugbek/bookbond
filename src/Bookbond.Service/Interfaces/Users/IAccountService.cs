
using Bookbond.Service.DTOs.Accounts;

namespace Bookbond.Service.Interfaces.Users
{
    public interface IAccountService
    {
        Task<string> LogInAsync(AccountLoginDTO accountLogin);

        Task<bool> RegisterAsync(AccountCreateDTO accountCreate);

        Task<bool> VerifyEmailAsync(AccountEmailVerifyDTO verifyEmail);

        Task SendCodeAsync(string email);

       // Task<bool> VerifyPasswordAsync(UserResetPasswordDTO userResetPassword);

    }
}
