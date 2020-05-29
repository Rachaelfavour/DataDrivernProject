using BlueSkyProjectDataDriven.PageObjects;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace BlueSkyProjectDataDriven.StepDefinitions
{
    [Binding]
    public class DataDrivenWithTableSteps
    {
        DataDrivenTablePage dataDrivenTablePage;
        public DataDrivenWithTableSteps()
        {
            dataDrivenTablePage = new DataDrivenTablePage();
        }
        [When(@"I enter  email and password")]
        public void WhenIEnterEmailAndPassword(Table table)
        {
            var emailAndPassword = table.CreateInstance<Detail>();
            string email = emailAndPassword.Email;
            string password = emailAndPassword.Password;
            dataDrivenTablePage.EnterEmailAndPassword(email, password);
        }
    }
}
