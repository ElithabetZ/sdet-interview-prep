@auth
Feature: Login
  As a registered healthcare employee
  I want to log in to the application
  So that I can access protected functionality

  @smoke @outline
  Scenario Outline: Login with different credentials
    Given the authentication system contains username "doctor" with password "secret123"
    When I log in with username "<username>" and password "<password>"
    Then the login result should be "<result>"

    Examples:
      | username | password  | result     |
      | doctor   | secret123 | successful |
      | doctor   | wrong123  | rejected   |
      | unknown  | secret123 | rejected   |