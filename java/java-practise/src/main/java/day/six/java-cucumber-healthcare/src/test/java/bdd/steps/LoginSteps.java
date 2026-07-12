package bdd.steps;

import domain.AuthenticationService;
import io.cucumber.java.en.Given;
import io.cucumber.java.en.Then;
import io.cucumber.java.en.When;

import static org.assertj.core.api.Assertions.assertThat;

public class LoginSteps {

    private AuthenticationService authenticationService;
    private boolean loginSuccessful;

    @Given("the authentication system contains username {string} with password {string}")
    public void theAuthenticationSystemContainsUser(
            String username,
            String password
    ) {
        authenticationService = new AuthenticationService();
        authenticationService.addUser(username, password);
    }

    @When(
            "I log in with username {string} and password {string}"
    )
    public void iLogIn(
            String username,
            String password
    ) {
        loginSuccessful =
                authenticationService.login(username, password);
    }

    @Then("the login result should be {string}")
    public void theLoginResultShouldBe(String expectedResult) {
        boolean expectedSuccessful =
                switch (expectedResult.toLowerCase()) {
                    case "successful" -> true;
                    case "rejected" -> false;

                    default -> throw new IllegalArgumentException(
                            "Unsupported login result: "
                                    + expectedResult
                    );
                };

        assertThat(loginSuccessful)
                .isEqualTo(expectedSuccessful);
    }
}
