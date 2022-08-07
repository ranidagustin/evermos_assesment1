using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evermos_assesment1
{
    class Login
    {

        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://evermos.com/login");
            driver.Manage().Window.Maximize();

            Actions action = new Actions(driver);

            IWebElement TxtNomorHP = driver.FindElement(By.XPath("//input[@type='text']"));
            IWebElement TxtPassword = driver.FindElement(By.XPath("//input[@type='password']"));
            IWebElement BtnMasuk = driver.FindElement(By.XPath("//button[text()='Masuk']"));
            IWebElement LblFooter = driver.FindElement(By.CssSelector("footer.pageFooter"));

            //Perform Login
            TxtNomorHP.SendKeys("6281223334444");
            Task.Delay(TimeSpan.FromSeconds(2)).Wait();
            TxtPassword.SendKeys("password");
            Task.Delay(TimeSpan.FromSeconds(2)).Wait();

            //action.MoveToElement(LblFooter);
            action.SendKeys(Keys.PageDown).Build().Perform();
            Task.Delay(TimeSpan.FromSeconds(2)).Wait();

            BtnMasuk.Click();
            Task.Delay(TimeSpan.FromSeconds(5)).Wait();
            driver.Quit();
        }
    }
}
