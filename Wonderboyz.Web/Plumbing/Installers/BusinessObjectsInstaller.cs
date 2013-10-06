using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Castle.MicroKernel.SubSystems.Configuration;
using Wonderboyz.BusinessObjects;

namespace Wonderboyz.Web.Plumbing.Installers
{
    public class BusinessObjectsInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(FindBOs().Configure(c => c.LifestyleTransient()));
        }

        private BasedOnDescriptor FindBOs()
        {
            return Classes.FromAssemblyNamed("Wonderboyz.BusinessObjects")
                .InSameNamespaceAs<Wonderboyz.BusinessObjects.BusinessObjectBase>()
                .If(t => t.Name.EndsWith("BusinessObject"))
                .WithService.DefaultInterfaces();
        }
    }
}