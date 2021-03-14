namespace DokumentyAL.Forms
{
    partial class FrmDokumentySzczegoly
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDokumentySzczegoly));
            this.btnAnuluj = new DevExpress.XtraEditors.SimpleButton();
            this.btnZapisz = new DevExpress.XtraEditors.SimpleButton();
            this.gcDokumentSzczegoly = new DevExpress.XtraGrid.GridControl();
            this.gvDokumentSzczegoly = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDokumentPozycjaId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDokumentId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProduktId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProduktNazwa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIlosc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCenaNetto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWartoscNetto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCenaBrutto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWartoscBrutto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblDataZlozenia = new System.Windows.Forms.Label();
            this.dtpDataZlozenia = new System.Windows.Forms.DateTimePicker();
            this.lblWartoscNetto = new System.Windows.Forms.Label();
            this.lblWartoscBrutto = new System.Windows.Forms.Label();
            this.lblNumerKlienta = new System.Windows.Forms.Label();
            this.teNumerKlienta = new DevExpress.XtraEditors.TextEdit();
            this.teWartoscNetto = new DevExpress.XtraEditors.TextEdit();
            this.teWartoscBrutto = new DevExpress.XtraEditors.TextEdit();
            this.btnUsunPozycje = new DevExpress.XtraEditors.SimpleButton();
            this.btnDodajPozycje = new DevExpress.XtraEditors.SimpleButton();
            this.teDokumentNazwa = new DevExpress.XtraEditors.TextEdit();
            this.lblDokumentNazwa = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gcDokumentSzczegoly)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDokumentSzczegoly)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teNumerKlienta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teWartoscNetto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teWartoscBrutto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teDokumentNazwa.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAnuluj
            // 
            this.btnAnuluj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnuluj.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnuluj.Location = new System.Drawing.Point(603, 662);
            this.btnAnuluj.Name = "btnAnuluj";
            this.btnAnuluj.Size = new System.Drawing.Size(185, 43);
            this.btnAnuluj.TabIndex = 14;
            this.btnAnuluj.Text = "Anuluj";
            // 
            // btnZapisz
            // 
            this.btnZapisz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnZapisz.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnZapisz.Location = new System.Drawing.Point(412, 662);
            this.btnZapisz.Name = "btnZapisz";
            this.btnZapisz.Size = new System.Drawing.Size(185, 43);
            this.btnZapisz.TabIndex = 13;
            this.btnZapisz.Text = "Zapisz";
            this.btnZapisz.Click += new System.EventHandler(this.btnZapisz_Click);
            // 
            // gcDokumentSzczegoly
            // 
            this.gcDokumentSzczegoly.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcDokumentSzczegoly.Location = new System.Drawing.Point(1, 156);
            this.gcDokumentSzczegoly.MainView = this.gvDokumentSzczegoly;
            this.gcDokumentSzczegoly.Name = "gcDokumentSzczegoly";
            this.gcDokumentSzczegoly.Size = new System.Drawing.Size(799, 500);
            this.gcDokumentSzczegoly.TabIndex = 12;
            this.gcDokumentSzczegoly.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDokumentSzczegoly});
            // 
            // gvDokumentSzczegoly
            // 
            this.gvDokumentSzczegoly.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDokumentPozycjaId,
            this.colDokumentId,
            this.colProduktId,
            this.colProduktNazwa,
            this.colIlosc,
            this.colCenaNetto,
            this.colWartoscNetto,
            this.colCenaBrutto,
            this.colWartoscBrutto});
            this.gvDokumentSzczegoly.GridControl = this.gcDokumentSzczegoly;
            this.gvDokumentSzczegoly.Name = "gvDokumentSzczegoly";
            this.gvDokumentSzczegoly.OptionsSelection.MultiSelect = true;
            this.gvDokumentSzczegoly.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gvDokumentSzczegoly.OptionsView.ShowGroupPanel = false;
            this.gvDokumentSzczegoly.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gvDokumentSzczegoly_CellValueChanged);
            this.gvDokumentSzczegoly.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gvDokumentSzczegoly_ValidateRow);
            // 
            // colDokumentPozycjaId
            // 
            this.colDokumentPozycjaId.Caption = "DokumentPozycjaId";
            this.colDokumentPozycjaId.FieldName = "dokument_pozycja_id";
            this.colDokumentPozycjaId.MinWidth = 25;
            this.colDokumentPozycjaId.Name = "colDokumentPozycjaId";
            this.colDokumentPozycjaId.OptionsColumn.AllowEdit = false;
            this.colDokumentPozycjaId.Width = 94;
            // 
            // colDokumentId
            // 
            this.colDokumentId.Caption = "DokumentId";
            this.colDokumentId.FieldName = "dokument_id";
            this.colDokumentId.MinWidth = 25;
            this.colDokumentId.Name = "colDokumentId";
            this.colDokumentId.OptionsColumn.AllowEdit = false;
            this.colDokumentId.Width = 94;
            // 
            // colProduktId
            // 
            this.colProduktId.Caption = "ProduktId";
            this.colProduktId.FieldName = "produkt_id";
            this.colProduktId.MinWidth = 25;
            this.colProduktId.Name = "colProduktId";
            this.colProduktId.OptionsColumn.AllowEdit = false;
            this.colProduktId.Width = 94;
            // 
            // colProduktNazwa
            // 
            this.colProduktNazwa.Caption = "Nazwa produktu";
            this.colProduktNazwa.FieldName = "nazwa";
            this.colProduktNazwa.MinWidth = 25;
            this.colProduktNazwa.Name = "colProduktNazwa";
            this.colProduktNazwa.OptionsColumn.AllowEdit = false;
            this.colProduktNazwa.Visible = true;
            this.colProduktNazwa.VisibleIndex = 1;
            this.colProduktNazwa.Width = 94;
            // 
            // colIlosc
            // 
            this.colIlosc.Caption = "Ilość";
            this.colIlosc.FieldName = "ilosc";
            this.colIlosc.MinWidth = 25;
            this.colIlosc.Name = "colIlosc";
            this.colIlosc.Visible = true;
            this.colIlosc.VisibleIndex = 2;
            this.colIlosc.Width = 94;
            // 
            // colCenaNetto
            // 
            this.colCenaNetto.Caption = "Cena netto";
            this.colCenaNetto.FieldName = "cena_jednostkowa_netto";
            this.colCenaNetto.MinWidth = 25;
            this.colCenaNetto.Name = "colCenaNetto";
            this.colCenaNetto.OptionsColumn.AllowEdit = false;
            this.colCenaNetto.Visible = true;
            this.colCenaNetto.VisibleIndex = 3;
            this.colCenaNetto.Width = 94;
            // 
            // colWartoscNetto
            // 
            this.colWartoscNetto.Caption = "Wartość netto";
            this.colWartoscNetto.FieldName = "wartosc_netto";
            this.colWartoscNetto.MinWidth = 25;
            this.colWartoscNetto.Name = "colWartoscNetto";
            this.colWartoscNetto.OptionsColumn.AllowEdit = false;
            this.colWartoscNetto.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "wartosc_netto", "SUM={0:0.##}")});
            this.colWartoscNetto.Visible = true;
            this.colWartoscNetto.VisibleIndex = 4;
            this.colWartoscNetto.Width = 94;
            // 
            // colCenaBrutto
            // 
            this.colCenaBrutto.Caption = "Cena brutto";
            this.colCenaBrutto.FieldName = "cena_jednostkowa_brutto";
            this.colCenaBrutto.MinWidth = 25;
            this.colCenaBrutto.Name = "colCenaBrutto";
            this.colCenaBrutto.OptionsColumn.AllowEdit = false;
            this.colCenaBrutto.Visible = true;
            this.colCenaBrutto.VisibleIndex = 5;
            this.colCenaBrutto.Width = 94;
            // 
            // colWartoscBrutto
            // 
            this.colWartoscBrutto.Caption = "Wartość brutto";
            this.colWartoscBrutto.FieldName = "wartosc_brutto";
            this.colWartoscBrutto.MinWidth = 25;
            this.colWartoscBrutto.Name = "colWartoscBrutto";
            this.colWartoscBrutto.OptionsColumn.AllowEdit = false;
            this.colWartoscBrutto.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "wartosc_brutto", "SUM={0:0.##}")});
            this.colWartoscBrutto.Visible = true;
            this.colWartoscBrutto.VisibleIndex = 6;
            this.colWartoscBrutto.Width = 94;
            // 
            // lblDataZlozenia
            // 
            this.lblDataZlozenia.AutoSize = true;
            this.lblDataZlozenia.Location = new System.Drawing.Point(91, 68);
            this.lblDataZlozenia.Name = "lblDataZlozenia";
            this.lblDataZlozenia.Size = new System.Drawing.Size(98, 17);
            this.lblDataZlozenia.TabIndex = 4;
            this.lblDataZlozenia.Text = "Data złożenia:";
            // 
            // dtpDataZlozenia
            // 
            this.dtpDataZlozenia.CustomFormat = "yyyy-MM-dd";
            this.dtpDataZlozenia.Enabled = false;
            this.dtpDataZlozenia.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataZlozenia.Location = new System.Drawing.Point(195, 68);
            this.dtpDataZlozenia.Name = "dtpDataZlozenia";
            this.dtpDataZlozenia.Size = new System.Drawing.Size(172, 22);
            this.dtpDataZlozenia.TabIndex = 5;
            // 
            // lblWartoscNetto
            // 
            this.lblWartoscNetto.AutoSize = true;
            this.lblWartoscNetto.Location = new System.Drawing.Point(12, 99);
            this.lblWartoscNetto.Name = "lblWartoscNetto";
            this.lblWartoscNetto.Size = new System.Drawing.Size(177, 17);
            this.lblWartoscNetto.TabIndex = 6;
            this.lblWartoscNetto.Text = "Wartość netto zamówienia:";
            // 
            // lblWartoscBrutto
            // 
            this.lblWartoscBrutto.AutoSize = true;
            this.lblWartoscBrutto.Location = new System.Drawing.Point(7, 127);
            this.lblWartoscBrutto.Name = "lblWartoscBrutto";
            this.lblWartoscBrutto.Size = new System.Drawing.Size(182, 17);
            this.lblWartoscBrutto.TabIndex = 8;
            this.lblWartoscBrutto.Text = "Wartość brutto zamówienia:";
            // 
            // lblNumerKlienta
            // 
            this.lblNumerKlienta.AutoSize = true;
            this.lblNumerKlienta.Location = new System.Drawing.Point(94, 15);
            this.lblNumerKlienta.Name = "lblNumerKlienta";
            this.lblNumerKlienta.Size = new System.Drawing.Size(95, 17);
            this.lblNumerKlienta.TabIndex = 0;
            this.lblNumerKlienta.Text = "Numer klienta";
            // 
            // teNumerKlienta
            // 
            this.teNumerKlienta.Enabled = false;
            this.teNumerKlienta.Location = new System.Drawing.Point(195, 12);
            this.teNumerKlienta.Name = "teNumerKlienta";
            this.teNumerKlienta.Size = new System.Drawing.Size(172, 22);
            this.teNumerKlienta.TabIndex = 1;
            // 
            // teWartoscNetto
            // 
            this.teWartoscNetto.Enabled = false;
            this.teWartoscNetto.Location = new System.Drawing.Point(195, 96);
            this.teWartoscNetto.Name = "teWartoscNetto";
            this.teWartoscNetto.Size = new System.Drawing.Size(172, 22);
            this.teWartoscNetto.TabIndex = 7;
            // 
            // teWartoscBrutto
            // 
            this.teWartoscBrutto.Enabled = false;
            this.teWartoscBrutto.Location = new System.Drawing.Point(195, 124);
            this.teWartoscBrutto.Name = "teWartoscBrutto";
            this.teWartoscBrutto.Size = new System.Drawing.Size(172, 22);
            this.teWartoscBrutto.TabIndex = 9;
            // 
            // btnUsunPozycje
            // 
            this.btnUsunPozycje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUsunPozycje.Location = new System.Drawing.Point(603, 122);
            this.btnUsunPozycje.Name = "btnUsunPozycje";
            this.btnUsunPozycje.Size = new System.Drawing.Size(185, 26);
            this.btnUsunPozycje.TabIndex = 11;
            this.btnUsunPozycje.Text = "Usuń pozycje";
            this.btnUsunPozycje.Click += new System.EventHandler(this.btnUsunPozycje_Click);
            // 
            // btnDodajPozycje
            // 
            this.btnDodajPozycje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDodajPozycje.Location = new System.Drawing.Point(412, 122);
            this.btnDodajPozycje.Name = "btnDodajPozycje";
            this.btnDodajPozycje.Size = new System.Drawing.Size(185, 26);
            this.btnDodajPozycje.TabIndex = 10;
            this.btnDodajPozycje.Text = "Dodaj pozycje";
            this.btnDodajPozycje.Click += new System.EventHandler(this.btnDodajPozycje_Click);
            // 
            // teDokumentNazwa
            // 
            this.teDokumentNazwa.Location = new System.Drawing.Point(195, 40);
            this.teDokumentNazwa.Name = "teDokumentNazwa";
            this.teDokumentNazwa.Size = new System.Drawing.Size(172, 22);
            this.teDokumentNazwa.TabIndex = 3;
            this.teDokumentNazwa.Validating += new System.ComponentModel.CancelEventHandler(this.teDokumentNazwa_Validating);
            // 
            // lblDokumentNazwa
            // 
            this.lblDokumentNazwa.AutoSize = true;
            this.lblDokumentNazwa.Location = new System.Drawing.Point(61, 43);
            this.lblDokumentNazwa.Name = "lblDokumentNazwa";
            this.lblDokumentNazwa.Size = new System.Drawing.Size(128, 17);
            this.lblDokumentNazwa.TabIndex = 2;
            this.lblDokumentNazwa.Text = "Nazwa dokumentu:";
            // 
            // FrmDokumentySzczegoly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 717);
            this.Controls.Add(this.lblDokumentNazwa);
            this.Controls.Add(this.teDokumentNazwa);
            this.Controls.Add(this.btnUsunPozycje);
            this.Controls.Add(this.btnDodajPozycje);
            this.Controls.Add(this.teWartoscBrutto);
            this.Controls.Add(this.teWartoscNetto);
            this.Controls.Add(this.teNumerKlienta);
            this.Controls.Add(this.lblNumerKlienta);
            this.Controls.Add(this.lblWartoscBrutto);
            this.Controls.Add(this.lblWartoscNetto);
            this.Controls.Add(this.dtpDataZlozenia);
            this.Controls.Add(this.lblDataZlozenia);
            this.Controls.Add(this.btnAnuluj);
            this.Controls.Add(this.btnZapisz);
            this.Controls.Add(this.gcDokumentSzczegoly);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDokumentySzczegoly";
            this.Text = "Dokument";
            this.Load += new System.EventHandler(this.frmDokumentySzczegoly_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcDokumentSzczegoly)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDokumentSzczegoly)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teNumerKlienta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teWartoscNetto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teWartoscBrutto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teDokumentNazwa.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnAnuluj;
        private DevExpress.XtraEditors.SimpleButton btnZapisz;
        private DevExpress.XtraGrid.GridControl gcDokumentSzczegoly;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDokumentSzczegoly;
        private DevExpress.XtraGrid.Columns.GridColumn colProduktId;
        private DevExpress.XtraGrid.Columns.GridColumn colProduktNazwa;
        private DevExpress.XtraGrid.Columns.GridColumn colCenaNetto;
        private DevExpress.XtraGrid.Columns.GridColumn colCenaBrutto;
        private DevExpress.XtraGrid.Columns.GridColumn colDokumentPozycjaId;
        private DevExpress.XtraGrid.Columns.GridColumn colDokumentId;
        private DevExpress.XtraGrid.Columns.GridColumn colIlosc;
        private DevExpress.XtraGrid.Columns.GridColumn colWartoscNetto;
        private DevExpress.XtraGrid.Columns.GridColumn colWartoscBrutto;
        private System.Windows.Forms.Label lblDataZlozenia;
        private System.Windows.Forms.DateTimePicker dtpDataZlozenia;
        private System.Windows.Forms.Label lblWartoscNetto;
        private System.Windows.Forms.Label lblWartoscBrutto;
        private System.Windows.Forms.Label lblNumerKlienta;
        private DevExpress.XtraEditors.TextEdit teNumerKlienta;
        private DevExpress.XtraEditors.TextEdit teWartoscNetto;
        private DevExpress.XtraEditors.TextEdit teWartoscBrutto;
        private DevExpress.XtraEditors.SimpleButton btnUsunPozycje;
        private DevExpress.XtraEditors.SimpleButton btnDodajPozycje;
        private DevExpress.XtraEditors.TextEdit teDokumentNazwa;
        private System.Windows.Forms.Label lblDokumentNazwa;
    }
}