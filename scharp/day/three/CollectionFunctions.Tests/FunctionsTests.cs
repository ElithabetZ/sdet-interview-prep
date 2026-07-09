using NUnit.Framework;

namespace CollectionFunctions.Tests
{
    public class Tests
    {

        []
        public void FindDuplicates_HappyPath(int[] nums, List<int> expected)
        {
            Assert.That(Functions.FindDuplicates(nums), Is.EqualTo(expected));
        }
    }
}