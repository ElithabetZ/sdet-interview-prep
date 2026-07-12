package domain;

import java.time.LocalDate;
import java.util.Objects;

public record Patient(
        String id,
        String firstName,
        String lastName,
        LocalDate dateOfBirth
) {

    public Patient {
        Objects.requireNonNull(
                id,
                "id must not be null"
        );

        Objects.requireNonNull(
                firstName,
                "firstName must not be null"
        );

        Objects.requireNonNull(
                lastName,
                "lastName must not be null"
        );

        Objects.requireNonNull(
                dateOfBirth,
                "dateOfBirth must not be null"
        );
    }
}
