using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
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
   
    public partial class FrmDokumentySzczegoly : Form
    {
        #region zmienne
        private int _dokumentId=-1;
        private DateTime _dataZlozenia = DateTime.Now;
        private string _numerKlienta ="";
        private string _nazwaDokumentu = "";
        private decimal _wartoscNetto=0;
        private decimal _wartoscBrutto=0;
        private FrmDokumenty _parent;

        private DataTable _pozycje;
        
        public DataTable Pozycje
        {
            set { _pozycje = value; }
            get { return _pozycje; }
        }

        public FrmDokumenty Parent
        {
            set { _parent = value; }
        }

        public int DokumentId
        {
            set { _dokumentId = value; }
            get { return _dokumentId; }
        }

        public DateTime DataZlozenia
        {
            set { _dataZlozenia = value; }
            get { return _dataZlozenia; }
        }

        public string NumerKlienta
        {
            set { _numerKlienta = value; }
            get { return _numerKlienta; }
        }

        public string NazwaDokumentu
        {
            set { _nazwaDokumentu = value; }
            get { return _nazwaDokumentu; }
        }

        public decimal WartoscNetto
        {
            set { _wartoscNetto = value; }
            get { return _wartoscNetto; }
        }

        public decimal WartoscBrutto
        {
            set { _wartoscBrutto = value; }
            get { return _wartoscBrutto; }
        }

        public object Produkty { get; internal set; }

        #endregion

        public FrmDokumentySzczegoly()
        {
            InitializeComponent();
        }

        private void frmDokumentySzczegoly_Load(object sender, EventArgs e)
        {
            if(_dokumentId == -1)
            {
                using (DaoDokumentySczegoly dao = new DaoDokumentySczegoly())
                { 
                    NumerKlienta = dao.NowyNumerKlienta();
                }                
            }
            teNumerKlienta.Text = NumerKlienta;
            teDokumentNazwa.Text = NazwaDokumentu;
            teWartoscNetto.Text = WartoscNetto.ToString();
            teWartoscBrutto.Text = WartoscBrutto.ToString();
            dtpDataZlozenia.Value = DataZlozenia;
            gcDokumentSzczegoly.DataSource = _pozycje;
        }

        private void btnDodajPozycje_Click(object sender, EventArgs e)
        {
            FrmProdukty frm = new FrmProdukty();
            frm.Parent = this;
            if (gvDokumentSzczegoly.RowCount >0)
            {
                DataTable dtProdukty;
                using (DaoProdukty dao = new DaoProdukty())
                {
                    dtProdukty = dao.PobierzListeProduktow();
                }
                List<string> ids = ((DataView)gvDokumentSzczegoly.DataSource).Table.AsEnumerable().Select(x => x["produkt_id"].ToString()).ToList();
                for(int i = dtProdukty.Rows.Count-1;i>=0; i--)
                {
                    DataRow dr = dtProdukty.Rows[i];
                    if (ids.Contains(dr["produkt_id"].ToString()))
                    {
                        dr.Delete();
                    }
                }
                dtProdukty.AcceptChanges();

                frm.Produkty = dtProdukty;
            }
            frm.ShowDialog();
        }

        private void gvDokumentSzczegoly_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            GridView view = sender as GridView;
            if (view.GetRowCellValue(e.RowHandle, "ilosc") != DBNull.Value)
            { 
                int val = Convert.ToInt16(view.GetRowCellValue(e.RowHandle, "ilosc"));
                if (val <= 0)
                {
                    e.ErrorText = string.Format("{0}\r\n", "Podano nieprawidłową ilość");
                    e.Valid = false;
                }
                else
                {
                    e.ErrorText = "";
                    e.Valid = true;                    
                }
            }
        }

        private void teDokumentNazwa_Validating(object sender, CancelEventArgs e)
        {
            if(teDokumentNazwa.Text.Length ==0)
            {
                e.Cancel = true;
            }
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            if (teDokumentNazwa.Text.Length == 0)
            {
                teDokumentNazwa.ErrorText = "Nazwa dokumentu nie może być pusta";
                return;
            } 
            
            using (DaoDokumenty dao = new DaoDokumenty())
            {
                try
                {
                    dao.ZapiszDokument(DokumentId, teNumerKlienta.Text, teDokumentNazwa.Text, dtpDataZlozenia.Value, getPozycjeXml());
                    XtraMessageBox.Show("Poprawnie zapisano dokument", "Zapis dokumentu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _parent.LoadDokumenty();
                    this.Close();
                }
                catch(Exception ex) 
                {
                    XtraMessageBox.Show(ex.Message, "Bład zapisu dokumentu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
          
        }

        private string getPozycjeXml()
        {
            StringBuilder sbPozycje = new StringBuilder();

            foreach (DataRow dr in Pozycje.Rows)
                sbPozycje.Append(@"<row produkt_id =""" + dr["produkt_id"].ToString() + @""" ilosc = """ + dr["ilosc"].ToString() + @""" />");
            return sbPozycje.ToString();
        }

        private void gvDokumentSzczegoly_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "ilosc")
            {
                gvDokumentSzczegoly.SetRowCellValue(e.RowHandle, "wartosc_netto", Convert.ToDouble(gvDokumentSzczegoly.GetRowCellValue(e.RowHandle, "ilosc")) * Convert.ToDouble(gvDokumentSzczegoly.GetRowCellValue(e.RowHandle, "cena_jednostkowa_netto")));
                gvDokumentSzczegoly.SetRowCellValue(e.RowHandle, "wartosc_brutto", Convert.ToDouble(gvDokumentSzczegoly.GetRowCellValue(e.RowHandle, "ilosc")) * Convert.ToDouble(gvDokumentSzczegoly.GetRowCellValue(e.RowHandle, "cena_jednostkowa_brutto")));
                teWartoscNetto.Text = ((DataView)gvDokumentSzczegoly.DataSource).Table.AsEnumerable().Sum(x => x.Field<decimal>("wartosc_netto")).ToString();
                teWartoscBrutto.Text = ((DataView)gvDokumentSzczegoly.DataSource).Table.AsEnumerable().Sum(x => x.Field<decimal>("wartosc_brutto")).ToString();
            }

        }

        private void btnUsunPozycje_Click(object sender, EventArgs e)
        {
            
            gvDokumentSzczegoly.DeleteSelectedRows();
            ((DataView)gvDokumentSzczegoly.DataSource).Table.AcceptChanges();
        }
    }
}
