
using CSharpSpecFlowHealthcareExample.Domain;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace CSharpSpecFlowHealthcareExample.Bindings
{
    [Binding]
    public sealed class ChatbotAnswerSteps
    {
        private SupportChatbot _chatbot = null!;

        private string _chatbotAnswer = string.Empty;

        [Given(
            @"^the clinic support chatbot is available$")]
        public void GivenTheClinicSupportChatbotIsAvailable()
        {
            _chatbot = new SupportChatbot();
        }

        [When(@"^I ask the chatbot ""([^""]*)""$")]
        public void WhenIAskTheChatbot(
            string question)
        {
            _chatbotAnswer =
                _chatbot.Answer(question);
        }

        [Then(
            @"^the chatbot answer should contain ""([^""]*)""$")]
        public void ThenTheChatbotAnswerShouldContain(
            string expectedText)
        {
            Assert.That(
                _chatbotAnswer,
                Does.Contain(expectedText));
        }
    }
}
