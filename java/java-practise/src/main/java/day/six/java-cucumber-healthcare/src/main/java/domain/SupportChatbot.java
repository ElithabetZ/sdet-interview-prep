package domain;

import java.util.Locale;
import java.util.Objects;

public final class SupportChatbot {
    public String answer(String question) {
        String normalizedQuestion =
                Objects.requireNonNull(
                                question,
                                "question must not be null"
                        )
                        .trim()
                        .toLowerCase(Locale.ROOT);

        if (
                normalizedQuestion.contains(
                        "opening hours"
                )
                        || normalizedQuestion.contains(
                        "clinic hours"
                )
        ) {
            return "The clinic is open Monday to Friday "
                    + "from 08:00 to 18:00.";
        }

        return "I do not have an answer "
                + "for that question yet.";
    }
}
