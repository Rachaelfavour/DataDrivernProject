using BlueSkyProjectDataDriven.PageObjects;
using FluentAssertions;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace BlueSkyProjectDataDriven.StepDefinitions
{
    [Binding]
    public class BlueSkyCitadelTestingFormSteps
    {
        AutomationTestingFormPage automationTestingFormPage;

        public BlueSkyCitadelTestingFormSteps()
        {
            automationTestingFormPage = new AutomationTestingFormPage();
        }


        [Then(@"the error message ""(.*)""")]
        public void ThenTheErrorMessage(string errorMessage)
        {
            automationTestingFormPage.CheckErrorMessageIsDisplayed();
            Assert.AreEqual(errorMessage, automationTestingFormPage.GetTextForError());
          
        }

        [Then(@"the page url is ""(.*)""")]
        public void ThenThePageUrlIs(string url)
        {
            Assert.AreEqual(url, automationTestingFormPage.GetPageUrl);
            url.Should().Be(automationTestingFormPage.GetPageUrl);
            


        }

        [Given(@"I navigate to the BlueSky Testing Form")]
        public void GivenINavigateToTheBlueSkyTestingForm()
        {
            automationTestingFormPage.NavigateToForm();
        }
        

        [When(@"I enter the Single Line Text")]
        public void WhenIEnterTheSingleLineText()
        {
            automationTestingFormPage.EnterSingleLineText();
        }
        
        [When(@"I enter the one in the select Box")]
        public void WhenIEnterTheOneInTheSelectBox()
        {
            automationTestingFormPage.SelectOneFromSelectOneTwoThree();
        }
        
        [When(@"I enter Email")]
        public void WhenIEnterEmail()
        {
            automationTestingFormPage.EnterEmail();
        }
        
        [When(@"I enter Password")]
        public void WhenIEnterPassword()
        {
            automationTestingFormPage.EnterPasswordText();
        }
        
        [When(@"I select the Multi-Select")]
        public void WhenISelectTheMulti_Select()
        {
            automationTestingFormPage.SelectMultiSelector();
        }
        
        [When(@"I select the Radio List")]
        public void WhenISelectTheRadioList()
        {

            automationTestingFormPage.ClickRadioList();
        }
        
        [When(@"I select the Check Box List")]
        public void WhenISelectTheCheckBoxList()
        {
            automationTestingFormPage.SelectOneTwoThreFromCheckBoxList();
        }
        
        [When(@"I select United Kingdom as Country")]
        public void WhenISelectUnitedKingdomAsCountry()
        {

            automationTestingFormPage.SelectUnitedKingdomFromCountry();
        }


        [When(@"I select date")]
        public void WhenISelectDate()
        {
          automationTestingFormPage.EnterDateFromCalendar();
        }



        [When(@"I enter Paragraph Text")]
        public void WhenIEnterParagraphText()
        {
            automationTestingFormPage.EnterParagraphText();
        }
        
        [When(@"I click on the Submit button")]
        public void WhenIClickOnTheSubmitButton()
        {
            automationTestingFormPage.ClickSubmitButton();
        }
        
        [Then(@"message ""(.*)""")]
        public void ThenMessage(string messsage)
        {
            automationTestingFormPage.CheckMessageFormSuccessfullySubmittedIsDisplayed();
        }
    }
}
