using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using Xunit;

namespace Anima
{
    [Binding]

    public class TestsWithPageObjetcs : WebDriver
    {
        CadastroPageObjetcs cadastro = new CadastroPageObjetcs(driver);
        Utils utils = new Utils();

        [Fact]
        public void ValidarAcessoNaPagina()
        {
            //arrange
            var cadastroPageObjetcs = new CadastroPageObjetcs(driver);
            cadastroPageObjetcs.Visitar();
            //act
            //assert
            //Validar título
            Assert.AreEqual("Automação com Batista", driver.Title);
            //Validar URL
            Assert.AreEqual("https://automacaocombatista.herokuapp.com/home/index", driver.Url);
        }

        [Fact]
        public void CadastrarComSucesso() // Criar excessões e testes que dêem erro, guardando a mensagem de erro e fazendo um assert
        {
            //arrange
            var cadastroPageObjetcs = new CadastroPageObjetcs(driver);
            cadastroPageObjetcs.Visitar();

            cadastroPageObjetcs.PreencheFormulario(
                nome: "Joaquina",
                sobrenome: "Silva",
                email: "joaquina@hotmail.com",
                endereco: "Avenida Santana,500",
                universidade: "UNASP",
                perfil: "Joaquina",
                genero: "Feminino",
                idade: "23"
               );

            //act
            cadastroPageObjetcs.VerificarCamposObrigatorios();
            cadastroPageObjetcs.SubmeteFormulario();


            //assert
            //Capturar uma mensagem de sucesso
        }

        [Fact]
        public void Voltar()
        {
            utils.ClickButtonStart(driver);
            utils.ClickMenuForm(driver);
            utils.ClickMenuCreateUser(driver);
            utils.ClickButtonBack(driver);            
        }

    }
}

