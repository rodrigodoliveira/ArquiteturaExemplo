using System.Collections.Generic;

namespace Br.Financas.Domain.Interfaces.Application {

    public interface IApplicationBase<T> where T : class {

        void Add(T entity);
        void Delete(int id);
        void Delete(T entity);
        T Get(int id);
        IEnumerable<T> Get();
        void Update(T entity);
    }
}
