using BlueSkyProjectDataDriven.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace BlueSkyProjectDataDriven.StepDefinitions
{
    [Binding]
    public class DataDrivenWithExample
    {
        AutomationTestingFormPage automationTestingFormPage;
        public DataDrivenWithExample()
        {
            automationTestingFormPage = new AutomationTestingFormPage();
        }
        [When(@"I enter  password ""(.*)""")]
        public void WhenIEnterPassword(string password)
        {
            automationTestingFormPage.EnterPassword(password);
        }

        [Given(@"I navigate to site ""(.*)""")]
        public void GivenINavigateToSite(string Url)
        {
            automationTestingFormPage.NavigateToForm(Url);
        }

        [When(@"I enter  email ""(.*)""")]
        public void WhenIEnterEmail(string email)
        {
            automationTestingFormPage.EnterEmail(email);
        }

        [Then(@"the form is submitted")]
        public void ThenTheFormIsSubmitted()
        {
            automationTestingFormPage.CheckMessageFormSuccessfullySubmittedIsDisplayed();
        }
    } 
}



















