namespace SirketOtomasyon2
{
    partial class FrmYPersonelEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmYPersonelEkle));
            this.btnYetPerKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtKullaniciTipi = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtPersonelNo = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.gcPerList = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gcPerList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnYetPerKaydet
            // 
            this.btnYetPerKaydet.Appearance.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYetPerKaydet.Appearance.Options.UseFont = true;
            this.btnYetPerKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnYetPerKaydet.ImageOptions.Image")));
            this.btnYetPerKaydet.Location = new System.Drawing.Point(163, 331);
            this.btnYetPerKaydet.Name = "btnYetPerKaydet";
            this.btnYetPerKaydet.Size = new System.Drawing.Size(167, 59);
            this.btnYetPerKaydet.TabIndex = 2;
            this.btnYetPerKaydet.Text = "Kaydet";
            this.btnYetPerKaydet.Click += new System.EventHandler(this.btnYetPerKaydet_Click);
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(181, 79);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(149, 22);
            this.txtKullaniciAdi.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Kullanıcı Adı :";
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(181, 135);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(149, 22);
            this.txtSifre.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(66, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "Şifre";
            // 
            // txtKullaniciTipi
            // 
            this.txtKullaniciTipi.Location = new System.Drawing.Point(181, 191);
            this.txtKullaniciTipi.Name = "txtKullaniciTipi";
            this.txtKullaniciTipi.Size = new System.Drawing.Size(149, 22);
            this.txtKullaniciTipi.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(66, 191);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 17);
            this.label13.TabIndex = 1;
            this.label13.Text = "Kullanıcı Tipi :";
            // 
            // txtPersonelNo
            // 
            this.txtPersonelNo.Location = new System.Drawing.Point(181, 247);
            this.txtPersonelNo.Name = "txtPersonelNo";
            this.txtPersonelNo.Size = new System.Drawing.Size(149, 22);
            this.txtPersonelNo.TabIndex = 0;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(66, 247);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(94, 17);
            this.label17.TabIndex = 1;
            this.label17.Text = "Personel No :";
            // 
            // gcPerList
            // 
            this.gcPerList.Location = new System.Drawing.Point(413, 79);
            this.gcPerList.MainView = this.gridView1;
            this.gcPerList.Name = "gcPerList";
            this.gcPerList.Size = new System.Drawing.Size(899, 467);
            this.gcPerList.TabIndex = 3;
            this.gcPerList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gcPerList;
            this.gridView1.Name = "gridView1";
            // 
            // FrmYPersonelEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 596);
            this.Controls.Add(this.gcPerList);
            this.Controls.Add(this.btnYetPerKaydet);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPersonelNo);
            this.Controls.Add(this.txtKullaniciTipi);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Name = "FrmYPersonelEkle";
            this.Text = "FrmYPersonelEkle";
            this.Load += new System.EventHandler(this.FrmYPersonelEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcPerList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnYetPerKaydet;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtKullaniciTipi;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtPersonelNo;
        private System.Windows.Forms.Label label17;
        private DevExpress.XtraGrid.GridControl gcPerList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}