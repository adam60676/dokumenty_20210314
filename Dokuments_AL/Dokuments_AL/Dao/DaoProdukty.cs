using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DokumentyAL.Dao
{
    public class DaoProdukty : DokumentyAL.Dao.Connection
    {
        public DataTable PobierzListeProduktow()
        {
            DataTable dt = null;
            Hashtable htParams = new Hashtable();
            try
            {
                this.Open();
                dt = Helpers.ExecuteProcDT(this, "produkty_lista", htParams);

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
    }
}