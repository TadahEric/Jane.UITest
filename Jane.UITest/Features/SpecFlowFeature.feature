Feature: Interview Test
	In order to be hired
	As a test candidate
	I need to pass a test

@mytag
Scenario: 1. Verify that Logging in takes user to the Search page
	Given I have reached the login page "localhost/en/login"
	And I have entered "Admin" as username
	And I have entered "Password1" as password
	When I click the Login button
	Then I am taken to the Search page "Test-Home"
	And the search language is "English"


Scenario: 1. Verify that Logging in takes user to the Search page
	Given I have reached the login page "localhost/fr/login"
	And I have entered "Admin" as username
	And I have entered "Password1" as password
	When I click the Login button
	Then I am taken to the Search page "Test-Home"
	And the search language is "French"


Scenario: 1. Verify that Logging in takes user to the Search page
	Given I have reached the login page "localhost/es/login"
	And I have entered "Admin" as username
	And I have entered "Password1" as password
	When I click the Login button
	Then I am taken to the Search page "Test-Home"
	And the search language is "Spanish"
