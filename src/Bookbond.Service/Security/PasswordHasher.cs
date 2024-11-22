namespace Bookbond.Service.Security;

public static class PasswordHasher
{
    public static (string Hash, string Salt) Hash(string password)
    {
       var salt = GenerateSalt();
        var passwordHash = BCrypt.Net.BCrypt.HashPassword(password, salt);

        return (Hash: passwordHash, Salt: salt);
    }

    public static bool Verify(string password, string passwordHash, string salt)
    {
        return BCrypt.Net.BCrypt.Verify(password, passwordHash);
    }

    private static string GenerateSalt()
    {
        return Guid.NewGuid().ToString();
    }
}
