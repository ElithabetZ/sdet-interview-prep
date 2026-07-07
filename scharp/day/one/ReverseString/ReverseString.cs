namespace ReverseString
{
    public class ReverseString
    {
        public static String ToReverse(String textToReverse)
        {
            String reversedText = "";
            for (int i = textToReverse.Length - 1; i >= 0; i--)
            {
                reversedText += textToReverse.ElementAt(i);
            }
            return reversedText;
        }
    }
}
