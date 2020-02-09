using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SirketOtomasyon2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        //Formların mdi parent olarak ana forma bağlıyoruz.
        FrmPesonelEkle frPe;
        private void barBtnPersonelEkle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Application.OpenForms["FrmPesonelEkle"] == null)
            {
                frPe = new FrmPesonelEkle();
                frPe.MdiParent = this;
                frPe.Show();
            }
        }
        FrmPersonelListele frPl;
        private void barbtnPerList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Application.OpenForms["FrmPersonelListele"] == null)
            {
                frPl = new FrmPersonelListele();
                frPl.MdiParent = this;
                frPl.Show();
            }
        }
        FrmYPersonelEkle frYp;
        private void barbtnYPersonelEkle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Application.OpenForms["FrmYPersonelEkle"] == null)
            {
                frYp = new FrmYPersonelEkle();
                frYp.MdiParent = this;
                frYp.Show();
            }
        }
        FrmYetkiliPersonelListesi frYfrYpList;
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Application.OpenForms["FrmYetkiliPersonelListesi"] == null)
            {
                frYfrYpList = new FrmYetkiliPersonelListesi();
                frYfrYpList.MdiParent = this;
                frYfrYpList.Show();
            }
        }
        FrmPcEkle frPcEkle;
        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Application.OpenForms["FrmPcEkle"] == null)
            {
                frPcEkle = new FrmPcEkle();
                frPcEkle.MdiParent = this;
                frPcEkle.Show();
            }
        }
        FrmParcaStokGoruntule frPcSg;
        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Application.OpenForms["FrmParcaStokGoruntule"] == null)
            {
                frPcSg = new FrmParcaStokGoruntule();
                frPcSg.MdiParent = this;
                frPcSg.Show();
            }
        }
        FrmParcaEkle frParcaEkle;
        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Application.OpenForms["FrmParcaEkle"]==null)
            {
                frParcaEkle = new FrmParcaEkle();
                frParcaEkle.MdiParent = this;
                frParcaEkle.Show();
            }
            
        }
        FrmParcaStokGoruntule frParcaSg;
        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Application.OpenForms["FrmParcaStokGoruntule"] == null)
            {
                frParcaSg = new FrmParcaStokGoruntule();
                frParcaSg.MdiParent = this;
                frParcaSg.Show();
            }
        }
    }
}
