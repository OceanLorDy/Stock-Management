using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SirketOtomasyon2.Model
{
    public class PersonelModel
    {
        public int Personel_No { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Adres { get; set; }
        public Nullable<decimal> Maas { get; set; }
        public Nullable<System.DateTime> Baslama_Tarih { get; set; }
        public string Bolum { get; set; }
        public int Pc_Id { get; set; }
    }
}
