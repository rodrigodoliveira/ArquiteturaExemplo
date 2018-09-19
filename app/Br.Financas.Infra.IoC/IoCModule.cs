using Br.Financas.Domain.Interfaces;
using Br.Financas.Infra.Repositories;
using Br.Financas.Infra.Repositories.Context;
using Ninject.Modules;

namespace Br.Financas.Infra.IoC {
    public class IoCModule : NinjectModule {

        public override void Load()
        {
            Bind(typeof(IRepositoryBase<>)).To(typeof(RepositoryBase<>));
            Bind<IProductRepository>().To<ProductRepository>();
            Bind<IUnityOfWork>().To<UnityOfWork>();
            Bind<ContextManager>().ToSelf();
        }
    }
}
