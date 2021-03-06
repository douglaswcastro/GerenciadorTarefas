using GerenciadorTarefas.Models;
using System.Web.Mvc;
// <copyright file="TarefasControllerTest.cs">Copyright ©  2018</copyright>

using System;
using GerenciadorTarefas.Controllers;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GerenciadorTarefas.Controllers.Tests
{
    [TestClass]
    [PexClass(typeof(TarefasController))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class TarefasControllerTest
    {

        [PexMethod(MaxBranches = 20000)]
        public ActionResult Create([PexAssumeUnderTest]TarefasController target, Tarefa tarefa)
        {
            ActionResult result = target.Create(tarefa);
            return result;
            // TODO: add assertions to method TarefasControllerTest.Create(TarefasController, Tarefa)
        }
    }
}
