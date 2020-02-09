namespace SirketOtomasyon2
{
    partial class FrmParcaStokGoruntule
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
            this.gcParcaStok = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gcParcaStok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gcParcaStok
            // 
            this.gcParcaStok.Location = new System.Drawing.Point(12, 12);
            this.gcParcaStok.MainView = this.gridView1;
            this.gcParcaStok.Name = "gcParcaStok";
            this.gcParcaStok.Size = new System.Drawing.Size(928, 363);
            this.gcParcaStok.TabIndex = 0;
            this.gcParcaStok.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gcParcaStok;
            this.gridView1.Name = "gridView1";
            // 
            // FrmParcaStokGoruntule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 485);
            this.Controls.Add(this.gcParcaStok);
            this.Name = "FrmParcaStokGoruntule";
            this.Text = "FrmParcaStokGoruntule";
            this.Load += new System.EventHandler(this.FrmParcaStokGoruntule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcParcaStok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcParcaStok;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}