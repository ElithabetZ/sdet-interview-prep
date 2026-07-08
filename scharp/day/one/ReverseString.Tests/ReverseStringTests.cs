using NUnit.Framework;

namespace ReverseString.Tests
{
    public class Tests
    {
        [TestCase("Welcome", "emocleW")]
        [TestCase("Hello", "olleH")]
        [TestCase("123", "321")]
        [TestCase("aaaaaaaaaaaaaaaaaaaaa", "aaaaaaaaaaaaaaaaaaaaa")]
        [TestCase("", "")]
        public void HappyPath(string text, string reversedText)
        {
            Assert.That(ReverseString.ToReverse(text), Is.EqualTo(reversedText));
        }

        [Test]
        public void NullValue()
        {
            Assert.Throws<ArgumentNullException>(() => ReverseString.ToReverse(null));
        }

    }
}