using System.Text;

namespace TextFunctions
{
    public class Functions
    {
        public static Dictionary<char, int> CountVowels(String message)
        {
            if(message == null) throw new ArgumentNullException(nameof(message));

            Dictionary<char, int> countVowels = new Dictionary<char, int>();
            char[] vowels = ['a', 'e', 'i', 'o', 'u'];
            char[] chars = message.ToLower().ToCharArray();
            foreach (char vowel in vowels)
            {
                int vowelCount = 0;
                foreach (char messageChar in chars)
                {
                    if(messageChar == vowel) vowelCount++;
                }
                countVowels.Add(vowel, vowelCount);
            }
            return countVowels;
        }


        public static int CountCharacters(String message)
        {
            if(message == null) throw new ArgumentNullException(nameof(message));

            char[] chars = message.ToCharArray();
            int countRestricted = 0;
            foreach(char c in chars)
            {
                if (c == '\n' || c == ' ' || c == '\'' || c == '"') { countRestricted++; };
            }
            return chars.Length - countRestricted;
        }

        public static Boolean IsPalindrome(String message)
        {
            if(message == null) throw new ArgumentNullException(nameof(message));
            if(message.Length <= 1) return false;
            return message.Equals(ToReverse(message));
        }
        public static String ToReverse(String textToReverse)
        {
            if (textToReverse == null)
            {
                throw new ArgumentNullException(nameof(textToReverse));
            }

            StringBuilder reversedText = new();

            for (int i = textToReverse.Length - 1; i >= 0; i--)
            {
                reversedText.Append(textToReverse[i]);
            }

            return reversedText.ToString();
        }
    }
}
