using CSharpSpecFlowHealthcareExample.Domain;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace CSharpSpecFlowHealthcareExample.Bindings
{
    [Binding]
    public sealed class LoginSteps
    {
        private AuthenticationService _authenticationService = null!;
        private bool _loginSuccessful;

        [Given(
            @"^the authentication system contains username ""([^""]*)"" " +
            @"with password ""([^""]*)""$")]
        public void GivenTheAuthenticationSystemContainsUser(
            string username,
            string password)
        {
            _authenticationService =
                new AuthenticationService();

            _authenticationService.AddUser(
                username,
                password);
        }

        [When(
            @"^I log in with username ""([^""]*)"" " +
            @"and password ""([^""]*)""$")]
        public void WhenILogIn(
            string username,
            string password)
        {
            _loginSuccessful =
                _authenticationService.Login(
                    username,
                    password);
        }

        [Then(
            @"^the login result should be ""([^""]*)""$")]
        public void ThenTheLoginResultShouldBe(
            string expectedResult)
        {
            var expectedSuccessful =
                expectedResult switch
                {
                    "successful" => true,
                    "rejected" => false,

                    _ => throw new ArgumentException(
                        $"Unknown result: {expectedResult}")
                };

            Assert.That(
                _loginSuccessful,
                Is.EqualTo(expectedSuccessful));
        }
    }
}
