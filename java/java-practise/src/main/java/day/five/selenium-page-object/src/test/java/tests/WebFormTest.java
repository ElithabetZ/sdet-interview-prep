package tests;

import org.junit.jupiter.api.DisplayName;
import org.junit.jupiter.api.Test;
import pages.SubmittedPage;
import pages.WebFormPage;

import static org.junit.jupiter.api.Assertions.assertEquals;

public class WebFormTest extends BaseTest{

    @Test
    @DisplayName("User can send the form")
    void userCanSendFormTest(){
        SubmittedPage submittedPage = new WebFormPage(driver, 5)
                .open()
                .typeText("Hello")
                .submit();

        assertEquals("Received!", submittedPage.getMessage());
    }
}
