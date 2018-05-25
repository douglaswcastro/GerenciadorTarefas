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
    public class TipoTarefaControllerTests : TipoTarefaController
    {
        [TestMethod()]
        public void verificaTarefaTest()
        {
            //Arrenge
            string idTest = "1";
            string nomeTest = "Tarefa Teste";

            TipoTarefaControllerTests tipoTarefaEsperado = new TipoTarefaControllerTests();
            TipoTarefaController MockTipoTarefaAtual = new TipoTarefaController();

            //Act
            tipoTarefaEsperado.verificaTarefa(idTest, nomeTest);
            MockTipoTarefaAtual.verificaTarefa(setIdTarefa("1"), setNomeTarefa("Tarefa Teste"));

            //Assert
            Assert.AreEqual(tipoTarefaEsperado.getIdTarefa(), MockTipoTarefaAtual.getIdTarefa());
            Assert.AreEqual(tipoTarefaEsperado.getNomeTarefa(), MockTipoTarefaAtual.getNomeTarefa());
        }

        [TestMethod()]
        public void verificaTarefaTestFalha()
        {
            //Arrenge
            string idTest = "1";
            string nomeTest = "Tarefa Teste";

            TipoTarefaControllerTests tipoTarefaEsperado = new TipoTarefaControllerTests();
            TipoTarefaController MockTipoTarefaAtual = new TipoTarefaController();

            //Act
            tipoTarefaEsperado.verificaTarefa(idTest, nomeTest);
            MockTipoTarefaAtual.verificaTarefa(setIdTarefa("5"), setNomeTarefa("Tarefa Manutenção"));

            //Assert
            Assert.AreNotEqual(tipoTarefaEsperado.getIdTarefa(), MockTipoTarefaAtual.getIdTarefa());
            Assert.AreNotEqual(tipoTarefaEsperado.getNomeTarefa(), MockTipoTarefaAtual.getNomeTarefa());
        }
    }
}