using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumNegativeTests
{
    class NAdminLoginTest
    {
        public ChromeDriver driver;


        [SetUp]
        public void Initialize()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void OpenappTest()
        {
            driver.Url = ("https://localhost:7130/Accounts/Login");

            driver.FindElement(By.Id("Email"))



        }

        [TearDown]
        public void EndTest()
        {
            driver.Quit();
            driver.Dispose();
        }
    }
}


