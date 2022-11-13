using System;
using System.Collections.Generic;
using System.Text;
using TarangsBookStore.DataAccess.Data;

namespace TarangsBooks.DataAccess.Repository.IRepository
{
    public class UnitOfWork: IUnitOfWork //public to access the class
    {
        private readonly ApplicationDbContext _db; //the using statemnet.

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Category = new CategoryRepository(_db);//Constructor to use DI and Inject in the repositories.
            SP_Call = new SP_Call(_db);
        }

        public ICategoryRepository Category { get; private set; }
        public ISP_Call SP_Call { get; private set; }

        public void Dispose()
        {
            _db.Dispose();
        }
        public void Save()//All changes will be saved when this method is called
        {
            _db.SaveChanges();
        }
    }
}