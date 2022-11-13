using TarangsBooks.DataAccess.Repository.IRepository;
using TarangsBookStore.DataAccess.Data;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

using System.Text;
using Dapper;
using Microsoft.Data.SqlClient;
using System.Linq;

namespace TarangsBooks.DataAccess.Repository
{
    public class SP_Call : ISP_Call
    {
        //access the database
        private readonly ApplicationDbContext _db;
        private static string ConnectionString = ""; // needed to called the stored procedure.
        
        //Constructor t open the a SQL Connection
        public SP_Call(ApplicationDbContext db)
        {
            _db = db;
            ConnectionString = db.Database.GetDbConnection().ConnectionString;
        }
        //Implement the ISP_CallInterface.
        public void Dispose()
        {
            _db.Dispose(); 
        }

        public void Execute(string procedureName, DynamicParameters param = null)
        {
            using (SqlConnection sqlCon = new SqlConnection(ConnectionString))
            {
                sqlCon.Open();
                sqlCon.Execute(procedureName, param, commandType: System.Data.CommandType.StoredProcedure);
            }
        }

        public IEnumerable<T> List<T>(string procedurename, DynamicParameters param = null)
        {
            using (SqlConnection sqlCon = new SqlConnection(ConnectionString))
            {
                sqlCon.Open();
                return sqlCon.Query<T>(procedurename, param, commandType: System.Data.CommandType.StoredProcedure);
            }
        }

        public Tuple<IEnumerable<T1>, IEnumerable<T2>> List<T1, T2>(string procedurename, DynamicParameters param = null)
        {
            using(SqlConnection sqlCon = new SqlConnection(ConnectionString))
            {
                var result = SqlMapper.QueryMultiple(sqlCon, procedurename, param, commandType: System.Data.CommandType.StoredProcedure);
                var item1 = result.Read<T1>().ToList(); //make sure to add using statements for linq
                var item2 = result.Read<T2>().ToList();

                if(item1 != null && item2 != null)
                {
                    return new Tuple<IEnumerable<T1>, IEnumerable<T2>>(item1, item2);
                }
            }
            return new Tuple<IEnumerable<T1>, IEnumerable<T2>>(new List<T1>(), new List<T2>());

        }


        public T OnrRecord<T>(string procedurename, DynamicParameters param = null)
        {
            using (SqlConnection sqlCon = new SqlConnection(ConnectionString))
            {
                sqlCon.Open();
                var value = sqlCon.Query<T>(procedurename, param, commandType: System.Data.CommandType.StoredProcedure);
                return (T)Convert.ChangeType(value.FirstOrDefault(), typeof(T));
            }
        }

        public T Single<T>(string procedurename, DynamicParameters param = null)
        {
            using (SqlConnection sqlCon = new SqlConnection(ConnectionString))
            {
                sqlCon.Open();
                return (T)Convert.ChangeType(sqlCon.ExecuteScalar<T>(procedurename, param, commandType: System.Data.CommandType.StoredProcedure), typeof(T));
            }
        }
    }
}
