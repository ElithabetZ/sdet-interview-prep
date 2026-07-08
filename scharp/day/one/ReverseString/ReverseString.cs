using System.Text;

namespace ReverseString
{
    public class ReverseString
    {
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
