using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Castle.MicroKernel.SubSystems.Configuration;
using Wonderboyz.Data;

namespace Wonderboyz.Web.Plumbing.Installers
{
    public class RepositoryInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(FindDataAccess().Configure(c => c.LifestyleTransient()));
        }

        private BasedOnDescriptor FindDataAccess()
        {
            return Classes.FromAssemblyNamed("Wonderboyz.Data")
                .InSameNamespaceAs<Wonderboyz.Data.RepositoryBase>()
                .If(t => t.Name.EndsWith("Repository"))
                .WithService.DefaultInterfaces();
        }
    }
}