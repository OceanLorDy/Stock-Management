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
    public partial class FrmYPersonelEkle : Form
    {
        public FrmYPersonelEkle()
        {
            InitializeComponent();
        }
        private void FrmYPersonelEkle_Load(object sender, EventArgs e)
        {
            //gcPerList.Visible = true;
            PersonelF pF = new PersonelF();
            pF.PersonelListele(gcPerList);
        }
        private void btnYetPerKaydet_Click(object sender, EventArgs e)
        {
            PersonelF F1 = new PersonelF();
            GirisModel giris = new GirisModel();
            giris.Kullanici_Adi = txtKullaniciAdi.Text;
            giris.Sifre = txtSifre.Text;
            giris.Kullanici_Tipi = txtKullaniciTipi.Text;
            giris.Personel_No = Convert.ToInt32(txtPersonelNo.Text);
            F1.YetPersonelEkle(giris);
            XtraMessageBox.Show("Kayıt Tamamlandı","Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
