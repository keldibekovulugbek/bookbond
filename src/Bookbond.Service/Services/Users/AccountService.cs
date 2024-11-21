
using Bookbond.DataAccess.Interfaces;
using Bookbond.Service.DTOs.Accounts;
using Bookbond.Service.Interfaces.Users;

namespace Bookbond.Service.Services.Users;

public class AccountService : IAccountService
{
    private readonly IUnitOfWork _unitOfWork;

    public AccountService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public Task<string> LogInAsync(AccountLoginDTO accountLogin)
    {
        throw new NotImplementedException();
    }

    public Task<bool> RegisterAsync(AccountCreateDTO accountCreate)
    {
        throw new NotImplementedException();
    }

    public Task SendCodeAsync(string email)
    {
        throw new NotImplementedException();
    }

    public Task<bool> VerifyEmailAsync(AccountEmailVerifyDTO verifyEmail)
    {
        throw new NotImplementedException();
    }
}
