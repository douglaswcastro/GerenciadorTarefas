using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GerenciadorTarefas.Controllers
{
    public class TipoTarefaController : Controller
    {
        //Variaveis privadas da classe TipoTarefa
        private string idTarefa, nomeTarefa;

        //Metodo para verificar os tipos de Tarefas existentes.
        public void verificaTarefa(string id, string nome)
        {
            this.idTarefa = id;
            this.nomeTarefa = nome;
        }


        //Metodos Get e Set para ID
        public string getIdTarefa()
        {
            return idTarefa;
        }
        public string setIdTarefa(string id)
        {
            this.idTarefa = id;
            return idTarefa;
        }


        //Metodo Get e Set para Nome
        public string getNomeTarefa()
        {
            return nomeTarefa;
        }
        public string setNomeTarefa(string nome)
        {
            this.nomeTarefa = nome;
            return nomeTarefa;
        }

    }
}