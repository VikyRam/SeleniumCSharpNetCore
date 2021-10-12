using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumCsharpnetcore
{
    public class Tests: DriverHelper
    {
        
        [SetUp]
        public  void Setup()
        {
            Console.WriteLine("Setup");
            Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl("https://demo.aspnetawesome.com/");

            // Driver.FindElement(By.Id("Meal")).SendKeys("Tomato");
            // Driver.FindElement(By.XPath("//input[@name='ChildMeal1']/following-sibling::div[text()='Celery']")).Click();


            //IWebElement mealsCombo=  Driver.FindElement(By.XPath("//input[@id='AllMealsCombo-awed']"));
            //mealsCombo.Clear();
            // mealsCombo.SendKeys("Almond");
            //Driver.FindElement(By.XPath("//div[@id='AllMealsCombo-dropmenu']//li[text()='Almond']")).Click();


            CustomContol.Combobox("AllMealsCombo","Almond");
        }

        [Test]
        public void Test1()
        {
           // Console.WriteLine("Setup");
            //Assert.Pass();
        }
    }
}
