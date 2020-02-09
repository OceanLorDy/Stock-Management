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
using SirketOtomasyon2.Fonk;
using SirketOtomasyon2.Model;

namespace SirketOtomasyon2
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        SqlConnection Baglan = new SqlConnection("Data Source=DESKTOP-6DEJPKE\\SQLEXPRESS;Initial Catalog=Stok4;Integrated Security=True");
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlBaglanti.sqlBaglantiAc();
                string komut = "Select Kullanici_Adi,Sifre FROM tblGiris WHERE Kullanici_Adi=@Adi AND Sifre =@Sfree";
                SqlParameter prm1 = new SqlParameter("Adi", txtGirisKullaniciId.Text);
                SqlParameter prm2 = new SqlParameter("Sfree", txtKullaniciSifre.Text);
                SqlCommand cmd = new SqlCommand(komut, Baglan);
                cmd.Parameters.Add(prm1);
                cmd.Parameters.Add(prm2);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                if(dt.Rows.Count > 0)
                {
                    Form1 fr = new Form1();
                    fr.Show();
                    this.Hide();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hatali Giris");
            }

        }
    }
}
