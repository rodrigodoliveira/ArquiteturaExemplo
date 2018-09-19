using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Br.Financas.Infra.IoC {
    public class IoCDependencyResolver : IDependencyResolver {

        public object GetService(Type serviceType)
        {
            return IoC.GetService(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return IoC.GetServices(serviceType);
        }
    }
}
