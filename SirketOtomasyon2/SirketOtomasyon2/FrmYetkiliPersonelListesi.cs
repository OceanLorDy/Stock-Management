using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SirketOtomasyon2.Fonk;

namespace SirketOtomasyon2
{
    public partial class FrmYetkiliPersonelListesi : Form
    {
        public FrmYetkiliPersonelListesi()
        {
            InitializeComponent();
        }
        DataTable Tablo = new DataTable();
        private void FrmYetkiliPersonelListesi_Load(object sender, EventArgs e)
        {
            //gcYetPerList.Visible = true;
            PersonelF pF = new PersonelF();
            pF.YetkiliPersonelListele(Tablo, gcYetPerList);
        }
    }
}
