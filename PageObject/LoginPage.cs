using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evermos_assesment1.PageObject
{
    internal class LoginPage
    {
        IWebDriver driver = new ChromeDriver();

        public IWebElement TxtNomorHP => driver.FindElement(By.Id("Email"));
        public IWebElement TxtPassword => driver.FindElement(By.Id("Password"));
        public IWebElement BtnLogin => driver.FindElement(By.XPath("//button[contains(text(),'Log in')]"));
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://evermos.com/");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.);
        }
    }
}
