using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kambao.Models
{
    public class Tarefas
    {
        public virtual long Id { get; set; }
        public virtual string Codigo { get; set; }
        public virtual string Descricao { get; set; }
    }
}