using Microsoft.VisualStudio.TestTools.UnitTesting;
using GerenciadorTarefas.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GerenciadorTarefas.Models;
using System.Web.Mvc;

namespace GerenciadorTarefas.Controllers.Tests
{
    [TestClass()]
    public class UsuariosControllerTests 
    {
        UsuariosController usuario = new UsuariosController();

        [TestMethod()]
        public void DetailsUsuarioTest()
        {
            //Arrenge
            Usuario usuario = new Usuario();
            int id = 1;

            //Act
            usuario.Id = 1;
            usuario.Nome = "Nome";
            usuario.Senha = "123456";
            usuario.Email = "teste@teste.com";
            int result = usuario.Id;

            //Assert
            Assert.AreEqual(result, id);

        }

        [TestMethod()]
        public void DetailsUsuarioTestFalha()
        {
            //Arrenge
            Usuario usuario = new Usuario();
            int id = 0;

            //Act
            usuario.Id = 1;
            usuario.Nome = "Nome";
            usuario.Senha = "123456";
            usuario.Email = "teste@teste.com";
            int result = usuario.Id;

            //Assert
            Assert.AreNotEqual(result, id);

        }

        [TestMethod()]
        public void DetailsUsuarioTestFalhaNulo()
        {
            //Arrenge
            Usuario usuario = new Usuario();
            int? id = null;

            //Act
            usuario.Id = 1;
            usuario.Nome = "Nome";
            usuario.Senha = "123456";
            usuario.Email = "teste@teste.com";
            int result = usuario.Id;

            //Assert
            Assert.AreNotEqual(result, id);

        }

        [TestMethod()]
        public void DetailsUsuarioTestFalhaNuloConvertidoParaZero()
        {
            //Arrenge
            Usuario usuario = new Usuario();
            int id = 0;

            //Act
            usuario.Id = 0;
            usuario.Nome = "Nome";
            usuario.Senha = "123456";
            usuario.Email = "teste@teste.com";
            int result = usuario.Id;

            //Assert
            Assert.AreEqual(result, id);

        }

    }
}