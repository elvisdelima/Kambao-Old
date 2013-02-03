using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FluentNHibernate.Automapping;
using FluentNHibernate.Automapping.Alterations;
using Kambao.Models;

namespace Kambao.Configuration.MappingOverrides
{
    public class OverrideTarefa : IAutoMappingOverride<Tarefa>
    {
        public void Override(AutoMapping<Tarefa> mapping) 
        {
            mapping.Id(x => x.Id);
        } 
    }
}
