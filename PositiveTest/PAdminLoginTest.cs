using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace PositiveAdmin
{
    class PAdminLoginTest
    {
        public ChromeDriver driver;


        [SetUp]
        public void Initialize()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void SuccesfulAdminLogin()
        {
            driver.Url = ("https://localhost:7130/Accounts/Login");

            driver.FindElement(By.Id("Email"));
            WebElement emailField = (WebElement)driver.FindElement(By.Id("Email"));
            driver.FindElement(By.Id("Password"));
            WebElement passwordField = (WebElement)driver.FindElement(By.Id("Password"));
            driver.FindElement(By.Id("AdminKey"));
            WebElement adminkeyField = (WebElement)driver.FindElement(By.Id("AdminKey"));


            emailField.SendKeys("TestAdmin@gmail.com");
            passwordField.SendKeys("Admin@123");
            adminkeyField.SendKeys("Admin");
            Thread.Sleep(2000);
            //No Id yet
            driver.FindElement(By.Id("LoginButton")).Click();

            Assert.AreEqual("https://localhost:7130/User/Dashboard", driver.Url, "Login did not redirect to the expected URL.");


        }


        [TearDown]
        public void EndTest()
        {
            driver.Quit();
            driver.Dispose();
        }
    }
}


