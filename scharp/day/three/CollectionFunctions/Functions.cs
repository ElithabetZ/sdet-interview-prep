namespace CollectionFunctions
{
    public class Functions
    {
        public static char? FirstNonRepeatingCharacter(String text)
        {
            if(String.IsNullOrEmpty(text)) return null;

            Dictionary<char, int> charCount = new Dictionary<char, int>();
            char[] chars = text.ToCharArray();

            foreach (char c in chars)
            {
                if(charCount.ContainsKey(c)) charCount[c] ++;
                else charCount[c] = 1;
            }

            foreach (char c in chars)
            {
                if (charCount[c] == 1) return c;
            }

            return null;
        }

        public static List<int> FindDuplicates(int[] nums)
        {
            if(nums == null) throw new ArgumentNullException(nameof(nums));

            HashSet<int> seen = new HashSet<int>();
            HashSet<int> duplicates = new HashSet<int>();
            List<int> result = new List<int>();

            foreach(int i in nums)
            {
                if(!seen.Add(i) && duplicates.Add(i)) result.Add(i);
            }

            return result;
        }

        public static List<int> RemoveDuplicates(int[] nums) 
        {
            if(nums == null) throw new ArgumentNullException(nameof(nums));

            HashSet<int> found = new HashSet<int>();
            List<int> result = new List<int>();

            foreach(int i in nums)
            {
                if(found.Add(i)) result.Add(i);
            }
            return result;
        }
    }
}
