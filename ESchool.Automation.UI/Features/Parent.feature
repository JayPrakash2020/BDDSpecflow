Feature: Parent

I will cover Below Functionaltiy
1. Adding Parents
2. Editing Parents
3. Deleting Parents

Background: 
	Given I am navigated to Login Page
	When I enter Username
		And I enter Password
		And I click on Login Button
	Then I am redirectd to Admin Dashboard

@tag1
Scenario Outline: Verify Add Parents Functionaltiy
	When I click on "Parents" 
		And I click on "Add Parents" sub menu
	Then I am able to see "Parent Registration" Page
		And I am adding parents details '<Fullname>' '<Username>' '<Email>' '<DOB>' '<Address>' '<Contactno>' '<Gender>'
	When I click on "Add Parent" button
	Examples: 
	| Fullname    | Username | Email                  | DOB        | Address | Contactno   | Gender |
	| Jay Prakash | jaypath  | jayprakasutw@gmail.com | 10/09/1990 | Ranchi  | 9999999999999 | male   |
