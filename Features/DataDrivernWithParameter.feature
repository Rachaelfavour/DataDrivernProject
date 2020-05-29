Feature: DataDrivernWithParameter
	In order not to repeat my data or to be able to update my data from features file
	I want to add my data to features file
	
	

@mytag
Scenario: Validate Form Parameter
	Given I navigate to the site "https://www.giftrete.com"
	When I enter email "richkome@yahoo.com"
	And I enter password "mysecuredPassword"
	And I click on Submit Button
	Then the Form is submitted
