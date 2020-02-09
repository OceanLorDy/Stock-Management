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
    public class PcFonk

    {
        //Pc Eklemek için bu fonk. kullanıyoruz.
        public void PcEkle(PcModel Pc)
        {
            SqlBaglanti.sqlBaglantiAc();
            SqlBaglanti.cmd.CommandText = "INSERT INTO tblPc(Adi,Fiyat,Firma,Alinan_Tarih,Stok_Durumu,Model,Marka) VALUES(@Adi,@Fiyat,@Firma,@Alinan_Tarih,@Stok_Durumu,@Model,@Marka)";
            SqlBaglanti.cmd.Parameters.AddWithValue("@Adi", Pc.Adi);
            SqlBaglanti.cmd.Parameters.AddWithValue("@Fiyat", Pc.Fiyat);
            SqlBaglanti.cmd.Parameters.AddWithValue("@Firma", Pc.Firma);
            SqlBaglanti.cmd.Parameters.AddWithValue("@Alinan_Tarih", Pc.Alinan_Tarih);
            SqlBaglanti.cmd.Parameters.AddWithValue("@Stok_Durumu", Pc.Stok_Durumu);
            SqlBaglanti.cmd.Parameters.AddWithValue("@Model", Pc.Model);
            SqlBaglanti.cmd.Parameters.AddWithValue("@Marka", Pc.Marka);
            SqlBaglanti.sqlBaglantiKapat();
        }
        DataTable Tablo = new DataTable();

        public void PcStokGoruntule(DevExpress.XtraGrid.GridControl gcStokGoruntule)
        {
            
            string komut = "SELECT * FROM tblPc WHERE Stok_Durumu=1";
            SqlBaglanti.tabloListele(Tablo, gcStokGoruntule, komut);
        }
    }
}
