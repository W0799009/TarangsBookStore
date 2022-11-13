using System;
using System.Collections.Generic;
using System.Text;

namespace TarangsBooks.DataAccess.Repository.IRepository
{
    interface IUnitOfWork:IDisposable
    {
        ICategoryRepository Category { get; }
        ISP_Call SP_Call { get; }
    }
}
