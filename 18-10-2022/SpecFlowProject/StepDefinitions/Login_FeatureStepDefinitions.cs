using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using System.Xml;

namespace SpecFlowProject.StepDefinitions
{
   
    [Binding]
    
    public class Login_FeatureStepDefinitions
    {
        Login l=new Login();
        string id;
        string pas;
        bool a;
        int p1;
        string pname;
        int qty;
        

        [Given(@"User gives userid as '([^']*)'")]
        public void Givenuserid(string P0)
        {
            id= P0;

            
            
        }
        [Given(@"User gives password as '([^']*)'")]
        public void Givenpassword(string P0)
        {
            pas=P0;



        }

        [When(@"UserClicksLogin")]
        public void Whenlogin()
        {
            Console.WriteLine($"{nameof(Whenlogin)}");
           
        }

        [Then(@"SuccessfulLogin message should display")]
        public void  Thenlogin()
        {
            a= l.result(id, pas);
            Assert.AreEqual(a, true);
            Console.WriteLine("SuccessfullyLogin");
        }


        [Given("the input is (.*)")]
        public void Givenlogout(int result)
        {

            p1 = result;

        }

        [When("User LogOut from the Application")]
        public void  Whenlogout()
        {
            
            Console.WriteLine($"{Whenlogout}");
        }
        
        [Then("Successful LogOut message should display")]
        public void Thenlogout()
        {
            
            if(p1==0)
            {
                Console.WriteLine("LoggedOutSuccessfully");
            }
            else
            {
                Console.WriteLine("Not Logged In");
            }
            
            
        }
        ///// <summary>
        ///// ///
        ///// </summary>
        ///  [Given("the input is (.*)")] <summary>
        ///  [Given("the input is (.*)")]
        /// </summary>
        /// <param name="result"></param>
        /// 
        [Given("the prodname is(.*)")]
        public void Givenproduct(string  result)
        {

           pname = result;

        }
        [Given("the quantity is(.*)")]
        public void givenquantity(int ans)
        {
            
            qty= ans;
        }
        [When("quantity and product is added to cart")]
        public void Whenproductquantityaddedtocart()
        {
            Console.WriteLine($"{nameof(Whenproductquantityaddedtocart)}");

        }

        [Then("Product is not null or empty and quantity is greater than zero which is added")]
        public void Thenproductaddedandquantitychecked()
        {

            if(pname!=null & qty>0)
            {
                Console.WriteLine("Product Added to the Cart Successfully");
            }
        }
    }
}
