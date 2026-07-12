
namespace CSharpSpecFlowHealthcareExample.Domain
{
    public sealed class SupportChatbot
    {
        public string Answer(string question)
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(question);

            var normalizedQuestion =
                question.Trim().ToLowerInvariant();

            if (normalizedQuestion.Contains("opening hours")
                || normalizedQuestion.Contains("clinic hours"))
            {
                return "The clinic is open Monday to Friday "
                       + "from 08:00 to 18:00.";
            }

            return "I do not have an answer "
                   + "for that question yet.";
        }
    }
}
