Feature: Login

this Feature will cover below scenario
	1. Login Functionality

@utw
Scenario: Verify Login Functionality for Admin User
	Given I am navigated to Login Page
	When I enter Username
		And I enter Password
		And I click on Login Button
	Then I am redirectd to Admin Dashboard
