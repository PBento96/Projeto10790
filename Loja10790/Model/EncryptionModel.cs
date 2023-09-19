namespace Loja10790.Model
{
    using BCrypt.Net;

    namespace Loja10790.Model
    {
        internal class EncryptionModel
        {
            public static string HashPassword(string password)
            {
                return BCrypt.HashPassword(password, BCrypt.GenerateSalt());
            }

            public static bool VerifyPassword(string enteredPassword, string storedHash)
            {
                return BCrypt.Verify(enteredPassword, storedHash);
            }
        }
    }

}
