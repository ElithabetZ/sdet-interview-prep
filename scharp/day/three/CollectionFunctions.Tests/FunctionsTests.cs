using NUnit.Framework;

namespace CollectionFunctions.Tests
{
    public class Tests
    {
        public static IEnumerable<TestCaseData> FindDuplicatesHappyPathTestCases()
        {
            yield return new TestCaseData(
                new int[] {1,2,3,1,2,3},
                new List<int> { 1,2,3}
                );
            yield return new TestCaseData(
                new int[] { 1,1,1,1,1,1},
                new List<int> { 1}
                );
            yield return new TestCaseData(
                new int[] { 1,1,1,1,1,1,2,3},
                new List<int> { 1 }
                );
            yield return new TestCaseData(
                new int[] { 1,1,1,1,1,1,2,2},
                new List<int> { 1, 2}
                );
            yield return new TestCaseData(
                new int[] { 1,2,3,4,5,6,7,8,9,0,1},
                new List<int> { 1}
                );
        }

        public static IEnumerable<TestCaseData> FindDuplicatesNegativeTestCases()
        {
            yield return new TestCaseData(
                new int[] { 1, 2, 3},
                new List<int> {}
                );
            yield return new TestCaseData(
                new int[] {},
                new List<int> {}
                );
            yield return new TestCaseData(
                new int[] { 1, 10, 111, 1111},
                new List<int> {}
                );
            yield return new TestCaseData(
                new int[] {0},
                new List<int> {}
                );
            yield return new TestCaseData(
                new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0},
                new List<int> {}
                );
        }

        [TestCaseSource(nameof(FindDuplicatesHappyPathTestCases))]
        [TestCaseSource(nameof(FindDuplicatesNegativeTestCases))]
        public void FindDuplicatesTests(int[] nums, List<int> expected)
        {
            Assert.That(Functions.FindDuplicates(nums), Is.EqualTo(expected));
        }

        [Test]
        public void FindDuplicates_NullTest()
        {
            Assert.Throws<ArgumentNullException>(() => Functions.FindDuplicates(null));
        }


        public static IEnumerable<TestCaseData> RemoveDuplicatesHappyPathTestCases()
        {
            yield return new TestCaseData(
                new int[] {1,2,3,4,5,6,7,8,9,0,1,2,3,4,5,6,7,8,9,0},
                new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 }
                );
            yield return new TestCaseData(
                new int[] { 1,2,1,1,1,1,1,1,1,1,1,1},
                new List<int> { 1, 2 }
                );
            yield return new TestCaseData(
                new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 },
                new List<int> { 1 }
                );
            yield return new TestCaseData(
                new int[] { 1,2,2,2,3,3,3,3,3,3,3,3},
                new List<int> { 1, 2, 3 }
                );
            yield return new TestCaseData(
                new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 },
                new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 }
                );
            yield return new TestCaseData(
                new int[] { 1 },
                new List<int> { 1 }
                );
        }

        public static IEnumerable<TestCaseData> RemoveDuplicatesNegativeTestCases()
        {
            yield return new TestCaseData(
                new int[] {},
                new List<int> {}
                );
        }

        [TestCaseSource(nameof(RemoveDuplicatesHappyPathTestCases))]
        [TestCaseSource(nameof(RemoveDuplicatesNegativeTestCases))]
        public void RemoveDuplicatesTests(int[] nums, List<int> expected)
        {
            Assert.That(Functions.RemoveDuplicates(nums), Is.EqualTo(expected));
        }

        [Test]
        public void RemoveDuplicates_NullTest()
        {
            Assert.Throws<ArgumentNullException>(() => Functions.RemoveDuplicates(null));
        }

        public static IEnumerable<TestCaseData> FirstNonRepeatingCharacterHappyPathTestCases()
        {
            yield return new TestCaseData(
                "swiss",
                'w'
                );
            yield return new TestCaseData(
                "Aa",
                'A'
                );
            yield return new TestCaseData(
                "bbbbB",
                'B'
                );
            yield return new TestCaseData(
                "aaaaaaaaaaaaaaabbbbbbbbbbbbbbbbbbbbbbbbs",
                's'
                );
            yield return new TestCaseData(
                "abc",
                'a'
                );
            yield return new TestCaseData(
                "a",
                'a'
                );
            yield return new TestCaseData(
                "!@#$%",
                '!'
                );
            yield return new TestCaseData(
                "!@#$%abdjcklf",
                '!'
                );
            yield return new TestCaseData(
                "gjfhoenfk14325326!@#%^&*&",
                'g'
                );
            yield return new TestCaseData(
                "123456",
                '1'
                );
            yield return new TestCaseData(
                " ",
                ' '
                );
        }

        public static IEnumerable<TestCaseData> FirstNonRepeatingCharacterNegativeTestCases()
        {
            yield return new TestCaseData(
                "aaaaaaaaaaaaaaaaaaaaaaaaa",
                null
                );
            yield return new TestCaseData(
                "1111111111111111111111111111",
                null
                );
            yield return new TestCaseData(
                "!!!!!!!!!!!!!!",
                null
                );
            yield return new TestCaseData(
                "AAAAAAAAAAAAAAA!!!!!!!!!!!!!!!!!!!!!WWWWWWWWWWWWWWWWWWWW",
                null
                );
            yield return new TestCaseData(
                "",
                null
                );
            yield return new TestCaseData(
                null,
                null
                );
        }

        [TestCaseSource(nameof(FirstNonRepeatingCharacterHappyPathTestCases))]
        [TestCaseSource(nameof(FirstNonRepeatingCharacterNegativeTestCases))]
        public void FirstNonRepeatingCharacterTests(String text, char? expectedChar)
        {
            Assert.That(Functions.FirstNonRepeatingCharacter(text), Is.EqualTo(expectedChar));
        }
    }
}