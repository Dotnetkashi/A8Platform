using A8DashBoard.Data.A8Product;
namespace A8DashBoard.Data.Common
{
    class UnitOfWork :IUnitOfWork
    {
        private readonly IDatabaseFactory databaseFactory;
        private A8ProdcutEntities dataContext;

        public UnitOfWork(IDatabaseFactory databaseFactory)
        {
            this.databaseFactory = databaseFactory;
        }

        protected A8ProdcutEntities DataContext
        {
            get { return dataContext ?? (dataContext = databaseFactory.Get()); }
        }

        public void Commit()
        {
            dataContext.SaveChanges();
        }
    }
}
