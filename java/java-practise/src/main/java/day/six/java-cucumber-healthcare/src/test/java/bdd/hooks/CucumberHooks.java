package bdd.hooks;

import io.cucumber.java.After;
import io.cucumber.java.Before;
import io.cucumber.java.Scenario;

public class CucumberHooks {

    @Before
    public void beforeEveryScenario(Scenario scenario){
        System.out.printf("%nSTART: %s, tags=%s%n",
                scenario.getName(),
                scenario.getSourceTagNames());
    }

    @Before("@smoke")
    public void beforeSmokeScenario() {
        System.out.println(
                "Preparing data required only by @smoke scenarios"
        );
    }

    @After
    public void afterEveryScenario(Scenario scenario) {
        System.out.printf(
                "END: %s, status=%s%n",
                scenario.getName(),
                scenario.getStatus()
        );
    }
}
