using NUnit.Framework;
using static System.Net.Mime.MediaTypeNames;

namespace ReverseString.Tests
{
    public class Tests
    {
        [TestCase("Welcome", "emocleW")]
        [TestCase("Hello", "olleH")]
        [TestCase("123", "321")]
        [TestCase("aaaaaaaaaaaaaaaaaaaaa", "aaaaaaaaaaaaaaaaaaaaa")]
        public void HappyPath(string text, string reversedText)
        {
            Assert.That(ReverseString.ToReverse(text), Is.EqualTo(reversedText));
        }

        [Test]
        public void EmptyValue()
        {
            String text = "";
            String reversedText = "";
            Assert.That(ReverseString.ToReverse(text), Is.EqualTo(reversedText));
        }

    }
}