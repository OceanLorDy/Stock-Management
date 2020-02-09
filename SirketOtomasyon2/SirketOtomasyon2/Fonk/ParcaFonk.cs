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
    public class ParcaFonk
    {
        public void ParcaEkle(ParcaModel Parca)
        {
            SqlBaglanti.sqlBaglantiAc();
            SqlBaglanti.cmd.CommandText = "INSERT INTO tblParca(Adi,Fiyat,Firma,Alinan_Tarih,Stok_Durumu,Model,Tur,Marka) VALUES(@Adi,@Fiyat,@Firma,@Alinan_Tarih,@Stok_Durumu,@Model,@Tur,@Marka)";
            SqlBaglanti.cmd.Parameters.AddWithValue("@Adi", Parca.Adi);
            SqlBaglanti.cmd.Parameters.AddWithValue("@Fiyat", Parca.Fiyat);
            SqlBaglanti.cmd.Parameters.AddWithValue("@Firma", Parca.Firma);
            SqlBaglanti.cmd.Parameters.AddWithValue("@Alinan_Tarih", Parca.Alinan_Tarih);
            SqlBaglanti.cmd.Parameters.AddWithValue("@Stok_Durumu", Parca.Stok_Durumu);
            SqlBaglanti.cmd.Parameters.AddWithValue("@Model", Parca.Model);
            SqlBaglanti.cmd.Parameters.AddWithValue("@Tur", Parca.Tur);
            SqlBaglanti.cmd.Parameters.AddWithValue("@Marka", Parca.Marka);
            SqlBaglanti.sqlBaglantiKapat();
        }
        DataTable Tablo = new DataTable();
        public void ParcaStokGoruntule(DevExpress.XtraGrid.GridControl gcParcaStokGoruntule)
        {
            string komut = "SELECT * FROM tblParca WHERE Stok_Durumu=1";
            SqlBaglanti.tabloListele(Tablo, gcParcaStokGoruntule, komut);
        }
    }
}
