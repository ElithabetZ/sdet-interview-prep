using NUnit.Framework;

namespace TextFunctions.Tests
{
    public class Tests
    {
        public static IEnumerable<TestCaseData> CountCharactersEmptyTestCases()
        {
            yield return new TestCaseData(
                "",

                new Dictionary<char, int>
            {
                { 'a', 0 },
                { 'e', 0 },
                { 'i', 0 },
                { 'o', 0 },
                { 'u', 0 }
            }
                );

            yield return new TestCaseData(
                "bcfgdrt",

                new Dictionary<char, int>
            {
                { 'a', 0 },
                { 'e', 0 },
                { 'i', 0 },
                { 'o', 0 },
                { 'u', 0 }
            }
                );

            yield return new TestCaseData(
                "!234566$%#@",

                new Dictionary<char, int>
            {
                { 'a', 0 },
                { 'e', 0 },
                { 'i', 0 },
                { 'o', 0 },
                { 'u', 0 }
            }
                );
        }
        public static IEnumerable<TestCaseData> CountCharactersHappyPathTestCases()
        {
            yield return new TestCaseData(
                "Hello my dear friend!",

                new Dictionary<char, int>
            {
                { 'a', 1 },
                { 'e', 3 },
                { 'i', 1 },
                { 'o', 1 },
                { 'u', 0 }
            }
                );

            yield return new TestCaseData(
                "Amazing! How Exciting!",

                new Dictionary<char, int>
            {
                { 'a', 2 },
                { 'e', 1 },
                { 'i', 3 },
                { 'o', 1 },
                { 'u', 0 }
            }
                );

            yield return new TestCaseData(
                "UnoBunoQwa",

                new Dictionary<char, int>
            {
                { 'a', 1 },
                { 'e', 0 },
                { 'i', 0 },
                { 'o', 2 },
                { 'u', 2 }
            }
                );
        }

        [TestCaseSource(nameof(CountCharactersHappyPathTestCases))]
        [TestCaseSource(nameof(CountCharactersEmptyTestCases))]
        public void CountVowels_HappyPath(String message, Dictionary<char, int> expectedVowelsCount)
        {
            Assert.That(Functions.CountVowels(message), Is.EqualTo(expectedVowelsCount));
        }

        [Test]
        public void CountVowels_Null()
        {
            Assert.Throws<ArgumentNullException>(() => Functions.CountVowels(null));
        }


        [TestCase("'")]
        [TestCase("")]
        [TestCase("'")]
        [TestCase("\n")]
        [TestCase(" ")]
        [TestCase("'' \"\"")]
        public void CountCharacters_EmptyCases(String message)
        {
            Assert.That(Functions.CountCharacters(message), Is.EqualTo(0));
        }

        [Test]
        public void CountCharacters_Null()
        {
            Assert.Throws<ArgumentNullException>(() => Functions.CountCharacters(null));
        }

        [TestCase("madam", 5)]
        [TestCase("Hello", 5)]
        [TestCase("Hello,Mike", 10)]
        [TestCase("Hello, Mike", 10)]
        [TestCase("123", 3)]
        [TestCase("1", 1)]
        [TestCase("1 1", 2)]
        [TestCase("Hi!", 3)]
        [TestCase("!@#$", 4)]
        public void CountCharacters_HappyPath(String message, int charactersCountExpected)
        {
            Assert.That(Functions.CountCharacters(message), Is.EqualTo(charactersCountExpected));
        }

        [TestCase("madam",true)]
        [TestCase("Madam", false)]
        [TestCase("anna", true)]
        [TestCase("hello everyone", false)]
        [TestCase("121", true)]
        [TestCase("000000", true)]
        [TestCase("aaaaaaaaaa", true)]
        [TestCase("35647", false)]
        [TestCase("madam anna", false)]
        public void IsPalindrome_HappyPath(String message, Boolean isPalindromeExpected)
        {
            Assert.That(Functions.IsPalindrome(message), Is.EqualTo(isPalindromeExpected));
        }

        [Test]
        public void IsPalindrome_Null()
        {
            Assert.Throws<ArgumentNullException>(()=>Functions.IsPalindrome(null));
        }

        [TestCase("a")]
        [TestCase("")]
        [TestCase("1")]
        [TestCase("'")]
        [TestCase("&")]
        public void IsPalindrome_LessThenTwo(String message)
        {
            Assert.That(Functions.IsPalindrome(message), Is.EqualTo(false));
        }
    }
}