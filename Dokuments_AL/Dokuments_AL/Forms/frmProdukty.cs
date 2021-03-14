using DokumentyAL.Dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DokumentyAL.Forms
{
    public partial class FrmProdukty : Form
    {
        private DataTable _dtProdukty;
        private FrmDokumentySzczegoly _parent;
        public DataTable Produkty
        {
            set { _dtProdukty = value; }
        }

        public FrmDokumentySzczegoly Parent
        {
            set { _parent = value; }
        }

        public FrmProdukty()
        {
            InitializeComponent();
        }

        private void frmProdukty_Load(object sender, EventArgs e)
        {
            if (_dtProdukty == null)
            {
                using (DaoProdukty dao = new DaoProdukty())
                {
                    _dtProdukty = dao.PobierzListeProduktow();
                }
            }
            gcProdukty.DataSource = _dtProdukty;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (_parent == null)
                throw new ArgumentNullException("Rodzic nie został ustawiony");
            foreach(int i in gvProdukty.GetSelectedRows())
            {
                _parent.Pozycje.Rows.Add(new object[] {0,0, gvProdukty.GetRowCellValue(i,"produkt_id"), gvProdukty.GetRowCellValue(i, "nazwa") 
                    ,0, gvProdukty.GetRowCellValue(i, "cena_netto"), 0, gvProdukty.GetRowCellValue(i, "cena_brutto"), 0});
            }
            this.Close();
        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
