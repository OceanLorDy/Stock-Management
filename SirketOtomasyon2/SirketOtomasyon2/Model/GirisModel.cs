using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SirketOtomasyon2.Model
{
    public class GirisModel
    {
        public int Kullanici_Id { get; set; }
        public string Kullanici_Adi { get; set; }
        public string Sifre { get; set; }
        public string Kullanici_Tipi { get; set; }
        public int Personel_No { get; set; }
    }
}
