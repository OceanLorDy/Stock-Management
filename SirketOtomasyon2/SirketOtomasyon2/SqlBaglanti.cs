using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SirketOtomasyon2
{
    public static class SqlBaglanti
    {
        public static SqlConnection Baglanti;
        public static SqlCommand cmd;

        public static void sqlBaglantiAc()
        {
            cmd = new SqlCommand();
            Baglanti = new SqlConnection("Data Source=DESKTOP-6DEJPKE\\SQLEXPRESS;Initial Catalog=Stok4;Integrated Security=True");
            Baglanti.Open();
            cmd.Connection = Baglanti;
        }

        public static void sqlBaglantiKapat()
        {
            SqlBaglanti.cmd.ExecuteNonQuery();
            SqlBaglanti.Baglanti.Close();
        }

        public static void tabloListele(System.Data.DataTable Tablo, DevExpress.XtraGrid.GridControl gcPerList, string komut)
        {
            sqlBaglantiAc();
            cmd.CommandText = komut;
            SqlDataAdapter dAdp = new SqlDataAdapter(SqlBaglanti.cmd);
            Tablo.Clear();
            Tablo.Columns.Clear();
            gcPerList.DataSource = null;
            dAdp.Fill(Tablo);
            gcPerList.DataSource = Tablo;
            sqlBaglantiKapat();
        }   
        public static void girisKontrol(string a,string komut)
        {
            sqlBaglantiAc();
            komut = "SELECT Kullanici_Id FROM tblGiris";
            sqlBaglantiKapat();

        }
    }
}
