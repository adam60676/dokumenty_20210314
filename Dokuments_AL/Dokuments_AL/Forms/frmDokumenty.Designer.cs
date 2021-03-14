using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;

namespace DokumentyAL.Forms
{
    partial class FrmDokumenty
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDokumenty));
            this.gvSzczegoly = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDokumentPozycjaId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDokumentIdKey = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProduktNazwa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colilosc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPozycjaCenaNetto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPozycjaWartoscNetto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPozycjaCenaBrutto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPozycjaWartoscBrutto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc = new DevExpress.XtraGrid.GridControl();
            this.gv = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDokumentId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumerKlienta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDokumentNazwa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataZlozenia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCenaNetto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCennaBrutto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnDodajDokument = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gvSzczegoly)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).BeginInit();
            this.SuspendLayout();
            // 
            // gvSzczegoly
            // 
            this.gvSzczegoly.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDokumentPozycjaId,
            this.colDokumentIdKey,
            this.colProduktNazwa,
            this.colilosc,
            this.colPozycjaCenaNetto,
            this.colPozycjaWartoscNetto,
            this.colPozycjaCenaBrutto,
            this.colPozycjaWartoscBrutto});
            this.gvSzczegoly.GridControl = this.gc;
            this.gvSzczegoly.Name = "gvSzczegoly";
            this.gvSzczegoly.OptionsBehavior.Editable = false;
            // 
            // colDokumentPozycjaId
            // 
            this.colDokumentPozycjaId.Caption = "DokumentPozycjaId";
            this.colDokumentPozycjaId.FieldName = "dokument_pozycja_id";
            this.colDokumentPozycjaId.MinWidth = 25;
            this.colDokumentPozycjaId.Name = "colDokumentPozycjaId";
            this.colDokumentPozycjaId.OptionsColumn.ReadOnly = true;
            this.colDokumentPozycjaId.Width = 94;
            // 
            // colDokumentIdKey
            // 
            this.colDokumentIdKey.Caption = "DokumentId";
            this.colDokumentIdKey.FieldName = "dokument_id";
            this.colDokumentIdKey.MinWidth = 25;
            this.colDokumentIdKey.Name = "colDokumentIdKey";
            this.colDokumentIdKey.OptionsColumn.ReadOnly = true;
            this.colDokumentIdKey.Width = 94;
            // 
            // colProduktNazwa
            // 
            this.colProduktNazwa.Caption = "Nazwa produktu";
            this.colProduktNazwa.FieldName = "nazwa";
            this.colProduktNazwa.MinWidth = 25;
            this.colProduktNazwa.Name = "colProduktNazwa";
            this.colProduktNazwa.OptionsColumn.ReadOnly = true;
            this.colProduktNazwa.Visible = true;
            this.colProduktNazwa.VisibleIndex = 0;
            this.colProduktNazwa.Width = 94;
            // 
            // colilosc
            // 
            this.colilosc.Caption = "Ilość";
            this.colilosc.FieldName = "ilosc";
            this.colilosc.MinWidth = 25;
            this.colilosc.Name = "colilosc";
            this.colilosc.OptionsColumn.ReadOnly = true;
            this.colilosc.Visible = true;
            this.colilosc.VisibleIndex = 1;
            this.colilosc.Width = 94;
            // 
            // colPozycjaCenaNetto
            // 
            this.colPozycjaCenaNetto.Caption = "Cena jedn. netto";
            this.colPozycjaCenaNetto.FieldName = "cena_jednostkowa_netto";
            this.colPozycjaCenaNetto.MinWidth = 25;
            this.colPozycjaCenaNetto.Name = "colPozycjaCenaNetto";
            this.colPozycjaCenaNetto.OptionsColumn.ReadOnly = true;
            this.colPozycjaCenaNetto.Visible = true;
            this.colPozycjaCenaNetto.VisibleIndex = 2;
            this.colPozycjaCenaNetto.Width = 94;
            // 
            // colPozycjaWartoscNetto
            // 
            this.colPozycjaWartoscNetto.Caption = "Wartość netto";
            this.colPozycjaWartoscNetto.FieldName = "wartosc_netto";
            this.colPozycjaWartoscNetto.MinWidth = 25;
            this.colPozycjaWartoscNetto.Name = "colPozycjaWartoscNetto";
            this.colPozycjaWartoscNetto.OptionsColumn.ReadOnly = true;
            this.colPozycjaWartoscNetto.Visible = true;
            this.colPozycjaWartoscNetto.VisibleIndex = 4;
            this.colPozycjaWartoscNetto.Width = 94;
            // 
            // colPozycjaCenaBrutto
            // 
            this.colPozycjaCenaBrutto.Caption = "Cena jedn. brutto";
            this.colPozycjaCenaBrutto.FieldName = "cena_jednostkowa_brutto";
            this.colPozycjaCenaBrutto.MinWidth = 25;
            this.colPozycjaCenaBrutto.Name = "colPozycjaCenaBrutto";
            this.colPozycjaCenaBrutto.OptionsColumn.ReadOnly = true;
            this.colPozycjaCenaBrutto.Visible = true;
            this.colPozycjaCenaBrutto.VisibleIndex = 3;
            this.colPozycjaCenaBrutto.Width = 94;
            // 
            // colPozycjaWartoscBrutto
            // 
            this.colPozycjaWartoscBrutto.Caption = "Wartość brutto";
            this.colPozycjaWartoscBrutto.FieldName = "wartosc_brutto";
            this.colPozycjaWartoscBrutto.MinWidth = 25;
            this.colPozycjaWartoscBrutto.Name = "colPozycjaWartoscBrutto";
            this.colPozycjaWartoscBrutto.OptionsColumn.ReadOnly = true;
            this.colPozycjaWartoscBrutto.Visible = true;
            this.colPozycjaWartoscBrutto.VisibleIndex = 5;
            this.colPozycjaWartoscBrutto.Width = 94;
            // 
            // gc
            // 
            this.gc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            gridLevelNode1.LevelTemplate = this.gvSzczegoly;
            gridLevelNode1.RelationName = "Szczegoly";
            this.gc.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gc.Location = new System.Drawing.Point(6, 52);
            this.gc.MainView = this.gv;
            this.gc.Name = "gc";
            this.gc.Size = new System.Drawing.Size(907, 374);
            this.gc.TabIndex = 1;
            this.gc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv,
            this.gvSzczegoly});
            this.gc.ViewRegistered += new DevExpress.XtraGrid.ViewOperationEventHandler(this.gc_ViewRegistered);
            // 
            // gv
            // 
            this.gv.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDokumentId,
            this.colNumerKlienta,
            this.colDokumentNazwa,
            this.colDataZlozenia,
            this.colCenaNetto,
            this.colCennaBrutto});
            this.gv.GridControl = this.gc;
            this.gv.Name = "gv";
            this.gv.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gv.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gv.OptionsBehavior.Editable = false;
            this.gv.OptionsView.ShowGroupPanel = false;
            this.gv.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gv_RowCellClick);
            this.gv.DoubleClick += new System.EventHandler(this.gv_DoubleClick);
            // 
            // colDokumentId
            // 
            this.colDokumentId.Caption = "DokumentId";
            this.colDokumentId.FieldName = "dokument_id";
            this.colDokumentId.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.colDokumentId.MinWidth = 25;
            this.colDokumentId.Name = "colDokumentId";
            this.colDokumentId.OptionsColumn.ReadOnly = true;
            this.colDokumentId.Width = 94;
            // 
            // colNumerKlienta
            // 
            this.colNumerKlienta.Caption = "Numer klienta";
            this.colNumerKlienta.FieldName = "numer_klienta";
            this.colNumerKlienta.MinWidth = 25;
            this.colNumerKlienta.Name = "colNumerKlienta";
            this.colNumerKlienta.OptionsColumn.ReadOnly = true;
            this.colNumerKlienta.Visible = true;
            this.colNumerKlienta.VisibleIndex = 1;
            this.colNumerKlienta.Width = 94;
            // 
            // colDokumentNazwa
            // 
            this.colDokumentNazwa.Caption = "Nazwa";
            this.colDokumentNazwa.FieldName = "dokument_nazwa";
            this.colDokumentNazwa.MinWidth = 25;
            this.colDokumentNazwa.Name = "colDokumentNazwa";
            this.colDokumentNazwa.OptionsColumn.ReadOnly = true;
            this.colDokumentNazwa.Visible = true;
            this.colDokumentNazwa.VisibleIndex = 2;
            this.colDokumentNazwa.Width = 94;
            // 
            // colDataZlozenia
            // 
            this.colDataZlozenia.Caption = "Data złożenia";
            this.colDataZlozenia.FieldName = "data";
            this.colDataZlozenia.MinWidth = 25;
            this.colDataZlozenia.Name = "colDataZlozenia";
            this.colDataZlozenia.OptionsColumn.ReadOnly = true;
            this.colDataZlozenia.Visible = true;
            this.colDataZlozenia.VisibleIndex = 0;
            this.colDataZlozenia.Width = 94;
            // 
            // colCenaNetto
            // 
            this.colCenaNetto.Caption = "Wartość netto";
            this.colCenaNetto.FieldName = "cena_netto";
            this.colCenaNetto.MinWidth = 25;
            this.colCenaNetto.Name = "colCenaNetto";
            this.colCenaNetto.OptionsColumn.ReadOnly = true;
            this.colCenaNetto.Visible = true;
            this.colCenaNetto.VisibleIndex = 3;
            this.colCenaNetto.Width = 94;
            // 
            // colCennaBrutto
            // 
            this.colCennaBrutto.Caption = "Wartość brutto";
            this.colCennaBrutto.FieldName = "cena_brutto";
            this.colCennaBrutto.MinWidth = 25;
            this.colCennaBrutto.Name = "colCennaBrutto";
            this.colCennaBrutto.OptionsColumn.ReadOnly = true;
            this.colCennaBrutto.Visible = true;
            this.colCennaBrutto.VisibleIndex = 4;
            this.colCennaBrutto.Width = 94;
            // 
            // btnDodajDokument
            // 
            this.btnDodajDokument.Location = new System.Drawing.Point(746, 12);
            this.btnDodajDokument.Name = "btnDodajDokument";
            this.btnDodajDokument.Size = new System.Drawing.Size(167, 29);
            this.btnDodajDokument.TabIndex = 0;
            this.btnDodajDokument.Text = "Dodaj dokument";
            this.btnDodajDokument.Click += new System.EventHandler(this.btnDodajDokument_Click);
            // 
            // FrmDokumenty
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(925, 438);
            this.Controls.Add(this.btnDodajDokument);
            this.Controls.Add(this.gc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDokumenty";
            this.Text = "Dokumenty";
            this.Load += new System.EventHandler(this.frmDokumenty_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvSzczegoly)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        
        private GridControl gc;
        private GridView gv;
        private GridColumn colDokumentId;
        private GridColumn colDataZlozenia;
        private GridColumn colNumerKlienta;
        private GridColumn colCenaNetto;
        private GridColumn colCennaBrutto;
        private GridView gvSzczegoly;
        private GridColumn colDokumentPozycjaId;
        private GridColumn colDokumentIdKey;
        private GridColumn colProduktNazwa;
        private GridColumn colilosc;
        private GridColumn colPozycjaCenaNetto;
        private GridColumn colPozycjaWartoscNetto;
        private GridColumn colPozycjaCenaBrutto;
        private GridColumn colPozycjaWartoscBrutto;
        private SimpleButton btnDodajDokument;
        private GridColumn colDokumentNazwa;
    }
}