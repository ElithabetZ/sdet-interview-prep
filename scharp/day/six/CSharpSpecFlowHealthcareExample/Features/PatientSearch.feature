@patient-search @regression
Feature: Patient Search
  As a healthcare employee
  I want to search for patients by last name
  So that I can find the correct patient record

  Scenario: Search patients by last name
    Given the patient directory contains:
      | id    | firstName | lastName | dateOfBirth |
      | P1001 | Anna      | Smith    | 1985-04-12  |
      | P1002 | Mark      | Brown    | 1978-11-03  |
      | P1003 | John      | Smith    | 1992-07-25  |
    When I search for patients with last name "Smith"
    Then 2 patients should be returned
    And the returned patient IDs should be "P1001, P1003"
