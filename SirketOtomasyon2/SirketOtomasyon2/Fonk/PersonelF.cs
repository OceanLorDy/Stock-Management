using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SirketOtomasyon2.Model;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace SirketOtomasyon2.Fonk
{
    public class PersonelF
    {
        //Personel Eklemek için Kullanıyoruz.
        public void PersonelEkle(PersonelModel personel)
        {
            SqlBaglanti.sqlBaglantiAc();
            SqlBaglanti.cmd.CommandText = "INSERT INTO tblPersonel(Ad,Soyad,Adres,Maas,Bolum,Baslama_Tarih) VALUES(@Ad,@Soyad,@Adres,@Maas,@Bolum,@Baslama_Tarih)";
            SqlBaglanti.cmd.Parameters.AddWithValue("@Ad", personel.Ad);
            SqlBaglanti.cmd.Parameters.AddWithValue("@Soyad", personel.Soyad);
            SqlBaglanti.cmd.Parameters.AddWithValue("@Adres", personel.Adres);
            SqlBaglanti.cmd.Parameters.AddWithValue("@Maas", personel.Maas);
            SqlBaglanti.cmd.Parameters.AddWithValue("@Bolum", personel.Bolum);
            SqlBaglanti.cmd.Parameters.AddWithValue("@Baslama_Tarih", DateTime.Now);
            SqlBaglanti.sqlBaglantiKapat();
        }
        //Personel Tablosunu oluşturmak için Kullanıyoruz.
        DataTable Tablo = new DataTable();
        public void PersonelListele(DevExpress.XtraGrid.GridControl gcPerList)
        {
            string komut = "SELECT * FROM tblPersonel";
            SqlBaglanti.tabloListele(Tablo, gcPerList, komut);
        }
        //Yetkili Personel Tablosunu oluşturmak için Kullanıyoruz.
        public void YetkiliPersonelListele(System.Data.DataTable Tablo, DevExpress.XtraGrid.GridControl gcYetPerList)
        {
            string komut = "SELECT P.Personel_No,P.Ad,P.Soyad,P.Adres,P.Maas,P.Bolum,P.Baslama_Tarih,Yp.Kullanici_Id,Yp.Kullanici_Adi,Yp.Sifre,Yp.Kullanici_Tipi FROM tblPersonel P INNER JOIN tblGiris Yp on p.personel_No=Yp.Personel_No";
            SqlBaglanti.tabloListele(Tablo, gcYetPerList, komut);
        }

        public void YetPersonelEkle(GirisModel giris)
        {
            SqlBaglanti.sqlBaglantiAc();
            SqlBaglanti.cmd.CommandText = "INSERT INTO tblGiris(Kullanici_Adi,Sifre,Kullanici_Tipi,Personel_No) VALUES(@Kullanici_Adi,@Sifre,@Kullanici_Tipi,@Personel_No)";
            SqlBaglanti.cmd.Parameters.AddWithValue("@Kullanici_Adi", giris.Kullanici_Adi);
            SqlBaglanti.cmd.Parameters.AddWithValue("@Sifre", giris.Sifre);
            SqlBaglanti.cmd.Parameters.AddWithValue("@Kullanici_Tipi", giris.Kullanici_Tipi);
            SqlBaglanti.cmd.Parameters.AddWithValue("Personel_No", giris.Personel_No);
            SqlBaglanti.sqlBaglantiKapat();
            
        }
    }
}
