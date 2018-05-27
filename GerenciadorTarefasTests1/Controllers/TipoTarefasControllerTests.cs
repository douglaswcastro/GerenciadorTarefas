using Microsoft.VisualStudio.TestTools.UnitTesting;
using GerenciadorTarefas.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using GerenciadorTarefas.Models;

namespace GerenciadorTarefas.Controllers.Tests
{
    [TestClass()]
    public class TipoTarefasControllerTests : TipoTarefasController 
    {
        
        /*public void DetailsTest()
        {
            //Arrenge
            TipoTarefa mockTipoTarefa = new TipoTarefa();
            TipoTarefa tipoTarefaTeste = new TipoTarefa();
            TipoTarefasControllerTests tipoTarefaEsperado = new TipoTarefasControllerTests();
            TipoTarefasController tipoTaretaAtual = new TipoTarefasController();
            int idTeste;
            string descTeste;

            //Act
            mockTipoTarefa.Id = 1;
            mockTipoTarefa.Descricao = "Teste";

            idTeste = 1;
            descTeste = "Teste";
            tipoTarefaTeste.Id = idTeste;
            tipoTarefaTeste.Descricao = descTeste;

            tipoTaretaAtual.Create(mockTipoTarefa);
            tipoTarefaEsperado.Create(tipoTarefaTeste);

            //Assert
            Assert.AreNotEqual(tipoTarefaEsperado.Create(tipoTarefaTeste), tipoTaretaAtual.Create(mockTipoTarefa));
        }*/
    }
}