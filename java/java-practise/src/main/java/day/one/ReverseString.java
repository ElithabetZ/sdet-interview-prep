package day.one;

public class ReverseString {

    public static String toReverse(String textToReverse){
        String reversedText = "";
        for(int i = textToReverse.length() - 1; i >= 0; i--){
            reversedText += textToReverse.charAt(i);
        }
        return reversedText;
    }
}
