using BlueSkyProjectDataDriven.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
namespace BlueSkyProjectDataDriven.PageObjects
{
    class DataDrivenTablePage
    {
        IWebDriver driver;
        public DataDrivenTablePage()
        {
            driver = Hook.driver;
        }
        
      
      
        IWebElement emailAddress => driver.FindElement(By.Name("email"));
        IWebElement passwordText => driver.FindElement(By.CssSelector("#nf-field-144"));

       
        

          public void EnterEmailAndPassword(string email,string password)
          {
            emailAddress.SendKeys(email);
            passwordText.SendKeys(password);


          }
          
           

        
    
    
    
    
    
    
    
    }













}
