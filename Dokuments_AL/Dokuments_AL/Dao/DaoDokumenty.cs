using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DokumentyAL.Dao;

namespace DokumentyAL.Dao
{
    public class DaoDokumenty : DokumentyAL.Dao.Connection
    {
        public DataTable PobierzListeDokumentow()
        {
            DataTable dt = null;
            Hashtable htParams = new Hashtable();
            try
            {
                this.Open();
                dt = Helpers.ExecuteProcDT(this, "dokumenty_lista", htParams);

            }
            finally
            {
                if (this.SqlTran == null && this.SqlConn != null)
                {
                    this.Close();
                }
            }
            return dt;
        }

        public void ZapiszDokument(int dokument_id, string numer_klienta, string dokument_nazwa, DateTime data_zlozenia, string pozycje)
        {
            DataTable dt = null;
            
            Hashtable htParams = new Hashtable();
            htParams.Add("@dokument_id", dokument_id);
            htParams.Add("@numer_klienta", numer_klienta);
            htParams.Add("@dokument_nazwa", dokument_nazwa);
            htParams.Add("@data_zlozenia", data_zlozenia);
            htParams.Add("@pozycje", pozycje);     
            try
            {
                this.Open();
                Helpers.ExecuteProc(this, "dokument_zapisz", htParams);                
            }
            finally
            {
                if (this.SqlTran == null && this.SqlConn != null)
                {
                    this.Close();
                }
            }
            
        }

        public void UsunDokument(int dokument_id)
        {
            DataTable dt = null;

            Hashtable htParams = new Hashtable();
            htParams.Add("@dokument_id", dokument_id);
            try
            {
                this.Open();
                Helpers.ExecuteProc(this, "dokument_usun", htParams);
            }
            finally
            {
                if (this.SqlTran == null && this.SqlConn != null)
                {
                    this.Close();
                }
            }

        }
    }
}
