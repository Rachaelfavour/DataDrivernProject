using BlueSkyProjectDataDriven.Hooks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace BlueSkyProjectDataDriven.PageObjects
{ 
    class AutomationTestingFormPage
    {
        IWebDriver driver;
        public AutomationTestingFormPage()
        {
            driver = Hook.driver;
        }

        IWebElement singleLineText => driver.FindElement(By.CssSelector("#nf-field-135"));
        IWebElement selectOneTwoThree => driver.FindElement(By.Id("nf-field-136"));
        IWebElement multiSelect123 => driver.FindElement(By.Id("nf-field-137"));
        IWebElement emailAddress => driver.FindElement(By.Name("email"));
        IWebElement radioList => driver.FindElement(By.Id("nf-label-class-field-138-0"));
        IWebElement country => driver.FindElement(By.Id("nf-field-140"));
        IWebElement dateFromCalendar => driver.FindElement(By.CssSelector("input.pikaday__display.pikaday__display--pikaday.ninja-forms-field.nf-element.datepicker"));
        IWebElement paragraphText => driver.FindElement(By.CssSelector("#nf-field-143"));
        IWebElement passwordText => driver.FindElement(By.CssSelector("#nf-field-144"));
        IWebElement checkBoxList => driver.FindElement(By.Id("nf-label-field-139-0"));
        IWebElement submitButton => driver.FindElement(By.Id("nf-field-133"));
        IWebElement errorMessage => driver.FindElement(By.CssSelector("#nf-form-errors-9 > nf-errors > nf-section > div"));
        IWebElement messageFormSuccessfullySubmitted => driver.FindElement(By.CssSelector("#nf-form-9-cont > div > div.nf-response-msg > p:nth-child(1)"));
        public string GetPageUrl => driver.Url;
        public string GetPageTitle()
        {
            return driver.Title;
        }
      
        
            
        
        public void CheckMessageFormSuccessfullySubmittedIsDisplayed()
        {
            Assert.IsTrue(messageFormSuccessfullySubmitted.Displayed);
         }
        public void CheckErrorMessageIsDisplayed()
        {
           Assert.IsTrue (errorMessage.Displayed);
        }
        public string GetTextForError()
        {
            return errorMessage.Text;
        }
        
        internal void EnterPassword(string password)
        {
            passwordText.SendKeys(password);
        }
        public void ClickSubmitButton()
        {
            submitButton.Click();
        }
        internal void NavigateToForm(string url)
        {
            driver.Navigate().GoToUrl(url);
        }
        internal void EnterEmail(string email)
        {
            emailAddress.SendKeys(email);
        }
        public void EnterPasswordText()

        {
            passwordText.SendKeys("password");
        }
        public void EnterParagraphText()

        {
            paragraphText.SendKeys("Rachael is a beautiful Lady");
        }

        public void SelectOneTwoThreFromCheckBoxList()
        {
            SelectElement select = new SelectElement(selectOneTwoThree);
            checkBoxList.Click();
        }
        public void EnterDateFromCalendar()
        {
            dateFromCalendar.SendKeys("02/22/2020");
        }
        public void SelectUnitedKingdomFromCountry()
        {
            SelectElement select = new SelectElement(country);
            select.SelectByValue("GB");
        }
        public void ClickRadioList()
        {

            radioList.Click();
        }
        public void EnterEmail()

        {
            emailAddress.SendKeys("richkome@yahoo.com");
        }

        public void SelectMultiSelector()
        {
            SelectElement select = new SelectElement(multiSelect123);
            select.SelectByValue("two");
            select.SelectByValue("three");

        }
        public void SelectOneFromSelectOneTwoThree()
        {
            SelectElement select = new SelectElement(selectOneTwoThree);
            select.SelectByValue("one");
        }
        public void EnterSingleLineText()
        {
            singleLineText.SendKeys("Rachael");

        }







        public void NavigateToForm()
        {
            driver.Navigate().GoToUrl("https://blueskycitadel.com/automation-testing-form/");
        }


        public void NavigateToFormWithParameter(string Url)
        {
            driver.Navigate().GoToUrl(Url);
        }
    }
}
