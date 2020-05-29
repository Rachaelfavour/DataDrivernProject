using BlueSkyProjectDataDriven.PageObjects;
using System;
using TechTalk.SpecFlow;

namespace BlueSkyProjectDataDriven.StepDefinitions
{
    [Binding]
    public class DataDrivernWithParameterSteps
    {

        AutomationTestingFormPage automationTestingFormPage;
        public DataDrivernWithParameterSteps()
        {
            automationTestingFormPage = new AutomationTestingFormPage();
        }

        [Given(@"I navigate to the site ""(.*)""")]
        public void GivenINavigateToTheSite(string Url)
        {
            automationTestingFormPage.NavigateToFormWithParameter(Url);
        }

        [When(@"I enter email ""(.*)""")]
        public void WhenIEnterEmail(string email)
        {
            automationTestingFormPage.EnterEmail(email);
        }
        
        [When(@"I enter password ""(.*)""")]
        public void WhenIEnterPassword(string password)
        {
            automationTestingFormPage.EnterPassword(password);
        }
        
        [When(@"I click on Submit Button")]
        public void WhenIClickOnSubmitButton()
        {
           // ScenarioContext.Current.Pending();
        }
        
        [Then(@"the Form is submitted")]
        public void ThenTheFormIsSubmitted()
        {
           // ScenarioContext.Current.Pending();
        }
    }
}
