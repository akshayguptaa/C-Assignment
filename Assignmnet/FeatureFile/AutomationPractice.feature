Feature: Check the Login functionality of AutomationPractice.com
	WE have to check the for each and every case of login
	


Scenario: Sign in with password and empty email
	Given I have navigated to the website 
	When we will Pass the parameters
	 And login button clicked
	Then Message is Displayed
	Then Close the Browser

Scenario: Sign in with email and empty password
	 Given I have navigated to the website
    When Pass the parameters
	 And login button clicked
	Then Unsucessful Message is displayed
	Then Close the Browser

Scenario: Sign in with incorrect credentials
	Given I have navigated to the website 
	And login button clicked
	When Pass the Arguments
	Then Message is displayed accordingly
	Then Close the Browser

Scenario: Sign in with no credentials
	Given I have navigated to the website 
	And login button clicked
	When No Argument is passed
	Then Error Message is shown
	Then Close the Browser

	
	