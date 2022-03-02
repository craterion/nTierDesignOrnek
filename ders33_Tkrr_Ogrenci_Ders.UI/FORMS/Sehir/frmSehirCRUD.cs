using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ders33_Tkrr_Ogrenci_Ders.BusinessLayer;

namespace ders33_Tkrr_Ogrenci_Ders.UI.FORMS.Sehir
{
    public partial class frmSehirCRUD : Form
    {
        public frmSehirCRUD()
        {
            InitializeComponent();
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            bool sonuc = cls_sehir.sehir_insert(txt_SehirAdi.Text);
            if (sonuc == true)
            {
                MessageBox.Show("şehir başarıyla kaydedildi");
                listview_Doldur();
            }
            else
            {
                MessageBox.Show("Şehir kaydedilemedi! Hata!");

            }
            txt_SehirAdi.Text = "";

        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {

        }

        private void txt_SehirAdi_TextChanged(object sender, EventArgs e)
        {
            if (txt_SehirAdi.Text.Length > 2)
            {
                btn_Kaydet.Visible = true;
            }
            else
            {
                btn_Kaydet.Visible = false;
            }
        }

        private void frmSehirCRUD_Load(object sender, EventArgs e)
        {
            btn_Kaydet.Visible = false;
            listview_Doldur();

        }
        void listview_Doldur()
        {
            lst_sehirler.Items.Clear();
            SqlDataReader sdr = cls_sehir.sehir_select();
            while (sdr.Read())
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = sdr[0].ToString();
                lvi.SubItems.Add(sdr[1].ToString().Trim());

                lst_sehirler.Items.Add(lvi);
            }
        }
        int listviewID = 0;

        private void lst_sehirler_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
