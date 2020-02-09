using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SirketOtomasyon2.Model
{
    public class ParcaModel
    {
        public int Parca_Id { get; set; }
        public Nullable<int> Pc_Id { get; set; }
        public string Tur { get; set; }
        public string Adi { get; set; }
        public Nullable<decimal> Fiyat { get; set; }
        public string Firma { get; set; }
        public Nullable<System.DateTime> Alinan_Tarih { get; set; }
        public Nullable<int> Stok_Durumu { get; set; }
        public string Model { get; set; }
        public string Marka { get; set; }
        public string Not { get; set; }
    }
}
