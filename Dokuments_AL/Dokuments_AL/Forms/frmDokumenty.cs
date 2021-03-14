using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
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
    public partial class FrmDokumenty : Form
    {
        private DataTable dtDokumenty;
        private DataTable dtDokumentyPozycje;
        private bool kolumnyDodane = false;
        public FrmDokumenty()
        {
            InitializeComponent();
        }

        private void frmDokumenty_Load(object sender, EventArgs e)
        {
            LoadDokumenty();
        }

        private void gc_ViewRegistered(object sender, DevExpress.XtraGrid.ViewOperationEventArgs e)
        {
            if (e.View.IsDetailView == true)
            {
                (e.View as DevExpress.XtraGrid.Views.Grid.GridView).Columns["dokument_pozycja_id"].Caption = "DokumentPozycjaId";
                (e.View as DevExpress.XtraGrid.Views.Grid.GridView).Columns["dokument_pozycja_id"].Visible = false;
                (e.View as DevExpress.XtraGrid.Views.Grid.GridView).Columns["dokument_id"].Caption = "DokumentId";
                (e.View as DevExpress.XtraGrid.Views.Grid.GridView).Columns["dokument_id"].Visible = false;
                (e.View as DevExpress.XtraGrid.Views.Grid.GridView).Columns["produkt_id"].Caption = "ProduktId";
                (e.View as DevExpress.XtraGrid.Views.Grid.GridView).Columns["produkt_id"].Visible = false;
                (e.View as DevExpress.XtraGrid.Views.Grid.GridView).Columns["nazwa"].Caption = "Nazwa produktu";
                (e.View as DevExpress.XtraGrid.Views.Grid.GridView).Columns["ilosc"].Caption = "Ilość";
                (e.View as DevExpress.XtraGrid.Views.Grid.GridView).Columns["cena_jednostkowa_netto"].Caption = "Cena jedn. netto";
                (e.View as DevExpress.XtraGrid.Views.Grid.GridView).Columns["wartosc_netto"].Caption = "Wartość netto";
                (e.View as DevExpress.XtraGrid.Views.Grid.GridView).Columns["cena_jednostkowa_brutto"].Caption = "Cena jedn. brutto";
                (e.View as DevExpress.XtraGrid.Views.Grid.GridView).Columns["wartosc_brutto"].Caption = "Wartość brutto";
            }
        }

        private void gv_DoubleClick(object sender, EventArgs e)
        {
            if (gv.FocusedRowHandle < 0) return;

            int dokument_id = (int)gv.GetRowCellValue(gv.FocusedRowHandle, "dokument_id");
            FrmDokumentySzczegoly frm = new FrmDokumentySzczegoly();
            frm.DokumentId = dokument_id;
            DateTime dataZlozenia;
            DateTime.TryParse((string)gv.GetRowCellValue(gv.FocusedRowHandle, "data"), out dataZlozenia);
            frm.DataZlozenia = dataZlozenia;
            frm.NumerKlienta = (string)gv.GetRowCellValue(gv.FocusedRowHandle, "numer_klienta");
            frm.NazwaDokumentu = (string)gv.GetRowCellValue(gv.FocusedRowHandle, "dokument_nazwa");
            frm.WartoscNetto = (decimal)gv.GetRowCellValue(gv.FocusedRowHandle, "cena_netto");
            frm.WartoscBrutto = (decimal)gv.GetRowCellValue(gv.FocusedRowHandle, "cena_brutto");
            frm.Parent = this;
            frm.Pozycje = dtDokumentyPozycje.Clone();
            foreach (DataRow pozycja in dtDokumentyPozycje.Select(string.Format("dokument_id = {0}", dokument_id)))
            {
                frm.Pozycje.ImportRow(pozycja);
            }
            frm.ShowDialog();



        }

        private void btnDodajDokument_Click(object sender, EventArgs e)
        {
            FrmDokumentySzczegoly frm = new FrmDokumentySzczegoly();
            frm.Parent = this;
            frm.Pozycje = dtDokumentyPozycje.Clone();
            frm.ShowDialog();
        }

        private void dodajKolumnyPrzyciskow(GridView gridView)
        {

            if (kolumnyDodane == false)
            {

                DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit buttonWydruk = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
                gv.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn());
                DevExpress.XtraGrid.Columns.GridColumn columnWydruk = gridView.Columns[gridView.Columns.Count - 1];
                gridView.GridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { buttonWydruk });

                buttonWydruk.AllowMouseWheel = false;
                buttonWydruk.AutoHeight = false;
                buttonWydruk.Name = "buttonWydruk";
                buttonWydruk.Buttons[0].Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph;
                buttonWydruk.Buttons[0].Appearance.ForeColor = Color.Black;
                buttonWydruk.Buttons[0].Caption = "Wydruk";
                buttonWydruk.Buttons[0].Image = Properties.Resources.PrintHS;
                buttonWydruk.Buttons[0].ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
                buttonWydruk.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;


                columnWydruk.Visible = true;
                columnWydruk.ColumnEdit = buttonWydruk;
                columnWydruk.Name = "wydruk";

                DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit buttonUsun = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
                gv.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn());
                DevExpress.XtraGrid.Columns.GridColumn columnUsun = gridView.Columns[gridView.Columns.Count - 1];
                gridView.GridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { buttonWydruk });

                buttonUsun.AllowMouseWheel = false;
                buttonUsun.AutoHeight = false;
                buttonUsun.Name = "buttonUsun";
                buttonUsun.Buttons[0].Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph;
                buttonUsun.Buttons[0].Appearance.ForeColor = Color.Black;
                buttonUsun.Buttons[0].Caption = "Usuń";
                buttonUsun.Buttons[0].Image = Properties.Resources.reject;
                buttonUsun.Buttons[0].ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
                buttonUsun.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;


                columnUsun.Visible = true;
                columnUsun.ColumnEdit = buttonUsun;
                columnUsun.Name = "usun";
                kolumnyDodane = true;
            }
        }

        public void LoadDokumenty()
        {
            using (DaoDokumenty dao = new DaoDokumenty())
            {

                using (DaoDokumentySczegoly daoSzczegoly = new DaoDokumentySczegoly())
                {
                    dtDokumenty = dao.PobierzListeDokumentow();
                    dtDokumenty.TableName = "Dokumenty";
                    dtDokumentyPozycje = daoSzczegoly.PobierzListePozycji();
                    dtDokumentyPozycje.TableName = "DokumentyPozycje";
                    DataSet ds = new DataSet();
                    ds.Tables.Add(dtDokumenty);
                    ds.Tables.Add(dtDokumentyPozycje);
                    ds.Relations.Add("Pozycje", dtDokumenty.Columns["dokument_id"], dtDokumentyPozycje.Columns["dokument_id"]);
                    gc.DataSource = ds.Tables["Dokumenty"];
                    //}
                    dodajKolumnyPrzyciskow(gv);
                }
            }
        }


            private void gv_RowCellClick(object sender, RowCellClickEventArgs e)
            {

                if (e.Column.Name == "wydruk")
                {
                    int dokument_id = (int)gv.GetRowCellValue(e.RowHandle, "dokument_id");
                    SzablonDokumentu raport = new SzablonDokumentu();
                    raport.Parameters[0].Value = dokument_id;
                    
                    ReportPrintTool tool = new ReportPrintTool(raport);
                    tool.ShowPreview();
                }
                if (e.Column.Name == "usun")
                {
                    using (DaoDokumenty dao = new DaoDokumenty())
                    {
                        try
                        {
                            dao.UsunDokument((int)gv.GetRowCellValue(e.RowHandle, "dokument_id"));
                            LoadDokumenty();
                        }
                        catch (Exception ex)
                        {
                            XtraMessageBox.Show(ex.Message, "Bład usunięcia dokumentu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                }

            }
        }
    }


