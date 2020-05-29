Feature: BlueSkyCitadelTestingForm
	In order to be a guru tester
	I want to automate the Testing form
	Which has lots of features to automate in future

Scenario:Validate Form Submission
	Given I navigate to the BlueSky Testing Form
	When I enter the Single Line Text
	And I enter the one in the select Box
	And I enter Email
	And I enter Password
	And I select the Multi-Select
	And I select the Radio List
	And I select the Check Box List
	And I select United Kingdom as Country
	And I select date
	And I enter Paragraph Text
	And I click on the Submit button
	Then message "Your Form is successfully submitted"








	Scenario:Invalid Form Submission
	Given I navigate to the BlueSky Testing Form
	When I enter the Single Line Text
	And I enter the one in the select Box
	And I enter Email
	And I enter Password
	And I select the Multi-Select
	And I select the Radio List
	And I select the Check Box List
	#And I select United Kingdom as Country
	#And I select date
	And I enter Paragraph Text
	And I click on the Submit button
	Then the error message "Please correct errors before submitting this form" 
	And the page url is "www.blueskycitadel.com/applicaton"

