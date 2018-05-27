using Microsoft.VisualStudio.TestTools.UnitTesting;
using GerenciadorTarefas.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GerenciadorTarefas.Models;
using System.Web.Mvc;

namespace GerenciadorTarefas.Tests
{
    [TestClass()]
    public class TarefaTests
    {
        TarefasController tarefas = new TarefasController();
        [TestMethod()]
        public void CreateTest()
        {

            Tarefa tarefa = new Tarefa();
            bool result = false;

            tarefa.Titulo = "Nova Tarefa";
            tarefa.Descricao = "Teste";
            tarefa.UsuarioId = 1;
            
            if(tarefas.Create() != null)
            {
                result = true;
            }

            Assert.IsTrue(result, "Não foi realizado o Cadastro");
            //Assert.Fail("Erro ao cadastrar");

        }


        [TestMethod()]
        public void DetailsTarefasTest()
        {
            //Arrenge
            Tarefa tarefa = new Tarefa();
            int id = 1;

            //Act
            tarefa.Titulo = "Nova Tarefa";
            tarefa.Descricao = "Teste";
            tarefa.UsuarioId = 1;
            tarefa.Id = 1;
            int result = tarefa.Id;

            //Assert
            Assert.AreEqual(result, id);
            
        }

        [TestMethod()]
        public void DetailsTarefasTestFalha()
        {
            //Arrenge
            Tarefa tarefa = new Tarefa();
            int id = 0;

            //Act
            tarefa.Titulo = "Nova Tarefa";
            tarefa.Descricao = "Teste";
            tarefa.UsuarioId = 1;
            tarefa.Id = 1;
            int result = tarefa.Id;

            //Assert
            Assert.AreNotEqual(result, id);

        }

        [TestMethod()]
        public void DetailsTarefasTestFalhaNulo()
        {
            //Arrenge
            Tarefa tarefa = new Tarefa();
            int? id = null;

            //Act
            tarefa.Titulo = "Nova Tarefa";
            tarefa.Descricao = "Teste";
            tarefa.UsuarioId = 1;
            tarefa.Id = 1;
            int? result = tarefa.Id;

            //Assert
            Assert.AreNotEqual(result, id);

        }

        [TestMethod()]
        public void DetailsTarefasTestFalhaNuloConvertidoParaZero()
        {
            //Arrenge
            Tarefa tarefa = new Tarefa();
            int? id = 0;

            //Act
            tarefa.Titulo = "Nova Tarefa";
            tarefa.Descricao = "Teste";
            tarefa.UsuarioId = 1;
            tarefa.Id = 0;
            int? result = tarefa.Id;

            //Assert
            Assert.AreEqual(result, id);

        }

        [TestMethod()]
        public void CriarTarefasTestFalha()
        {
            //Arrenge
            Tarefa tarefa = new Tarefa();
            bool result = false;
            //Act
            tarefa.Titulo = "Nova Tarefa";
            tarefa.Descricao = "Teste";
            tarefa.UsuarioId = 1;
            tarefa.Id = 0;

            if (tarefas.Create() != null)
            {
                result = true;
            }
            //Assert
            Assert.IsTrue(result);

        }


    }
}