package bdd.steps;

import domain.SupportChatbot;
import io.cucumber.java.en.Given;
import io.cucumber.java.en.Then;
import io.cucumber.java.en.When;

import static org.assertj.core.api.Assertions.assertThat;

public class ChatbotAnswerSteps {
    private SupportChatbot chatbot;
    private String chatbotAnswer;

    @Given(
            "the clinic support chatbot is available"
    )
    public void theClinicSupportChatbotIsAvailable() {
        chatbot = new SupportChatbot();
    }

    @When("I ask the chatbot {string}")
    public void iAskTheChatbot(String question) {
        chatbotAnswer = chatbot.answer(question);
    }

    @Then(
            "the chatbot answer should contain {string}"
    )
    public void theChatbotAnswerShouldContain(
            String expectedText
    ) {
        assertThat(chatbotAnswer)
                .contains(expectedText);
    }
}
