using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumCsharpnetcore
{
    public class CustomContol: DriverHelper
    {

      
        public static void Combobox(string controlName, string value)
        {
            IWebElement mealsCombo = Driver.FindElement(By.XPath($"//input[@id='{controlName}-awed']"));
            mealsCombo.Clear();
            mealsCombo.SendKeys("Almond");
            Driver.FindElement(By.XPath($"//div[@id='{controlName}-dropmenu']//li[text()='Almond']")).Click();

        }


        
    }
}
