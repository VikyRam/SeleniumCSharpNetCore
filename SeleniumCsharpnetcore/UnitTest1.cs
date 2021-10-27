using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumCsharpnetcore.Pages;

namespace SeleniumCsharpnetcore
{
    public class Tests: DriverHelper
    {
        
        [SetUp]
        public  void Setup()
        {
            Console.WriteLine("Setup");

            //ChromeOptions options = new ChromeOptions();
           // options.AddArguments("--headless");
          
            Driver = new ChromeDriver();
           // Driver.Navigate().GoToUrl("https://demo.aspnetawesome.com/");

            // Driver.FindElement(By.Id("Meal")).SendKeys("Tomato");
            // Driver.FindElement(By.XPath("//input[@name='ChildMeal1']/following-sibling::div[text()='Celery']")).Click();


            //IWebElement mealsCombo=  Driver.FindElement(By.XPath("//input[@id='AllMealsCombo-awed']"));
            //mealsCombo.Clear();
            // mealsCombo.SendKeys("Almond");
            //Driver.FindElement(By.XPath("//div[@id='AllMealsCombo-dropmenu']//li[text()='Almond']")).Click();


            //CustomContol.Combobox("AllMealsCombo","Almond");
        }

      

        [Test]
        public void LoginTest()
        {
            Driver.Navigate().GoToUrl("http://eaapp.somee.com/");

            Homepage homepage = new Homepage();
            Loginpage loginpage = new Loginpage();

            homepage.clickLogin();
            loginpage.EnterUserNameAndPassword("admin", "password");
            loginpage.ClickLogin();

            Assert.That(homepage.IslogoffExist(), Is.True, "Log off is displayed");
        }
    }
}
