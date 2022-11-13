using TarangsBooks.DataAccess.Repository.IRepository;
using TarangsBooks.Models;
using TarangsBookStore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace TarangsBooks.DataAccess.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Category category)
        {
            var objFromDb = _db.Categories.FirstOrDefault(s => s.Id == category.Id);
            if(objFromDb != null) // Save changes if not null
            {
                objFromDb.Name = category.Name;
                //_db.SaveChanges();
            }
        }
    }
}
