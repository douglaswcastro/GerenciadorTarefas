using Microsoft.VisualStudio.TestTools.UnitTesting;
using GerenciadorTarefas.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorTarefas.Controllers.Tests
{
    [TestClass()]
    public class LoginControllerTests : LoginController
    {
        [TestMethod()]
        public void loginAcessoTest()
        {
            /*Esse teste é executado para verificar se o login digitado corresponde com ao login passada como parametro*/
            //Arrenge
            string login = "Teste";
            string senha = "123456";
            LoginController MockAcessoAtual = new LoginController();
            LoginControllerTests acessoEsperado = new LoginControllerTests();

            //Act
            MockAcessoAtual.loginAcesso(setLogin("Teste"), setSenha("123456"));
            acessoEsperado.loginAcesso(login, senha);

            //Assert
            Assert.AreEqual(acessoEsperado.getLogin(), MockAcessoAtual.getLogin());
        }

        [TestMethod()]
        public void senhaAcessoTest()
        {
            /*Esse teste é executado para verificar se a senha digitada corresponde com a senha passada como parametro*/
            //Arrenge
            string login = "Teste";
            string senha = "123456";
            LoginController MockAcessoAtual = new LoginController();
            LoginControllerTests acessoEsperado = new LoginControllerTests();

            //Act
            MockAcessoAtual.loginAcesso(setLogin("Teste"), setSenha("123456"));
            acessoEsperado.loginAcesso(login, senha);

            //Assert
            Assert.AreEqual(acessoEsperado.getSenha(), MockAcessoAtual.getSenha());
        }

        [TestMethod()]
        public void loginAcessoTestFalha()
        {
            /*Esse teste é executado para verificar falha de login*/
            //Arrenge
            string login = "Teste";
            string senha = "123456";
            LoginController MockAcessoAtual = new LoginController();
            LoginControllerTests acessoEsperado = new LoginControllerTests();

            //Act
            MockAcessoAtual.loginAcesso(setLogin("test"), setSenha("123456"));
            acessoEsperado.loginAcesso(login, senha);

            //Assert
            Assert.AreNotEqual(acessoEsperado.getLogin(), MockAcessoAtual.getLogin());
        }

        [TestMethod()]
        public void loginAcessoTestFalhaSemLogin()
        {
            /*Esse teste é executado para verificar falha de login*/
            //Arrenge
            string login = "Teste";
            string senha = "123456";
            LoginController MockAcessoAtual = new LoginController();
            LoginControllerTests acessoEsperado = new LoginControllerTests();

            //Act
            MockAcessoAtual.loginAcesso(setLogin(""), setSenha("123456"));
            acessoEsperado.loginAcesso(login, senha);

            //Assert
            Assert.AreNotEqual(acessoEsperado.getLogin(), MockAcessoAtual.getLogin());
        }

        [TestMethod()]
        public void senhaAcessoTestFalha()
        {
            /*Esse teste é executado para verificar falha de senha*/
            //Arrenge
            string login = "Teste";
            string senha = "123456";
            LoginController MockAcessoAtual = new LoginController();
            LoginControllerTests acessoEsperado = new LoginControllerTests();

            //Act
            MockAcessoAtual.loginAcesso(setLogin("Teste"), setSenha("123"));
            acessoEsperado.loginAcesso(login, senha);

            //Assert
            Assert.AreNotEqual(acessoEsperado.getSenha(), MockAcessoAtual.getSenha());
        }

        [TestMethod()]
        public void senhaAcessoTestFalhaSemSenha()
        {
            /*Esse teste é executado para verificar falha de senha*/
            //Arrenge
            string login = "Teste";
            string senha = "123456";
            LoginController MockAcessoAtual = new LoginController();
            LoginControllerTests acessoEsperado = new LoginControllerTests();

            //Act
            MockAcessoAtual.loginAcesso(setLogin("Teste"), setSenha(""));
            acessoEsperado.loginAcesso(login, senha);

            //Assert
            Assert.AreNotEqual(acessoEsperado.getSenha(), MockAcessoAtual.getSenha());
        }

        [TestMethod()]
        public void loginSenhaAcessoTest()
        {
            /*Esse teste é executado para verificar se login e senha são compatíveis*/
            //Arrenge
            string login = "Teste";
            string senha = "123456";
            LoginController MockAcessoAtual = new LoginController();
            LoginControllerTests acessoEsperado = new LoginControllerTests();

            //Act
            MockAcessoAtual.loginAcesso(setLogin("Teste"), setSenha("123456"));
            acessoEsperado.loginAcesso(login, senha);

            //Assert
            Assert.AreEqual(acessoEsperado.getLogin(), MockAcessoAtual.getLogin());
            Assert.AreEqual(acessoEsperado.getSenha(), MockAcessoAtual.getSenha());
        }

        [TestMethod()]
        public void loginSenhaAcessoTestFalha()
        {
            /*Esse teste é executado para verificar se login e senha não serão compatíveis*/
            //Arrenge
            string login = "Teste";
            string senha = "123456";
            LoginController MockAcessoAtual = new LoginController();
            LoginControllerTests acessoEsperado = new LoginControllerTests();

            //Act
            MockAcessoAtual.loginAcesso(setLogin("Tee"), setSenha("156"));
            acessoEsperado.loginAcesso(login, senha);

            //Assert
            Assert.AreNotEqual(acessoEsperado.getLogin(), MockAcessoAtual.getLogin());
            Assert.AreNotEqual(acessoEsperado.getSenha(), MockAcessoAtual.getSenha());
        }

        [TestMethod()]
        public void loginSenhaAcessoTestFalhaSemValores()
        {
            /*Esse teste é executado para verificar se login e senha não serão compatíveis*/
            //Arrenge
            string login = "Teste";
            string senha = "123456";
            LoginController MockAcessoAtual = new LoginController();
            LoginControllerTests acessoEsperado = new LoginControllerTests();

            //Act
            MockAcessoAtual.loginAcesso(setLogin(""), setSenha(""));
            acessoEsperado.loginAcesso(login, senha);

            //Assert
            Assert.AreNotEqual(acessoEsperado.getLogin(), MockAcessoAtual.getLogin());
            Assert.AreNotEqual(acessoEsperado.getSenha(), MockAcessoAtual.getSenha());
        }

    }
}