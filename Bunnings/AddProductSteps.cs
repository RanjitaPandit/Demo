using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace Bunnings
{
    [Binding]
    public class AddProductSteps : Hooks
    {
        [Given(@"I click on Search Bar")]
        public void GivenIClickOnSearchBar()
        {
            
            //Click on Search Box
            Driver.driver.FindElement(By.XPath("//*[@id='headerMainMenu']/div[2]/div/div[1]/div/div/input[1]")).Click();

        }

        [Given(@"Enter the name of the Product which I want to buy")]
        public void GivenEnterTheNameOfTheProductWhichIWantToBuy()
        {
            // Enter Product Name in Search Bar
            String Product = "Paint";

            // Enter the Product name in the Search Bar
            Driver.driver.FindElement(By.XPath("//*[@id='headerMainMenu']/div[2]/div/div[1]/div/div/input[1]")).SendKeys(Product);

            //Search the Product
            Driver.driver.FindElement(By.XPath("//*[@id='headerMainMenu']/div[2]/div/div[1]/div/div/input[1]")).SendKeys(Keys.Enter);

        }

        [Given(@"Select an Item from the Product List")]
        public void GivenSelectAnItemFromTheProductList()
        {
            // Select One Product from the list
            Driver.driver.FindElement(By.XPath("/html/body/form/div[6]/div/div[2]/div[3]/div/div/section/div[2]/div/div[1]/div[1]/div/section/article[1]/a/div/div[1]")).Click();

        }

        [Given(@"I enter Product details")]
        public void GivenIEnterProductDetails()
        {
            // Select the Amount
            Driver.driver.FindElement(By.XPath("//*[@id='select2-select-size-container']")).Click();

            // Select Quantity
            Driver.driver.FindElement(By.XPath("//*[@id='body_1_ctl01_ucAddLineItemButtons_ucQuantityTextBox']")).Click();

        }

        [When(@"I click on Add to Wish List")]
        public void WhenIClickOnAddToWishList()
        {
            // Add it to the My Wish List
            Driver.driver.FindElement(By.XPath("/html/body/form/div[6]/div/div[2]/div[1]/section/div/div[2]/div[4]/div[2]/div[3]/button")).Click();

        }

        [Then(@"The item should Successfully be added to My Wish List")]
        public void ThenTheItemShouldSuccessfullyBeAddedToMyWishList()
        {
            // Validate Product is been Added to Wish List
            string text = Driver.driver.FindElement(By.XPath("/html/body/form/div[4]/div/div[2]/div[1]/section[2]/p[1]/strong")).Text;

            if (text == "item in your Wish List")
            {
                Console.WriteLine("Item Added Successfully");
            }
            else
                Console.WriteLine("Failed to Add Item");
        }
    }
}
