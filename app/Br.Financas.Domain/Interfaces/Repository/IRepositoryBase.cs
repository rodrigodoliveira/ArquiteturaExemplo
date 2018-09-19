using System.Collections.Generic;

namespace Br.Financas.Domain.Interfaces {
    public interface IRepositoryBase<T> where T : class {

        void Add(T entity);
        void Delete(int id);
        void Delete(T entity);
        T Get(int id);
        IEnumerable<T> Get();
        void Update(T entity);
    }
}
