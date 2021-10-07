using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KL.MeVaBe.DAO
{
    public class DataAccess
    {
        public string ConnectionString = @"Server = 165065-TRANDPY\MSSQL2019; Database=QL_MeVaBe2;User Id = sa; Password=123;";
        SqlConnection connection;
        SqlCommand cmd;
        IDataReader reader;
        public DataAccess(){
            connection = new SqlConnection(ConnectionString);
        }
        public void CreateData() {
            connection = new SqlConnection(ConnectionString);
        }
        public void Connect() {
            connection.Open();
        }
        public void Disconnect() {
            connection.Close();
        }
        public void CreateNewStoredProcedure(string procName) {
            cmd = new SqlCommand(procName, connection);
        }
        public void AddParameter(string paramName, string paramValue, SqlDbType paramDataType ) {
            cmd.Parameters.Add(new SqlParameter(paramName, paramDataType)).Value = paramValue;
            cmd.CommandType = CommandType.StoredProcedure;
        }
        public IDataReader ExecStoreToDataReader() {
            reader = cmd.ExecuteReader();
            return reader;
        }
    }
}
