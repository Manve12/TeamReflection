using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using TeamReflection.Enum;

namespace TeamReflection.Data
{
    public static class DatabaseCall
    {
        public static DataTable Get(StoredProcedures.Procedures procedure)
        {
            string procedureName = GetProcedureName(procedure);

            if (procedureName == null)
            {
                return null;
            }

            SqlCommand cmd = DbConnect.ConnectionDatabase.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = procedureName;

            cmd.CommandTimeout = DbConnect.ConnectionTimeout;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable data = new DataTable();

            DbConnect.OpenConnection();

            da.Fill(data);

            DbConnect.CloseConnection();

            return data;
        }

        private static string GetProcedureName(StoredProcedures.Procedures procedure)
        {
            foreach (var item in StoredProcedures.StoredProcedure)
            {
                if (item.Key == procedure)
                {
                    return item.Value;
                }
            }
            return null;
        }
    }
}