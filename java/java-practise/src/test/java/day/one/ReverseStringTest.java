package day.one;

import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.assertEquals;

public class ReverseStringTest {

    @Test
    void happyPathTest(){
        String text = "Hello";
        String reversedText = "olleH";
        assertEquals(reversedText, ReverseString.toReverse(text));
    }

    @Test
    void emptyCaseTest(){
        String text = "";
        String reversedText = "";
        assertEquals(reversedText, ReverseString.toReverse(text));
    }

    @Test
    void numbersCaseTest(){
        String text = "123";
        String reversedText = "321";
        assertEquals(reversedText, ReverseString.toReverse(text));
    }
}
