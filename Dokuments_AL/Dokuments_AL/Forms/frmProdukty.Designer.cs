namespace DokumentyAL.Forms
{
    partial class FrmProdukty
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProdukty));
            this.gcProdukty = new DevExpress.XtraGrid.GridControl();
            this.gvProdukty = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProduktId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProduktNazwa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCenaId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCenaNetto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCenaBrutto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnDodaj = new DevExpress.XtraEditors.SimpleButton();
            this.btnAnuluj = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gcProdukty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProdukty)).BeginInit();
            this.SuspendLayout();
            // 
            // gcProdukty
            // 
            this.gcProdukty.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcProdukty.Location = new System.Drawing.Point(1, 2);
            this.gcProdukty.MainView = this.gvProdukty;
            this.gcProdukty.Name = "gcProdukty";
            this.gcProdukty.Size = new System.Drawing.Size(614, 528);
            this.gcProdukty.TabIndex = 0;
            this.gcProdukty.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvProdukty});
            // 
            // gvProdukty
            // 
            this.gvProdukty.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProduktId,
            this.colProduktNazwa,
            this.colCenaId,
            this.colCenaNetto,
            this.colCenaBrutto});
            this.gvProdukty.GridControl = this.gcProdukty;
            this.gvProdukty.Name = "gvProdukty";
            this.gvProdukty.OptionsSelection.MultiSelect = true;
            this.gvProdukty.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gvProdukty.OptionsView.ShowGroupPanel = false;
            // 
            // colProduktId
            // 
            this.colProduktId.Caption = "ProduktId";
            this.colProduktId.FieldName = "produkt_id";
            this.colProduktId.MinWidth = 25;
            this.colProduktId.Name = "colProduktId";
            this.colProduktId.Width = 94;
            // 
            // colProduktNazwa
            // 
            this.colProduktNazwa.Caption = "Nazwa produktu";
            this.colProduktNazwa.FieldName = "nazwa";
            this.colProduktNazwa.MinWidth = 25;
            this.colProduktNazwa.Name = "colProduktNazwa";
            this.colProduktNazwa.Visible = true;
            this.colProduktNazwa.VisibleIndex = 1;
            this.colProduktNazwa.Width = 94;
            // 
            // colCenaId
            // 
            this.colCenaId.Caption = "CenaId";
            this.colCenaId.FieldName = "cena_id";
            this.colCenaId.MinWidth = 25;
            this.colCenaId.Name = "colCenaId";
            this.colCenaId.Width = 94;
            // 
            // colCenaNetto
            // 
            this.colCenaNetto.Caption = "cena netto";
            this.colCenaNetto.FieldName = "cena_netto";
            this.colCenaNetto.MinWidth = 25;
            this.colCenaNetto.Name = "colCenaNetto";
            this.colCenaNetto.Visible = true;
            this.colCenaNetto.VisibleIndex = 2;
            this.colCenaNetto.Width = 94;
            // 
            // colCenaBrutto
            // 
            this.colCenaBrutto.Caption = "Cena brutto";
            this.colCenaBrutto.FieldName = "cena_brutto";
            this.colCenaBrutto.MinWidth = 25;
            this.colCenaBrutto.Name = "colCenaBrutto";
            this.colCenaBrutto.Visible = true;
            this.colCenaBrutto.VisibleIndex = 3;
            this.colCenaBrutto.Width = 94;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDodaj.Location = new System.Drawing.Point(300, 536);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(148, 34);
            this.btnDodaj.TabIndex = 1;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnAnuluj
            // 
            this.btnAnuluj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnuluj.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnuluj.Location = new System.Drawing.Point(454, 536);
            this.btnAnuluj.Name = "btnAnuluj";
            this.btnAnuluj.Size = new System.Drawing.Size(148, 34);
            this.btnAnuluj.TabIndex = 2;
            this.btnAnuluj.Text = "Anuluj";
            this.btnAnuluj.Click += new System.EventHandler(this.btnAnuluj_Click);
            // 
            // FrmProdukty
            // 
            this.AcceptButton = this.btnDodaj;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAnuluj;
            this.ClientSize = new System.Drawing.Size(614, 582);
            this.Controls.Add(this.btnAnuluj);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.gcProdukty);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmProdukty";
            this.Text = "Dodaj pozycje";
            this.Load += new System.EventHandler(this.frmProdukty_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcProdukty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProdukty)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcProdukty;
        private DevExpress.XtraGrid.Views.Grid.GridView gvProdukty;
        private DevExpress.XtraGrid.Columns.GridColumn colProduktId;
        private DevExpress.XtraGrid.Columns.GridColumn colProduktNazwa;
        private DevExpress.XtraGrid.Columns.GridColumn colCenaNetto;
        private DevExpress.XtraGrid.Columns.GridColumn colCenaBrutto;
        private DevExpress.XtraEditors.SimpleButton btnDodaj;
        private DevExpress.XtraEditors.SimpleButton btnAnuluj;
        private DevExpress.XtraGrid.Columns.GridColumn colCenaId;
    }
}