Feature: DataDrivenWithTable
	In order not to be repeat my data or to be able to update my data from feature file
	I want add my data to the feature file


@mytag
Scenario Outline: Validate Form Table
	Given I navigate to site "https://blueskycitadel.com/automation-testing-form/"
	When I enter  email and password
	| Email               | Password   |
	|richkome@yahoo.com   | mypassword |