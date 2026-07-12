package domain;

import java.util.ArrayList;
import java.util.List;
import java.util.Objects;

public final class PatientDirectory {
    private final List<Patient> patients =
            new ArrayList<>();

    public void addPatient(Patient patient) {
        patients.add(
                Objects.requireNonNull(
                        patient,
                        "patient must not be null"
                )
        );
    }

    public List<Patient> searchByLastName(
            String lastName
    ) {
        Objects.requireNonNull(
                lastName,
                "lastName must not be null"
        );

        return patients.stream()
                .filter(patient ->
                        patient.lastName()
                                .equalsIgnoreCase(lastName)
                )
                .toList();
    }
}
