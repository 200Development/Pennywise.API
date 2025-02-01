namespace Pennywise.API.Services
{
    public static class HashService
    {
        /// <summary>
        /// Generates a hash of the provided password using BCrypt.
        /// </summary>
        /// <param name="password">The plain-text password to hash.</param>
        /// <returns>A hashed version of the provided password.</returns>
        public static string HashPassword(string password)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Verifies if a plain-text password matches a given BCrypt hashed password.
        /// </summary>
        /// <param name="password">The plain-text password to verify.</param>
        /// <param name="hashedPassword">The BCrypt hashed password to compare against.</param>
        /// <returns>True if the password and hashed password match, otherwise false.</returns>
        public static bool VerifyPassword(string password, string hashedPassword)
        {
            throw new NotSupportedException();
        }
    }
}
