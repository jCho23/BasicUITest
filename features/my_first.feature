Feature: AddTask Tests

  Scenario: Successful Add Task
    Given I'm on the Home Page
    Then I wait for the Add Task Button
    And I tap the Add Task Button
    Then I should see the Task Page

