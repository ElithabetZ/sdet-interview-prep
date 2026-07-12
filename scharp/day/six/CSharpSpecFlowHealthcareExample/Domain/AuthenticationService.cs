
namespace CSharpSpecFlowHealthcareExample.Domain
{
    public sealed class AuthenticationService
    {
        private readonly Dictionary<string, string> _users =
        new(StringComparer.OrdinalIgnoreCase);

        public void AddUser(
            string username,
            string password)
        {
            _users[username] = password;
        }

        public bool Login(
            string username,
            string password)
        {
            return _users.TryGetValue(
                       username,
                       out var savedPassword)
                   && savedPassword == password;
        }
    }
}
