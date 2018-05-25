using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GerenciadorTarefas.Controllers
{
    public class LoginController : Controller
    {
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