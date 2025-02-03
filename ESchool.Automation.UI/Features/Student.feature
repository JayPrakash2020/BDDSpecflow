Feature: Student

I will cover below scenario 
 1. Adding Student Details

Background: 
	Given I am navigated to Login Page
	When I enter Username
		And I enter Password
		And I click on Login Button
	Then I am redirectd to Admin Dashboard
@utw
Scenario Outline: Adding Library Book Details
	When I click on Library
		And I click on Manage Library
	Then I am able to see Manage Libary Page
	And I am adding student details "<class>" "<BookName>" "<Author>" "<Publication>" 
	When I click on Save Button
	Examples: 
	| class   | BookName | Author | Publication | 
	| One | CSharp  | JayPrakash |UTW | 