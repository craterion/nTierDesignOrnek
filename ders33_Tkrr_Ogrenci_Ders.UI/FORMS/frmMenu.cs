using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ders33_Tkrr_Ogrenci_Ders.UI.FORMS.Ogrenci;
using ders33_Tkrr_Ogrenci_Ders.UI.FORMS.Sehir;
using ders33_Tkrr_Ogrenci_Ders.UI.FORMS.Ders;

namespace ders33_Tkrr_Ogrenci_Ders.UI.FORMS
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void öğrenciKaydetFormuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOgrenciCRUD f = new frmOgrenciCRUD();
            f.ShowDialog();
        }

        private void öğrencininDersleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOgrenciDERS f = new frmOgrenciDERS();
            f.ShowDialog();
        }

        private void şehirCRUDFormuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSehirCRUD f = new frmSehirCRUD();
            f.ShowDialog();
        }

        private void dersCRUDFormuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDersCRUD f = new frmDersCRUD();
            f.ShowDialog();
        }
    }
}
