using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Br.Financas.Domain.Interfaces {
    public interface IUnityOfWork {
        void BeginTransaction();
        void Commit();

    }
}
