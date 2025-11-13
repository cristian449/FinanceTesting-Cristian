using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumC_
{
    class NUnitTest
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
            driver.Url = ("https://Google.com");
        }

        [TearDown]
        public void EndTest()
        {
            driver.Quit();
        }
    }
}


