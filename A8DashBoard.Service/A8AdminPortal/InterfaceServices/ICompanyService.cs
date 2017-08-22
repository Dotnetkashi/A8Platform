using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A8Dashboard.Models.Enums;
using A8DashBoard.Models.A8Product.ViewModels;

namespace A8DashBoard.Service.A8AdminPortal.InterfaceServices
{
    interface ICompanyService
    {
        RepositoryResult CreateCompany(FormViewModel objFormViewModel);
    }
}
