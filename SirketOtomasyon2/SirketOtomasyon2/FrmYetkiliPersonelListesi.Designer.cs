﻿namespace SirketOtomasyon2
{
    partial class FrmYetkiliPersonelListesi
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
            this.gcYetPerList = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gcYetPerList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gcYetPerList
            // 
            this.gcYetPerList.Location = new System.Drawing.Point(12, 12);
            this.gcYetPerList.MainView = this.gridView1;
            this.gcYetPerList.Name = "gcYetPerList";
            this.gcYetPerList.Size = new System.Drawing.Size(1448, 338);
            this.gcYetPerList.TabIndex = 0;
            this.gcYetPerList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gcYetPerList;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // FrmYetkiliPersonelListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1472, 496);
            this.Controls.Add(this.gcYetPerList);
            this.Name = "FrmYetkiliPersonelListesi";
            this.Text = "FrmYetkiliPersonelListesi";
            this.Load += new System.EventHandler(this.FrmYetkiliPersonelListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcYetPerList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcYetPerList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}