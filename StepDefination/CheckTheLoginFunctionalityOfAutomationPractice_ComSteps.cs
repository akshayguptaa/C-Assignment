using System;
using TechTalk.SpecFlow;

namespace Assignmnet....StepDefination
{
    [Binding]
    public class CheckTheLoginFunctionalityOfAutomationPractice_ComSteps
    {
        [Given(@"login button clicked")]
        public void GivenLoginButtonClicked()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"login button clicked")]
        public void WhenLoginButtonClicked()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
