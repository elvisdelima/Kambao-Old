using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Kambao.Data.Configuration;
using Kambao.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kambao.Windsor
{
    public class DataInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(AllTypes.FromAssemblyContaining<AutoMapper>()
                    .BasedOn(typeof(CrudData<>))
                    .LifestyleSingleton());
        }
    }
}