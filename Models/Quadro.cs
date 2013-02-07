using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kambao.Models
{
    public abstract class Quadro
    {
        public virtual List<Faixa> faixas { get; set; }
        public virtual List<Tarefa> tarefas { get; set; }

        public Quadro(List<Faixa> faixas, List<Tarefa> tarefas)
        {
            this.faixas = faixas;
            this.tarefas = tarefas;
        }
    }
}