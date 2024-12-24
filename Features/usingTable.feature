
Feature: Lab1
 
A short summary of the feature
 

Scenario: Verify form completion without clicking submit
    Given User is on the registration page
    When User enters "<name>", "<email>", and "<password>" in the text fields
    And User selects "<gender>" as gender
    And User chooses "<employmentStatus>" using the radio button
    And User selects "<dateOfBirth>" as date of birth
    Then The submit button should be enabled but not clicked
    Examples:
      | name        | email             | password  | gender  | employmentStatus | dateOfBirth |
      | John Doe    | john@example.com  | pass123   | Male    | Employed         | 1990-01-01  |
      | Jane Smith  | jane@example.com  | securePwd | Female  | Student          | 1995-05-15  |