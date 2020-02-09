using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SirketOtomasyon2.Model
{
    public class ZimmetModel
    {
        public System.DateTime Tarih { get; set; }
        public int Yapan_Kisi_Id { get; set; }
        public Nullable<int> Yapilan_Kisi_No { get; set; }
        public Nullable<int> Parca_Id { get; set; }
        public Nullable<int> Pc_Id { get; set; }
        public string Not { get; set; }
    }
}
