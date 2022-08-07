using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evermos_assesment1.PageObject
{
    internal class LandingPage { 
  
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://evermos.com/");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.CssSelector("div.elementor-widget-container nav.elementor-nav-menu--main a[href *= 'login']"));
            //driver.Quit();
        }
    }
}
