using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DokumentyAL.Dao
{
    public static class Helpers
    {
        public static void ExecuteSql(
            Connection conn,
            string sql,
            Hashtable args)
        {

            SqlCommand cmd = null;
            if (conn.SqlTran != null)
            {
                cmd = new SqlCommand(sql, conn.SqlConn, conn.SqlTran);
            }
            else
            {
                cmd = new SqlCommand(sql, conn.SqlConn);
            }

            PrepareParams(cmd, args);
            cmd.ExecuteNonQuery();
        }

        public static DataTable ExecuteProcDT(
            Connection conn,
            string procedure,
            Hashtable parameters)
        {
            DataTable result = new DataTable("DT_" + procedure);
            result.Locale = System.Globalization.CultureInfo.CurrentCulture;

            SqlCommand cmd = null;
            if (conn.SqlTran != null)
            {
                cmd = new SqlCommand(procedure, conn.SqlConn, conn.SqlTran);
            }
            else
            {
                cmd = new SqlCommand(procedure, conn.SqlConn);
            }
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            PrepareParams(cmd, parameters);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(result);

            return result;
        }
        public static DataRow ExecuteProcDR(
            Connection conn,
            string procedure,
            Hashtable parameters)
        {
            DataTable dt = ExecuteProcDT(conn, procedure, parameters);
            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0];
            }

            return null;
        }

        public static object ExecuteProcScalar(
            Connection conn,
            string procedure,
            Hashtable parameters)
        {
            DataTable dt = ExecuteProcDT(conn, procedure, parameters);
            if (dt.Rows.Count > 0 && dt.Columns.Count > 0)
            {
                return dt.Rows[0][0];
            }

            return null;
        }

        public static void ExecuteProc(
            Connection conn,
            string procedure,
            Hashtable parameters)
        {
            SqlCommand cmd = null;
            if (conn.SqlTran != null)
            {
                cmd = new SqlCommand(procedure, conn.SqlConn, conn.SqlTran);
            }
            else
            {
                cmd = new SqlCommand(procedure, conn.SqlConn);
            }
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            PrepareParams(cmd, parameters);
            cmd.ExecuteNonQuery();
            GetParamOutValues(cmd, parameters);

        }

        public static void PrepareParams(SqlCommand cmd, Hashtable parameters)
        {
            foreach (object key in parameters.Keys)
            {
                SqlParameter param = null;
                string typeName = "DBNull";
                if (parameters[key] != null && parameters[key] != DBNull.Value)
                {
                    typeName = parameters[key].GetType().Name;
                }
                string pName = key.ToString();
                int pSize = 0;
                if (pName.Contains(":"))
                {
                    string[] arr = pName.Split(':');
                    pName = arr[0];
                    pSize = Convert.ToInt32(arr[1], System.Globalization.CultureInfo.CurrentCulture);
                }
                switch (typeName)
                {
                    case "String":
                        param = new SqlParameter(pName, SqlDbType.NVarChar);
                        break;
                    case "Int32":
                        param = new SqlParameter(pName, SqlDbType.Int);
                        break;
                    case "Int16":
                        param = new SqlParameter(pName, SqlDbType.SmallInt);
                        break;
                    case "Int64":
                        param = new SqlParameter(pName, SqlDbType.BigInt);
                        break;
                    case "Decimal":
                        param = new SqlParameter(pName, SqlDbType.Decimal);
                        break;
                    case "Double":
                        param = new SqlParameter(pName, SqlDbType.Float);
                        break;
                    case "DateTime":
                        param = new SqlParameter(pName, SqlDbType.DateTime);
                        break;
                    case "Boolean":
                        param = new SqlParameter(pName, SqlDbType.Bit);
                        break;
                    case "Byte[]":
                        param = new SqlParameter(pName, SqlDbType.NText);
                        break;
                    case "DBNull":
                        param = new SqlParameter(pName, SqlDbType.NVarChar);
                        break;
                }
                if (param != null)
                {
                    if (typeName == "DBNull")
                    {
                        param.Value = DBNull.Value;
                    }

                    else if (pName.StartsWith("@OUT_", StringComparison.CurrentCulture))
                    {
                        param.Direction = ParameterDirection.InputOutput;
                        param.Value = parameters[key];
                        if (pSize != 0)
                        {
                            param.Size = pSize;
                        }
                    }
                    else
                    {
                        param.Value = parameters[key];
                    }
                    cmd.Parameters.Add(param);
                }
                
            }
        }

        public static void GetParamOutValues(SqlCommand cmd, Hashtable parameters)
        {
            foreach (SqlParameter param in cmd.Parameters)
            {
                if (param.Direction == ParameterDirection.InputOutput)
                {
                    if (param.SqlDbType == SqlDbType.NVarChar)
                    {
                        parameters[param.ParameterName + ":" + param.Size.ToString(System.Globalization.CultureInfo.CurrentCulture)] = param.Value;
                    }
                    else
                    {
                        parameters[param.ParameterName] = param.Value;
                    }
                }
            }
        }
    }
}
