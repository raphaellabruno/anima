using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Anima
{
    public class CadastroPageObjetcs
    {
        private IWebDriver driver;
        private By byMenuForm;
        private By byMenuCreateUser;
        private By byInputName;
        private By byInputLastName;
        private By byInputEmail;
        private By byInputAddress;
        private By byInputUniversity;
        private By byInputProfile;
        private By byInputGender;
        private By byInputAge;
        private By byButtonRegister;

        public CadastroPageObjetcs(IWebDriver driver) //injeção de dependencias, depende do webdriver
        {
            this.driver = driver;
            byMenuForm = By.LinkText("Formulário");
            byMenuCreateUser = By.LinkText("Criar Usuários");
            byInputName = By.Id("user_name");
            byInputLastName = By.Id("user_lastname");
            byInputEmail = By.Id("user_email");
            byInputAddress = By.Id("user_address");
            byInputUniversity = By.Id("user_university");
            byInputProfile = By.Id("user_profile");
            byInputGender = By.Id("user_gender");
            byInputAge = By.Id("user_age");
            byButtonRegister = By.Name("commit");
        }

        internal void PreencheFormulario(
            string nome, 
            string sobrenome, 
            string email, 
            string endereco, 
            string universidade, 
            string perfil, 
            string genero, 
            string idade)
        {
            driver.FindElement(byInputName).SendKeys(nome);
            driver.FindElement(byInputLastName).SendKeys(sobrenome);
            driver.FindElement(byInputEmail).SendKeys(email);
            driver.FindElement(byInputAddress).SendKeys(endereco);
            driver.FindElement(byInputUniversity).SendKeys(universidade);
            driver.FindElement(byInputProfile).SendKeys(perfil);
            driver.FindElement(byInputGender).SendKeys(genero);
            driver.FindElement(byInputAge).SendKeys(idade);
        }

        public void VerificarCamposObrigatorios()
        {

            utils.VerifyName(driver);
            utils.VerifyLastName(driver);
            utils.VerifyEmail(driver);
           

        }

        public void Visitar()
        {
            driver.Navigate().GoToUrl("https://automacaocombatista.herokuapp.com/home/index");
            //driver.Manage().Window.Maximize();
            Assert.AreEqual("Automação com Batista", driver.Title);
            //Validar URL
            Assert.AreEqual("https://automacaocombatista.herokuapp.com/home/index", driver.Url);
           
            
            utils.ClickButtonStart(driver);
            utils.ClickMenuForm(driver);
            utils.ClickMenuCreateUser(driver);


        }

        public void SubmeteFormulario()
        {
            driver.FindElement(byButtonRegister).Click();           
        }

    }
}
