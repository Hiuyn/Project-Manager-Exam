namespace PMSystem.Domain.Constants
{
    public class AuthorizationConstants
    {
        public const string AUTH_KEY = "AuthKeyOfDoomThatMustBeAMinimumNumberOfBytes";

        // TODO: Don't use this in production
        public const string DEFAULT_PASSWORD = "5432";

        // TODO: Change this to an environment variable
        public const string JWT_SECRET_KEY = "SecretKeyOfDoomThatMustBeAMinimumNumberOfBytes";
    }
}
