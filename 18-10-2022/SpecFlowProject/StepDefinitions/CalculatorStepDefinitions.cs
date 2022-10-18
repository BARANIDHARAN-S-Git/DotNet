
using NUnit.Framework;
using System.Globalization;

namespace SpecFlowProject.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef
        Calculator c = new Calculator();
        int i, j;
        int ans;
        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            //TODO: implement arrange (precondition) logic
            // For storing and retrieving scenario-specific data see https://go.specflow.org/doc-sharingdata
            // To use the multiline text or the table argument of the scenario,
            // additional string/Table parameters can be defined on the step definition
            // method. 
            i = number;
            Console.WriteLine($"{nameof(GivenTheFirstNumberIs)}:{number}");
            
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            //TODO: implement arrange (precondition) logic
            j = number;
            Console.WriteLine($"{nameof(GivenTheSecondNumberIs)}:{number}");
            
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            //TODO: implement act (action) logic

           
            Console.WriteLine($"{nameof(WhenTheTwoNumbersAreAdded)}");
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            //TODO: implement assert (verification) logic

           
            int addans = c.Add(i, j);
            Console.WriteLine($"{(ThenTheResultShouldBe)}:{result}");
            Assert.AreEqual(result, addans);
        }

        [When("the two numbers are Subtracted")]
        public void WhenTheTwoNumbersAreSubtracted()
        {
            //TODO: implement act (action) logic

           
            Console.WriteLine($"{nameof(WhenTheTwoNumbersAreSubtracted)}");
        }

        [Then("the output should be (.*)")]
        public void TheoutputShouldBe(int result)
        {
            //TODO: implement assert (verification) logic
            

            int subans = c.Subtract(i, j);
            Console.WriteLine($"{nameof(TheoutputShouldBe)}:{result}");
            Assert.AreEqual(result, subans);
        }
        [When("the two numbers are Multiplied")]
        public void WhenTheTwoNumbersAreMultiplied()
        {
            //TODO: implement act (action) logic

           
            Console.WriteLine($"{nameof(WhenTheTwoNumbersAreMultiplied)}");
        }

        [Then("the Multiplyans should be (.*)")]
        public void TheMultiplyansShouldBe(int result)
        {
            //TODO: implement assert (verification) logic
            
            
            int mulans = c.Multiply(i, j);
            Console.WriteLine($"{nameof(TheMultiplyansShouldBe)}:{result}");
            Assert.AreEqual(result, mulans);
        }
        [When("the two numbers are Divided")]
        public void WhenTheTwoNumbersAreDivided()
        {
            //TODO: implement act (action) logic

           
            Console.WriteLine($"{nameof(WhenTheTwoNumbersAreDivided)}");

        }

        [Then("the Divideans should be (.*)")]
        public void TheDivideansShouldBe(int result)
        {
            //TODO: implement assert (verification) logic
            
            int divans = c.Divide(i, j);
            Console.WriteLine($"{nameof(TheDivideansShouldBe)}:{result}");
            Assert.AreEqual(result, divans);
        }

    
        [When("number is squareroot")]
    public void WhenThesquareroot()
    {
        //TODO: implement act (action) logic

      
        Console.WriteLine($"{nameof(WhenThesquareroot)}");

    }

    [Then("the sqrtans should be (.*)")]
        public void Thesqrtshouldbe(int result)
        {
            //todo: implement assert (verification) logic
           
            int sqrtans = c.Sqrt(i);
            Console.WriteLine($"{nameof(Thesqrtshouldbe)}:{result}");
            Assert.AreEqual(result, sqrtans);
        }
    }
}