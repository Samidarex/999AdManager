using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace _999.Models
{
    class Base
    {
        private readonly IWebDriver driver;
        private readonly INavigation navigation;

        public Base(IWebDriver driver)
         {
            this.driver = driver;
            this.navigation = this.driver.Navigate();
         }

        public void Login(string login, string password)
        {
            this.navigation.GoToUrl("https://simpalsid.com/user/login");
            var loginInput = this.driver.FindElement(By.Name("login"));
            var passwordInput = this.driver.FindElement(By.Name("password"));
            var loginButton = this.driver.FindElement(By.ClassName("login__form__footer__submit"));

            loginInput.SendKeys(login);
            passwordInput.SendKeys(password);

            loginButton.Click();
        }

        public void Publish(_999Products product)
        {
            this.navigation.GoToUrl("https://999.md/add");
            this.ChooseCategory(product.Categories);
            this.ChooseSubCategory(product.SubCategories);
            this.SumbitOfferDescription(product);
        }

        public void SumbitOfferDescription(_999Products product)
        {
            var localImagePath = this.driver.FindElement(By.Id("fileupload-button"));
            

            var titleInputField = this.driver.FindElement(By.Id("control_12"));
            var descriptionInputField = this.driver.FindElement(By.Id("control_13"));
            var offerType = this.driver.FindElement(By.XPath("//*[contains(., 'Продам')]"));
            var priceField = this.driver.FindElement(By.Id("control_2"));
            var agreementCheckbox = this.driver.FindElement(By.Id("agree"));
            var submitButton = this.driver.FindElements(By.ClassName("button button--giant")).Last();


            localImagePath.SendKeys(@"C:\Users\Samidare\Desktop\1.png");
            titleInputField.SendKeys(product.Title);
            priceField.SendKeys(product.Price.ToString("F2"));
            offerType.Click();
            descriptionInputField.SendKeys(product.Description);
            agreementCheckbox.Click();
            submitButton.Click();

            
        }


        public void ChooseCategory(string[] categories)
        {
            foreach(string s in categories)
            {
                var categoryUrl = this.driver.FindElements(By.CssSelector("a"))
                    .First(e => e.Text == s)
                    .GetAttribute("href");
                this.navigation.GoToUrl(categoryUrl);
            }
        }

        public void ChooseSubCategory(string[] subCategories)
        {
            foreach(string s in subCategories)
            {
                var subCategoryUrl = this.driver.FindElements(By.CssSelector("a"))
                    .First(e => e.Text == s)
                    .GetAttribute("href");
                this.navigation.GoToUrl(subCategoryUrl);
            }
        }
    }
}
