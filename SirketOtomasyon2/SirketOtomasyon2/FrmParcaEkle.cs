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
    public partial class FrmParcaEkle : Form
    {
        public FrmParcaEkle()
        {
            InitializeComponent();
        }

        private void sbParcaEkle_Click(object sender, EventArgs e)
        {
            ParcaFonk pF = new ParcaFonk();
            ParcaModel pM = new ParcaModel();
            pM.Adi = txtParcaAdi.Text;
            pM.Fiyat = Convert.ToInt32(txtParcaFiyat.Text);
            pM.Firma = txtParcaFirma.Text;
            pM.Alinan_Tarih = Convert.ToDateTime(txtParcaTarih.Text);
            pM.Stok_Durumu = Convert.ToInt32(cbParcaStok.Text);
            pM.Marka = txtParcaMarka.Text;
            pM.Model = txtParcaModel.Text;
            pM.Not = txtParcaNot.Text;
            pM.Tur = cbParcaStok.Text;
            pF.ParcaEkle(pM);
            XtraMessageBox.Show("Ekleme İşlemi Tamamlandı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
