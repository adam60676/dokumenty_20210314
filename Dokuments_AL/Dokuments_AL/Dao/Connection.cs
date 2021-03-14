using System;
using System.Data.SqlClient;

namespace DokumentyAL.Dao
{
    public class Connection : IDisposable
    {
        private SqlConnection sqlConn;
        private SqlTransaction sqlTran;
        private bool disposed;

        public Connection()
        {
            sqlConn = new SqlConnection();
        }

        public SqlTransaction SqlTran
        {
            get { return sqlTran; }
        }

        public void Open()
        {
            if (sqlConn.State == System.Data.ConnectionState.Open)
            {
                return;
            }

            
            string connStr = "Server=2Y7VP42\\SQL2017DEV;Database=DB_TEST;User Id=al_test;Pwd=123456;Trusted_Connection=False;";
            
            //connStr = connStr.Replace("DB_SERVER", Config.Host);
            //connStr = connStr.Replace("DB_NAME", Config.Database);

            //connStr = connStr.Replace("DB_USER", Config.User);
            //connStr = connStr.Replace("DB_PASS", Config.Password);
            sqlConn.ConnectionString = connStr;
            OnUpdateConnectionString(connStr);
            sqlConn.Open();
        }

        protected virtual void OnUpdateConnectionString(string connStr)
        {
        }

        public void Close()
        {
            if (sqlConn != null)
            {
                sqlConn.Close();
            }
        }

        public SqlConnection SqlConn
        {
            get { return sqlConn; }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    if (sqlConn != null)
                    {
                        sqlConn.Close();
                    }
                }

                disposed = true;
            }
        }

        public void BeginTransaction()
        {
            this.Open();
            this.sqlTran = this.sqlConn.BeginTransaction();
        }

        public void CommitTransaction()
        {
            this.sqlTran.Commit();
            this.sqlTran = null;
        }

        public void RollbackTransaction()
        {
            this.sqlTran.Rollback();
            this.sqlTran = null;
        }
    }
}
