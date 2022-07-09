// See https://aka.ms/new-console-template for more information
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumProject
{
    class Program
    {
        public void login(string username, string password)
        {            
            IWebDriver ChromeDriver = new ChromeDriver();
            ChromeDriver.Manage().Cookies.DeleteAllCookies();
            ChromeDriver.Navigate().GoToUrl("http://the-internet.herokuapp.com/login");
            ChromeDriver.FindElement(By.Name("username")).SendKeys(username);
            ChromeDriver.FindElement(By.Name("password")).SendKeys(password);
            Thread.Sleep(3000);
            ChromeDriver.FindElement(By.ClassName("radius")).Click();

            Console.WriteLine($"TESTING RESULT: {ChromeDriver.FindElement(By.ClassName("error")).Text}");
            Thread.Sleep(3000);
            ChromeDriver.Quit();
        }

        static void Main(string[] args)
        {            
            Program program = new Program();
            program.login("tomsmith", "WrongPassword");
            program.login("WrongUser", "SuperSecretPassword");
        }
    }
}



