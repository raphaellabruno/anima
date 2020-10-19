using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using Assert = NUnit.Framework.Assert;
using TestContext = NUnit.Framework.TestContext;

namespace Anima
{
    [Binding]
    //[TestFixture]
    public class Tests : WebDriver
    {
        CadastroPageObjects cadastro = new CadastroPageObjects();
        Utils utils = new Utils();

        [Test]
        public void ValidarAcessoAutomacao()
        {
            Assert.AreEqual("Automação com Batista", driver.Title);
        }

        [Test]
        public void ValidarUrl()
        {
            Assert.AreEqual("https://automacaocombatista.herokuapp.com/home/index", driver.Url);
        }

        [Test]
        public void CadastrarUsuario()
        {
            utils.ClickButtonStart(driver);
            utils.ClickMenuForm(driver);
            utils.ClickMenuCreateUser(driver);
            utils.InputName(driver, "Joaquina");
            utils.InputLastName(driver, "Silva");
            utils.InputEmail(driver, "joaquina@hotmail.com");
            utils.InputAddress(driver, "Avenida Santana,500");
            utils.InputUniversity(driver, "UNASP");
            utils.InputProfile(driver, "Joaquina");
            utils.InputGender(driver, "Feminino");
            utils.InputAge(driver, "23");
            utils.ClickButtonCommit(driver);
            Thread.Sleep(3000);
        }

        [Test]
        public void CamposObrigatorios()
        {
            utils.ClickButtonStart(driver);
            utils.ClickMenuForm(driver);
            utils.ClickMenuCreateUser(driver);
            utils.InputName(driver, "Joaquina");
            utils.InputLastName(driver, "Silva");
            utils.InputEmail(driver, "joaquina@hotmail.com");
            utils.InputAddress(driver, "Avenida Santana,500");
            utils.InputUniversity(driver, "UNASP");
            utils.InputProfile(driver, "Joaquina");
            utils.InputGender(driver, "Feminino");
            utils.InputAge(driver, "23");
            utils.VerifyName(driver);
            utils.VerifyLastName(driver);
            utils.VerifyEmail(driver);
            Thread.Sleep(3000);
        }

        [Test]
        public void Voltar()
        {
            utils.ClickButtonStart(driver);
            utils.ClickMenuForm(driver);
            utils.ClickMenuCreateUser(driver);
            utils.ClickButtonBack(driver);            
        }

       
    }
}

