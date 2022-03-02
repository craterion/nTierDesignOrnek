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

namespace ders33_Tkrr_Ogrenci_Ders.UI.FORMS.Ogrenci
{
    public partial class frmOgrenciCRUD : Form
    {
        public frmOgrenciCRUD()
        {
            InitializeComponent();
        }

        private void btn_Detay_Click(object sender, EventArgs e)
        {
            frmOgrenciDetay f = new frmOgrenciDetay();
            f.ShowDialog();
        }
    }
}
