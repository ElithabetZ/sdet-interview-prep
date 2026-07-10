using NUnit.Framework;

namespace Validation.Tests
{
    public class PasswordTests
    {

        [TestCase("12345678Aa!@")]
        [TestCase("1Aa,$2fshFHJKHJG&")]
        [TestCase("AAAAbdjdnkregrenk12563412653&%.,.,")]
        public void ValidatePasswordPositiveTests(String password)
        {
            Assert.That(Password.ValidatePassword(password), Is.True);
        }

        [TestCase("")]
        [TestCase("!1Aa&")]
        [TestCase("Ajfbwkjefbewlkjfke1321431")]
        [TestCase("!@#$%^%&&")]
        [TestCase("122466678799")]
        [TestCase("1Aaaaaaa!@,. ")]
        [TestCase("A")]
        [TestCase("1234ADFGgdshdjf")]
        [TestCase(null)]
        public void ValidatePasswordNegativeTests(String password)
        {
            Assert.That(Password.ValidatePassword(password), Is.False);
        }
    }
}