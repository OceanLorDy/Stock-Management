using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SirketOtomasyon2.Fonk;
using SirketOtomasyon2.Model;
using DevExpress.XtraEditors;

namespace SirketOtomasyon2
{
    public partial class FrmPesonelEkle : Form
    {
        public FrmPesonelEkle()
        {
            InitializeComponent();
        }

        private void btnPerKaydet_Click(object sender, EventArgs e)
        {
            PersonelF p1 = new PersonelF();
            PersonelModel pm1 = new PersonelModel();
            pm1.Maas= Convert.ToInt32(txtMaas.Text);
            pm1.Ad = txtAd.Text;
            pm1.Soyad = txtSoyad.Text;
            pm1.Bolum = txtBolum.Text;
            pm1.Adres = txtAdres.Text;
            pm1.Baslama_Tarih = DateTime.Today;
            p1.PersonelEkle(pm1);
            XtraMessageBox.Show("Kayıt Tamamlandı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
