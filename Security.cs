using System.Security.Cryptography;

public static class Security
{
    private const int SaltSize = 16;
    private const int KeySize = 32;
    private const int Iterations = 100_000;
    private static readonly HashAlgorithmName hashPass = HashAlgorithmName.SHA512;

    public static string Hash(string password)
    {
        byte[] salt = RandomNumberGenerator.GetBytes(SaltSize);
        byte[] hash = Rfc2898DeriveBytes.Pbkdf2(password, salt, Iterations, hashPass, KeySize);

        return $"{Convert.ToBase64String(salt)}.{Convert.ToBase64String(hash)}";
    }

    public static bool VerifyPassword(string password, string storedHash)
    {
        string[] parts = storedHash.Split('.');
        
        if (parts.Length != 2)
        {
            return false;
        }

        byte[] salt = Convert.FromBase64String(parts[0]);
        byte[] expectedHash = Convert.FromBase64String(parts[1]);

        byte[] actualHash = Rfc2898DeriveBytes.Pbkdf2(password, salt, Iterations, hashPass, KeySize);

        return CryptographicOperations.FixedTimeEquals(actualHash, expectedHash);
    }
}
