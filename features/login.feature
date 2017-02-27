Feature: Running an Example Cucumber Test
  As a user
  I want to add a new task
  So that I can have a to-do list

  Scenario: Tapping the new task Button
    Given I am on the first page
    Then I press the new task "button"
    And I wait to see the second page
    And Take Picture



