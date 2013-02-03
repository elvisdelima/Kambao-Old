using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kambao.Models
{
    public class Tarefa
    {
        public virtual int Id { get; set; }
        public virtual string Codigo { get; set; }
        public virtual string Descricao { get; set; }
    }
}