using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GerenciadorTarefas.Models;

namespace GerenciadorTarefas.Controllers
{
    public class TarefasController : Controller
    {
        private DBDTECEntities1 db = new DBDTECEntities1();

        // GET: Tarefas
        public ActionResult Index()
        {
            var tarefa = db.Tarefa.Include(t => t.Prioridade).Include(t => t.Status).Include(t => t.Usuario).Include(t => t.TipoTarefa);
            return View(tarefa.ToList());
        }

        // GET: Tarefas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tarefa tarefa = db.Tarefa.Find(id);
            if (tarefa == null)
            {
                return HttpNotFound();
            }
            return View(tarefa);
        }

        // GET: Tarefas/Create
        public ActionResult Create()
        {
            ViewBag.PrioridadeId = new SelectList(db.Prioridade, "Id", "Descricao");
            ViewBag.StatusId = new SelectList(db.Status, "Id", "Descricao");
            ViewBag.UsuarioId = new SelectList(db.Usuario, "Id", "Nome");
            ViewBag.TipoTarefaId = new SelectList(db.TipoTarefa, "Id", "Descricao");
            return View();
        }

        // POST: Tarefas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Titulo,Descricao,DataCriacao,DataTermino,StatusId,PrioridadeId,UsuarioId,TipoTarefaId")] Tarefa tarefa)
        {
            if (ModelState.IsValid)
            {
                db.Tarefa.Add(tarefa);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.PrioridadeId = new SelectList(db.Prioridade, "Id", "Descricao", tarefa.PrioridadeId);
            ViewBag.StatusId = new SelectList(db.Status, "Id", "Descricao", tarefa.StatusId);
            ViewBag.UsuarioId = new SelectList(db.Usuario, "Id", "Nome", tarefa.UsuarioId);
            ViewBag.TipoTarefaId = new SelectList(db.TipoTarefa, "Id", "Descricao", tarefa.TipoTarefaId);
            return View(tarefa);
        }

        // GET: Tarefas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tarefa tarefa = db.Tarefa.Find(id);
            if (tarefa == null)
            {
                return HttpNotFound();
            }
            ViewBag.PrioridadeId = new SelectList(db.Prioridade, "Id", "Descricao", tarefa.PrioridadeId);
            ViewBag.StatusId = new SelectList(db.Status, "Id", "Descricao", tarefa.StatusId);
            ViewBag.UsuarioId = new SelectList(db.Usuario, "Id", "Nome", tarefa.UsuarioId);
            ViewBag.TipoTarefaId = new SelectList(db.TipoTarefa, "Id", "Descricao", tarefa.TipoTarefaId);
            return View(tarefa);
        }

        // POST: Tarefas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Titulo,Descricao,DataCriacao,DataTermino,StatusId,PrioridadeId,UsuarioId,TipoTarefaId")] Tarefa tarefa)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tarefa).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PrioridadeId = new SelectList(db.Prioridade, "Id", "Descricao", tarefa.PrioridadeId);
            ViewBag.StatusId = new SelectList(db.Status, "Id", "Descricao", tarefa.StatusId);
            ViewBag.UsuarioId = new SelectList(db.Usuario, "Id", "Nome", tarefa.UsuarioId);
            ViewBag.TipoTarefaId = new SelectList(db.TipoTarefa, "Id", "Descricao", tarefa.TipoTarefaId);
            return View(tarefa);
        }

        // GET: Tarefas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tarefa tarefa = db.Tarefa.Find(id);
            if (tarefa == null)
            {
                return HttpNotFound();
            }
            return View(tarefa);
        }

        // POST: Tarefas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Tarefa tarefa = db.Tarefa.Find(id);
            db.Tarefa.Remove(tarefa);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
