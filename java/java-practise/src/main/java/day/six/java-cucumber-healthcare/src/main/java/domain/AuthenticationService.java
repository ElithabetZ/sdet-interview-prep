package domain;

import java.util.HashMap;
import java.util.Map;
import java.util.Objects;

public final class AuthenticationService {
    private final Map<String, String> users = new HashMap<>();

    public void addUser(
            String username,
            String password
    ) {
        users.put(
                Objects.requireNonNull(
                        username,
                        "username must not be null"
                ),
                Objects.requireNonNull(
                        password,
                        "password must not be null"
                )
        );
    }

    public boolean login(
            String username,
            String password
    ) {
        return users.containsKey(username)
                && Objects.equals(
                users.get(username),
                password
        );
    }
}
