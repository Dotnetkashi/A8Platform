using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A8DashBoard.Data.A8Product;

namespace A8DashBoard.Data.Common
{
    public interface IDatabaseFactory
    {
        A8ProdcutEntities Get();
    }
}
