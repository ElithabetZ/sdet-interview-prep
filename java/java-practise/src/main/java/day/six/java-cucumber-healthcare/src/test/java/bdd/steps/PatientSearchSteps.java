package bdd.steps;

import domain.Patient;
import domain.PatientDirectory;
import io.cucumber.datatable.DataTable;
import io.cucumber.java.en.And;
import io.cucumber.java.en.Given;
import io.cucumber.java.en.Then;
import io.cucumber.java.en.When;

import java.time.LocalDate;
import java.util.Arrays;
import java.util.List;
import java.util.Map;

import static org.assertj.core.api.Assertions.assertThat;

public class PatientSearchSteps {
    private PatientDirectory patientDirectory;
    private List<Patient> searchResults;

    @Given("the patient directory contains:")
    public void thePatientDirectoryContains(
            DataTable table
    ) {
        patientDirectory = new PatientDirectory();

        List<Map<String, String>> rows =
                table.asMaps(String.class, String.class);

        for (Map<String, String> row : rows) {
            Patient patient = new Patient(
                    row.get("id"),
                    row.get("firstName"),
                    row.get("lastName"),
                    LocalDate.parse(
                            row.get("dateOfBirth")
                    )
            );

            patientDirectory.addPatient(patient);
        }
    }

    @When(
            "I search for patients with last name {string}"
    )
    public void iSearchForPatientsWithLastName(
            String lastName
    ) {
        searchResults =
                patientDirectory.searchByLastName(lastName);
    }

    @Then("{int} patients should be returned")
    public void patientsShouldBeReturned(
            int expectedCount
    ) {
        assertThat(searchResults)
                .hasSize(expectedCount);
    }

    @And(
            "the returned patient IDs should be {string}"
    )
    public void theReturnedPatientIdsShouldBe(
            String commaSeparatedIds
    ) {
        List<String> expectedIds =
                Arrays.stream(
                                commaSeparatedIds.split(",")
                        )
                        .map(String::trim)
                        .toList();

        assertThat(searchResults)
                .extracting(Patient::id)
                .containsExactlyElementsOf(expectedIds);
    }
}
