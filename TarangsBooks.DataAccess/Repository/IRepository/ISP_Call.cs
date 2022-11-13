using Dapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace TarangsBooks.DataAccess.Repository.IRepository
{
    public interface ISP_Call : IDisposable
    {
        //first column in the first row in the result row
        T Single<T>(string procedurename, DynamicParameters param = null);

        //execute something to the database but not retrive anything
        void Execute(string procedurename, DynamicParameters param = null);
        //retrive the complete row or record
        T OnrRecord<T>(string procedurename, DynamicParameters param = null);
        //Get all of the row
        IEnumerable<T> List<T>(string procedurename, DynamicParameters param = null);
        //Stored procedure that strore two tables
        Tuple<IEnumerable<T1>, IEnumerable<T2>> List<T1, T2>(string procedurename, DynamicParameters param = null);
    }
}
