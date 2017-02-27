require 'calabash-android'

Given(/^I'm on the Home Page$/) do
  flash "* id:'action_bar_title'"
end

Then(/^I wait for the Add Task Button$/) do
  wait_for(timeout: 60, timeout_message: "Could not find 'Add Task' button") do
      element_exists("button marked:'AddButton'")
end

And(/^I tap the Add Task Button$/) do
  touch "* id:'AddButton'"
end

Then(/^I should see the Task Page$/) do
  wait_for(timeout: 60, timeout_message: "Could not find 'Save' button") do
    element_exists("button marked:'SaveButton'")
end

