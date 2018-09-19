using Br.Financas.Domain.Interfaces;
using Microsoft.Practices.ServiceLocation;
using System;

namespace Br.Financas.Application {
    public class ApplicationBase{

        private IUnityOfWork _unitOfWork;

        public void BeginTransaction()
        {
             _unitOfWork = ServiceLocator.Current.GetInstance<IUnityOfWork>();
            _unitOfWork.BeginTransaction();
        }

        public void Commit()
        {
            _unitOfWork.Commit();
        }

        
    }
}
