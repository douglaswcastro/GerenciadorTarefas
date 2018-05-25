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
            tarefa.Prioridade = 3;
            tarefa.Status = 1;
            tarefa.Titulo = "Nova Tarefa";
            tarefa.Descricao = "Teste";
            tarefa.UsuarioId = 1;
            bool result = tarefas.Criar(tarefa);
            Assert.IsFalse(result, "Não foi realizado o Cadastro");
            //Assert.Fail("Erro ao cadastrar");

        }
        [TestMethod()]
        public void EditTest()
        {

            Tarefa tarefa = new Tarefa();
            tarefa.Prioridade = 3;
            tarefa.Status = 1;
            tarefa.Titulo = "Nova Tarefa";
            tarefa.Descricao = "Teste";
            tarefa.UsuarioId = 1;
            tarefa.Id = 1;
            bool result = tarefas.Editar(tarefa);
            Assert.IsFalse(result, "Não foi editado");
        }
        [TestMethod()]
        public void DeleteTest()
        {
           
            int id = 3;
            bool result = tarefas.Deletar(id);
            Assert.IsFalse(result, "Não foi realizado a Exclusao");
            //Assert.Fail();
        }

        [TestMethod()]
        public void DetailsTarefasTest()
        {
            //Arrenge
            Tarefa tarefa = new Tarefa();
            int id = 1;

            //Act
            tarefa.Prioridade = 3;
            tarefa.Status = 1;
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
            tarefa.Prioridade = 3;
            tarefa.Status = 1;
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
            tarefa.Prioridade = 3;
            tarefa.Status = 1;
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
            tarefa.Prioridade = 3;
            tarefa.Status = 1;
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
            bool criado = true;

            //Act
            tarefa.Prioridade = 3;
            tarefa.Status = 1;
            tarefa.Titulo = "Nova Tarefa";
            tarefa.Descricao = "Teste";
            tarefa.UsuarioId = 1;
            tarefa.Id = 0;
            criado = tarefas.Criar(tarefa);

            //Assert
            Assert.IsFalse(criado);

        }


    }
}