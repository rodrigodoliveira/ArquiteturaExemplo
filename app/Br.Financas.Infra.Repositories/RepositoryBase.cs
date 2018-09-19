using Br.Financas.Infra.Repositories.Context;
using Microsoft.Practices.ServiceLocation;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Br.Financas.Infra.Repositories {
    public class RepositoryBase<T> : Domain.Interfaces.IRepositoryBase<T> where T : class {

        protected FinancasDbContext Context { get; private set; }

        public RepositoryBase()
        {
            var contextManager = ServiceLocator.Current.GetInstance<ContextManager>();
            Context = contextManager.Context;
        }

        public void Add(T entity)
        {
            Context.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            Context.Set<T>().Remove(entity);
        }

        public void Delete(int id)
        {
            var entity = Get(id);
            Delete(entity);
        }

        public IEnumerable<T> Get()
        {
            return Context.Set<T>().ToList();
        }

        public T Get(int id)
        {
            return Context.Set<T>().Find(id);
        }

        public void Update(T entity)
        {
            Context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
        }
    }
}
