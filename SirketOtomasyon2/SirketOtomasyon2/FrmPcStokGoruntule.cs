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
    public partial class FrmPcStokGoruntule : Form
    {
        public FrmPcStokGoruntule()
        {
            InitializeComponent();
        }

        private void FrmPcStokGoruntule_Load(object sender, EventArgs e)
        {
            gcPcStok.Visible = true;
            PcFonk pcF = new PcFonk();
            pcF.PcStokGoruntule(gcPcStok);
        }
    }
}
