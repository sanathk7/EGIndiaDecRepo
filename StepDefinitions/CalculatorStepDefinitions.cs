namespace SpecFlowProject.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            Console.WriteLine("Enter The First Number"); 

            //throw new PendingStepException();
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            Console.WriteLine("Enter The Second Number");

            //throw new PendingStepException();
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            Console.WriteLine("Two Numbers added");


            //throw new PendingStepException();
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            Console.WriteLine("Result is displayed");


            // throw new PendingStepException();
        }
    }
}
