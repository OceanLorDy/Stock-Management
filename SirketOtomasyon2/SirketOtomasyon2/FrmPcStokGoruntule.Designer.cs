namespace SirketOtomasyon2
{
    partial class FrmPcStokGoruntule
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
            this.gcPcStok = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gcPcStok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gcPcStok
            // 
            this.gcPcStok.Location = new System.Drawing.Point(12, 12);
            this.gcPcStok.MainView = this.gridView1;
            this.gcPcStok.Name = "gcPcStok";
            this.gcPcStok.Size = new System.Drawing.Size(700, 339);
            this.gcPcStok.TabIndex = 0;
            this.gcPcStok.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gcPcStok;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // FrmPcStokGoruntule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 575);
            this.Controls.Add(this.gcPcStok);
            this.Name = "FrmPcStokGoruntule";
            this.Text = "FrmPcStokGoruntule";
            this.Load += new System.EventHandler(this.FrmPcStokGoruntule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcPcStok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcPcStok;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}