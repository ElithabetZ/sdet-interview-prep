namespace Validation
{
    public class Password
    {
        public static bool ValidatePassword(string password)
        {
            return !string.IsNullOrEmpty(password) 
                && password.Length >= 8
                && !(password.Any(char.IsWhiteSpace)) 
                && password.Any(char.IsDigit)
                && password.Any(char.IsUpper) 
                && password.Any(char.IsLower)
                && password.Any(ps => char.IsPunctuation(ps) || char.IsSymbol(ps));
        }
    }
}
