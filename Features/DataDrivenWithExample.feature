Feature: DataDrivenWithExample

	In order not to be repeat my data or to be able to update my data from feature file
	I want add my data to the feature file


@mytag
Scenario Outline: Validate Form Examples
	Given I navigate to site "https://www.giftrete.com"
	And I navigate to site "https://blueskycitadel.com/automation-testing-form/"
	When I enter  email "<richkome@yahoo.com>"
	And I enter  password "<Password>"
	And I click on the Submit button
	Then the form is submitted

	Examples: 
	| Email              | Password         |
	| richkome@yahoo.com | mysecurePassword | 
	


