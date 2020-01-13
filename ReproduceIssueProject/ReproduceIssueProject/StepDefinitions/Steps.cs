using System;
using System.Collections.Generic;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace ReproduceIssueProject.StepDefinitions
{
    [Binding]
    public class Steps
    { 
        private List<int> paramsList;
        private int operationResult;

        public Steps()
        {
            paramsList = new List<int> { };
        }

        [Given("I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredSomethingIntoTheCalculator(int number)
        { 
            paramsList.Add(number);
        }

        [When("I press add")]
        public void WhenIPressAdd()
        {
            operationResult = paramsList[0] + paramsList[1];
        }

        [Then("the result should be (.*) on the screen")]
        public void ThenTheResultShouldBe(int result)
        {
            Assert.AreEqual(result, operationResult);
        }
    }
}
