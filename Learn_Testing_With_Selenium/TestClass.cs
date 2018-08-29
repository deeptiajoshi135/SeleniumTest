using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Learn_Testing_With_Selenium
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void TestMethod()
        {
            // TODO: Add your test code here
            Assert.Pass("Your first passing test");
        }

        [Test]
        public void UserNameWithAlphabetsOnly()
        {
            IWebDriver webDriver = new ChromeDriver(); //Create a reference to the Chrome Driver. This is your control of the browser. This will open the browser. 
            webDriver.Navigate().GoToUrl("https://mail.google.com"); //This will type the URL & go to that URL

            IWebElement userNameElement = webDriver.FindElement(By.Id("identifierId")); //Finds the textbox by the name of "identifierId"
            userNameElement.SendKeys("");

            IWebElement nextButton = webDriver.FindElement(By.Id("identifierNext"));
            nextButton.SendKeys(Keys.Return);

            IWebElement passwordTextBox = webDriver.FindElement(By.XPath("//input[@name='password']"));
            nextButton.SendKeys("");

            IWebElement nextPasswordButton = webDriver.FindElement(By.Id("passwordNext"));
            nextPasswordButton.SendKeys(Keys.Return);

            Assert.IsNotNull(userNameElement);
            Assert.IsNotNull(nextButton);

            webDriver.Quit();
        }

        [Test]
        public void UserNameWithNumbers()
        {
           
        }


    }
}
