using System.Data.Entity;
using System.Web;

namespace Br.Financas.Infra.Repositories.Context {
    public class ContextManager {

        private const string contextKey = "ContextManager.Context";

        public FinancasDbContext Context
        {
            get
            {
                if (HttpContext.Current.Items[contextKey] == null)
                    HttpContext.Current.Items[contextKey] = new FinancasDbContext();

                return HttpContext.Current.Items[contextKey] as FinancasDbContext;
            }
        }
    }
}
