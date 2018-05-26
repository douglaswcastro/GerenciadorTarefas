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
    public class TipoTarefaControllerTests : TipoTarefasController
    {
        [TestMethod()]
        public void verificaTarefaTest()
        {
            //Arrenge
            int idTest = 1;
            string nomeTest = "Tarefa Teste";

            TipoTarefaControllerTests tipoTarefaEsperado = new TipoTarefaControllerTests();
            TipoTarefasController MockTipoTarefaAtual = new TipoTarefasController();

            //Act
            tipoTarefaEsperado.verificaTarefa(idTest, nomeTest);
            MockTipoTarefaAtual.verificaTarefa(setIdTarefa(1), setNomeTarefa("Tarefa Teste"));

            //Assert
            Assert.AreEqual(tipoTarefaEsperado.getIdTarefa(), MockTipoTarefaAtual.getIdTarefa());
            Assert.AreEqual(tipoTarefaEsperado.getNomeTarefa(), MockTipoTarefaAtual.getNomeTarefa());
        }

        [TestMethod()]
        public void verificaTarefaTestFalha()
        {
            //Arrenge
            int idTest = 1;
            string nomeTest = "Tarefa Teste";

            TipoTarefaControllerTests tipoTarefaEsperado = new TipoTarefaControllerTests();
            TipoTarefasController MockTipoTarefaAtual = new TipoTarefasController();

            //Act
            tipoTarefaEsperado.verificaTarefa(idTest, nomeTest);
            MockTipoTarefaAtual.verificaTarefa(setIdTarefa(5), setNomeTarefa("Tarefa Manutenção"));

            //Assert
            Assert.AreNotEqual(tipoTarefaEsperado.getIdTarefa(), MockTipoTarefaAtual.getIdTarefa());
            Assert.AreNotEqual(tipoTarefaEsperado.getNomeTarefa(), MockTipoTarefaAtual.getNomeTarefa());
        }

        [TestMethod()]
        public void verificaTarefaTestFalhaSemValores()
        {
            //Arrenge
            int idTest = 1;
            string nomeTest = "Tarefa Teste";

            TipoTarefaControllerTests tipoTarefaEsperado = new TipoTarefaControllerTests();
            TipoTarefasController MockTipoTarefaAtual = new TipoTarefasController();

            //Act
            tipoTarefaEsperado.verificaTarefa(idTest, nomeTest);
            MockTipoTarefaAtual.verificaTarefa(setIdTarefa(0), setNomeTarefa(""));

            //Assert
            Assert.AreNotEqual(tipoTarefaEsperado.getIdTarefa(), MockTipoTarefaAtual.getIdTarefa());
            Assert.AreNotEqual(tipoTarefaEsperado.getNomeTarefa(), MockTipoTarefaAtual.getNomeTarefa());
        }

        [TestMethod()]
        public void verificaTarefaTestFalhaSemId()
        {
            //Arrenge
            int idTest = 1;
            string nomeTest = "Tarefa Teste";

            TipoTarefaControllerTests tipoTarefaEsperado = new TipoTarefaControllerTests();
            TipoTarefasController MockTipoTarefaAtual = new TipoTarefasController();

            //Act
            tipoTarefaEsperado.verificaTarefa(idTest, nomeTest);
            MockTipoTarefaAtual.verificaTarefa(setIdTarefa(0), setNomeTarefa("Tarefa Manutenção"));

            //Assert
            Assert.AreNotEqual(tipoTarefaEsperado.getIdTarefa(), MockTipoTarefaAtual.getIdTarefa());
            
        }

        [TestMethod()]
        public void verificaTarefaTestFalhaSemNome()
        {
            //Arrenge
            int idTest = 1;
            string nomeTest = "Tarefa Teste";

            TipoTarefaControllerTests tipoTarefaEsperado = new TipoTarefaControllerTests();
            TipoTarefasController MockTipoTarefaAtual = new TipoTarefasController();

            //Act
            tipoTarefaEsperado.verificaTarefa(idTest, nomeTest);
            MockTipoTarefaAtual.verificaTarefa(setIdTarefa(5), setNomeTarefa(""));

            //Assert
            Assert.AreNotEqual(tipoTarefaEsperado.getNomeTarefa(), MockTipoTarefaAtual.getNomeTarefa());
        }

    }
}