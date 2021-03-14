using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DokumentyAL.Dao
{
    public class DaoDokumentySczegoly : DokumentyAL.Dao.Connection
    {
        public DataTable PobierzListePozycji()
        {
            DataTable dt = null;
            Hashtable htParams = new Hashtable();
            try
            {
                this.Open();
                dt = Helpers.ExecuteProcDT(this, "dokumenty_pozycje_lista", htParams);

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

        public string NowyNumerKlienta()
        {
            
            string NumerKlienta = "";
            Hashtable htParams = new Hashtable();
            try
            {
                this.Open();
                NumerKlienta = (string)Helpers.ExecuteProcScalar(this, "nowy_numer_klienta", htParams);                
            }
            finally
            {
                if (this.SqlTran == null && this.SqlConn != null)
                {
                    this.Close();
                }
            }
            return NumerKlienta;
        }
    }
}
