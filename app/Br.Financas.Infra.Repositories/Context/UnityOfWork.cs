using Br.Financas.Domain.Interfaces;
using Microsoft.Practices.ServiceLocation;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Br.Financas.Infra.Repositories.Context {
    public class UnityOfWork : IUnityOfWork {

        private DbContext _context;

        public void BeginTransaction()
        {
            //implementaremos o padrao Context Per Request (um contexto unico por requisicao)
            var contextManager = ServiceLocator.Current.GetInstance<ContextManager>();
            _context = contextManager.Context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }
    }
}
