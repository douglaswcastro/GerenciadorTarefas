using Microsoft.VisualStudio.TestTools.UnitTesting;
using GerenciadorTarefas.Models;
using System.Web.Mvc;
using GerenciadorTarefas.Controllers;
using Microsoft.Pex.Framework.Generated;
// <copyright file="TarefasControllerTest.Create.g.cs">Copyright ©  2018</copyright>
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace GerenciadorTarefas.Controllers.Tests
{
    public partial class TarefasControllerTest
    {

[TestMethod]
[PexGeneratedBy(typeof(TarefasControllerTest))]
[Ignore]
[PexDescription("the test state was: path bounds exceeded")]
public void Create01()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      TarefasController tarefasController;
      ActionResult actionResult;
      tarefasController = new TarefasController();
      ((Controller)tarefasController).Resolver = (IDependencyResolver)null;
      ((Controller)tarefasController).ActionInvoker = (IActionInvoker)null;
      ((Controller)tarefasController).TempDataProvider = (ITempDataProvider)null;
      ((Controller)tarefasController).Url = (UrlHelper)null;
      ((Controller)tarefasController).ViewEngineCollection =
        (ViewEngineCollection)null;
      ((ControllerBase)tarefasController).ControllerContext =
        (ControllerContext)null;
      ((ControllerBase)tarefasController).TempData = (TempDataDictionary)null;
      ((ControllerBase)tarefasController).ValidateRequest = false;
      ((ControllerBase)tarefasController).ValueProvider = (IValueProvider)null;
      ((ControllerBase)tarefasController).ViewData = (ViewDataDictionary)null;
      disposables.Add((IDisposable)tarefasController);
      actionResult = this.Create(tarefasController, (Tarefa)null);
      disposables.Dispose();
    }
}
    }
}
