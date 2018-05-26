using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using GerenciadorTarefas.Models;

namespace GerenciadorTarefas.Controllers
{
    public class LoginController : Controller
    {
        private DBDTECEntities1 db = new DBDTECEntities1();
        public ActionResult Login(string Email, string Senha)
        {

            return View();

        }

        public ActionResult Logar(string Email, string Senha)
        {
            Usuario usuario = db.Usuario
                .Where(u => u.Email == Email)
                .FirstOrDefault(u => u.Senha == Senha);
            if (usuario != null)
            {
                Session["Usuario"] = usuario.Nome;
                return RedirectToAction("Index","Tarefas");
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        public ActionResult Logout()
        {
            Session["Usuario"] = null;
            return RedirectToAction("Logout", "Login");
        }

        //Variaveis privadas da classe Login
        private string nick, pass;

        //Metodo para realizar login
        public void loginAcesso(string login, string senha)
        {
            this.nick = login;
            this.pass = senha;

        }

        //Metodos Get e Set para Login
        public string getLogin()
        {
            return nick;
        }
        public string setLogin(string login)
        {
            this.nick = login;
            return nick;
        }

        //Metodos Get e Set para Senha
        public string getSenha()
        {
            return pass;
        }
        public string setSenha(string senha)
        {
            this.pass = senha;
            return pass;
        }


    }
}