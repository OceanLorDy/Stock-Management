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
    public partial class FrmPcEkle : Form
    {
        public FrmPcEkle()
        {
            InitializeComponent();
        }
        private void sbPcEkle_Click(object sender, EventArgs e)
        {
            PcFonk pc = new PcFonk();
            PcModel pcM = new PcModel();
            pcM.Adi =txtPcAdi.Text;
            pcM.Fiyat =Convert.ToInt32(txtPcFiyat.Text);
            pcM.Firma =txtPcFirma.Text;
            pcM.Alinan_Tarih =Convert.ToDateTime(txtPcTarih.Text);
            pcM.Stok_Durumu = Convert.ToInt32(cbPcStok.Text);
            pcM.Marka =txtPcMarka.Text;
            pcM.Model =txtPcModel.Text;
            pcM.Not =txtPcNot.Text;
            pc.PcEkle(pcM);
            XtraMessageBox.Show("Ekleme İşlemi Tamamlandı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
