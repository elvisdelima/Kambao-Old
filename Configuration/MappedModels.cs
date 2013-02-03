using FluentNHibernate.Automapping;
using System;

namespace Kambao.Models
{
    public class MappedModels : DefaultAutomappingConfiguration
    {
        public override bool ShouldMap(Type type)
        {
            return type.Namespace == "Kambao.Models";
               
        }        
    }
}