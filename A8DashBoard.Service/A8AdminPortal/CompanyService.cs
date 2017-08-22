using A8Dashboard.Models.A8Product;
using A8Dashboard.Models.Enums;
using A8DashBoard.Models.A8Product.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A8DashBoard.Data.Repository.A8AdminPortal;
using A8DashBoard.Data.Repository;
using A8DashBoard.Data.Common;
using A8DashBoard.Service.A8AdminPortal.InterfaceServices;

namespace A8DashBoard.Service.A8AdminPortal
{
    class CompanyService: ICompanyService
    {
        private readonly CompanyRepository ObjCompanyRepo;

        private readonly IUnitOfWork unitOfWork;

        public CompanyService(CompanyRepository companyRepo, IUnitOfWork unitOfWork)
        {
            this.ObjCompanyRepo = companyRepo;
            this.unitOfWork = unitOfWork;
        }

        public RepositoryResult CreateCompany(FormViewModel objFormViewModel)
        {
            try
            {
                if (objFormViewModel.CompanyName != null)
                {
                    Company objCompany = new Company
                    {
                        CompanyName = objFormViewModel.CompanyName,
                        OrganisationId = objFormViewModel.organisationDdl == 0 ? null : (int?)Convert.ToInt32(objFormViewModel.organisationDdl)
                    };
                    ObjCompanyRepo.CreateCompanyDB(objCompany);
                    SaveChanges();
                }
            }
            catch (Exception ex)
            {
                return RepositoryResult.Failure;
            }
            return RepositoryResult.Success;
        }


        /// <summary>
        /// 
        /// </summary>
        public void SaveChanges()
        {
            unitOfWork.Commit();
        }

    }
}


