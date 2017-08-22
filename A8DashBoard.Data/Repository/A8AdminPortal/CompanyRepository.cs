using System;
using A8Dashboard.Models.A8Product;
using A8DashBoard.Models.A8Product.ViewModels;
using A8DashBoard.Data.Common;
using A8DashBoard.Data.A8Product;

namespace A8DashBoard.Data.Repository.A8AdminPortal
{
    public class CompanyRepository: RepositoryBase<Company>
    {
        private int RetCode { get; set; }
        private string RetMsg { get; set; }

        private A8ProdcutEntities db;

       
        public CompanyRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {
           
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="objCompany"></param>
        public void CreateCompanyDB(Company objCompany)
        {
            try
            {
                Add(objCompany);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
