@chatbot
Feature: Chatbot Answer
  As a clinic website visitor
  I want the chatbot to answer a supported question
  So that I can get information without contacting support

  @smoke
  Scenario: Chatbot answers a question about clinic opening hours
    Given the clinic support chatbot is available
    When I ask the chatbot "What are the clinic opening hours?"
    Then the chatbot answer should contain "Monday to Friday"
    And the chatbot answer should contain "08:00 to 18:00"