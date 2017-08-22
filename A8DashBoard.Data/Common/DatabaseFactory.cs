using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A8DashBoard.Data.A8Product;

namespace A8DashBoard.Data.Common
{
    class DatabaseFactory : Disposable, IDatabaseFactory
    {
        private A8ProdcutEntities dataContext ;
        public A8ProdcutEntities Get()
        {
            return dataContext ?? (dataContext = new A8ProdcutEntities());
        }

        protected override void DisposeCore()
        {
            if (dataContext != null)
                dataContext.Dispose();
        }
    }
}
