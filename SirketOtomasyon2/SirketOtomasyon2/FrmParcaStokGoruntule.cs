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
using SirketOtomasyon2.Model;

namespace SirketOtomasyon2
{
    public partial class FrmParcaStokGoruntule : Form
    {
        public FrmParcaStokGoruntule()
        {
            InitializeComponent();
        }

        private void FrmParcaStokGoruntule_Load(object sender, EventArgs e)
        {
            gcParcaStok.Visible = true;
            ParcaFonk parcaF = new ParcaFonk();
            parcaF.ParcaStokGoruntule(gcParcaStok);
        }
    }
}
