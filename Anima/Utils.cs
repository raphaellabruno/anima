using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Anima
{
    public class Utils
    {
        public void ClickButtonBack(IWebDriver driver)
        {
            driver.FindElement(By.LinkText("Voltar")).Click();
            Thread.Sleep(2000);
        }

        public void ClickButtonCommit(IWebDriver driver)
        {
            driver.FindElement(By.Name("commit")).Click();
            Thread.Sleep(2000);
        }
        
        public void ClickButtonStart(IWebDriver driver)
        {
            driver.FindElement(By.LinkText("Começar Automação Web")).Click();
            Thread.Sleep(2000);
        }

        public void ClickMenuForm(IWebDriver driver)
        {
            driver.FindElement(By.LinkText("Formulário")).Click();
            Thread.Sleep(2000);
        }

        public void ClickMenuCreateUser(IWebDriver driver)
        {
            driver.FindElement(By.LinkText("Criar Usuários")).Click();
            Thread.Sleep(2000);
        }

        public void InputName(IWebDriver driver, string text)
        {
            driver.FindElement(By.Id("user_name")).Click();
            driver.FindElement(By.Id("user_name")).Clear();
            driver.FindElement(By.Id("user_name")).SendKeys(text);
        }

        public void InputLastName(IWebDriver driver, string text)
        {
            driver.FindElement(By.Id("user_lastname")).Click();
            driver.FindElement(By.Id("user_lastname")).Clear();
            driver.FindElement(By.Id("user_lastname")).SendKeys(text);
        }

        public void InputEmail(IWebDriver driver, string text)
        {
            driver.FindElement(By.Id("user_email")).Click();
            driver.FindElement(By.Id("user_email")).Clear();
            driver.FindElement(By.Id("user_email")).SendKeys(text);
        }

        public void InputAddress(IWebDriver driver, string text)
        {
            driver.FindElement(By.Id("user_address")).Click();
            driver.FindElement(By.Id("user_address")).Clear();
            driver.FindElement(By.Id("user_address")).SendKeys(text);
        }

        public void InputUniversity(IWebDriver driver, string text)
        {
            driver.FindElement(By.Id("user_university")).Click();
            driver.FindElement(By.Id("user_university")).Clear();
            driver.FindElement(By.Id("user_university")).SendKeys(text);
        }

        public void InputProfile(IWebDriver driver, string text)
        {
            driver.FindElement(By.Id("user_profile")).Click();
            driver.FindElement(By.Id("user_profile")).Clear();
            driver.FindElement(By.Id("user_profile")).SendKeys(text);
        }

        public void InputGender(IWebDriver driver, string text)
        {
            driver.FindElement(By.Id("user_gender")).Click();
            driver.FindElement(By.Id("user_gender")).Clear();
            driver.FindElement(By.Id("user_gender")).SendKeys(text);
        }

        public void InputAge(IWebDriver driver, string text)
        {
            driver.FindElement(By.Id("user_age")).Click();
            driver.FindElement(By.Id("user_age")).Clear();
            driver.FindElement(By.Id("user_age")).SendKeys(text);
        }

        public void VerifyName(IWebDriver driver)
        {
            string name;
            name = driver.FindElement(By.Id("user_name")).Text;
            Assert.IsTrue(name != null);
        }

        public void VerifyLastName(IWebDriver driver)
        {
            string lastName;
            lastName = driver.FindElement(By.Id("user_lastname")).Text;
            Assert.IsTrue(lastName != null);
        }

        public void VerifyEmail(IWebDriver driver)
        {
            string email;
            email = driver.FindElement(By.Id("user_email")).Text;
            Assert.IsTrue(email != null);
        }

    }
}
