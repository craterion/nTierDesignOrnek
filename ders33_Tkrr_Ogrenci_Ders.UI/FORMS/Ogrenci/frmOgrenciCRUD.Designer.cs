namespace ders33_Tkrr_Ogrenci_Ders.UI.FORMS.Ogrenci
{
    partial class frmOgrenciCRUD
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_OgrenciAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_Sehir = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Telefon = new System.Windows.Forms.TextBox();
            this.lst_Ogrenciler = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_Kaydet = new System.Windows.Forms.Button();
            this.btn_Guncelle = new System.Windows.Forms.Button();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.btn_Detay = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_OgrenciAdres = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_OgrenciAciklama = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(204, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ÖĞRENCİ CRUD İŞLEMLERİ FORMU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Öğrenci Adı";
            // 
            // txt_OgrenciAdi
            // 
            this.txt_OgrenciAdi.Location = new System.Drawing.Point(208, 32);
            this.txt_OgrenciAdi.Name = "txt_OgrenciAdi";
            this.txt_OgrenciAdi.Size = new System.Drawing.Size(128, 20);
            this.txt_OgrenciAdi.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Şehir";
            // 
            // cmb_Sehir
            // 
            this.cmb_Sehir.FormattingEnabled = true;
            this.cmb_Sehir.Location = new System.Drawing.Point(208, 62);
            this.cmb_Sehir.Name = "cmb_Sehir";
            this.cmb_Sehir.Size = new System.Drawing.Size(121, 21);
            this.cmb_Sehir.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Telefon";
            // 
            // txt_Telefon
            // 
            this.txt_Telefon.Location = new System.Drawing.Point(208, 115);
            this.txt_Telefon.Name = "txt_Telefon";
            this.txt_Telefon.Size = new System.Drawing.Size(100, 20);
            this.txt_Telefon.TabIndex = 6;
            // 
            // lst_Ogrenciler
            // 
            this.lst_Ogrenciler.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lst_Ogrenciler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lst_Ogrenciler.GridLines = true;
            this.lst_Ogrenciler.HideSelection = false;
            this.lst_Ogrenciler.Location = new System.Drawing.Point(342, 32);
            this.lst_Ogrenciler.Name = "lst_Ogrenciler";
            this.lst_Ogrenciler.Size = new System.Drawing.Size(429, 239);
            this.lst_Ogrenciler.TabIndex = 7;
            this.lst_Ogrenciler.UseCompatibleStateImageBehavior = false;
            this.lst_Ogrenciler.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "OgrenciID";
            this.columnHeader1.Width = 70;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Öğrenci Adı";
            this.columnHeader2.Width = 206;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Memleket";
            this.columnHeader3.Width = 61;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Telefon";
            this.columnHeader4.Width = 80;
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_Kaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Kaydet.Location = new System.Drawing.Point(19, 204);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(92, 38);
            this.btn_Kaydet.TabIndex = 8;
            this.btn_Kaydet.Text = "KAYDET";
            this.btn_Kaydet.UseVisualStyleBackColor = false;
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.BackColor = System.Drawing.SystemColors.Info;
            this.btn_Guncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Guncelle.Location = new System.Drawing.Point(19, 248);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(92, 38);
            this.btn_Guncelle.TabIndex = 9;
            this.btn_Guncelle.Text = "GÜNCELLE";
            this.btn_Guncelle.UseVisualStyleBackColor = false;
            // 
            // btn_Sil
            // 
            this.btn_Sil.BackColor = System.Drawing.Color.IndianRed;
            this.btn_Sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Sil.Location = new System.Drawing.Point(19, 292);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(92, 37);
            this.btn_Sil.TabIndex = 10;
            this.btn_Sil.Text = "SİL";
            this.btn_Sil.UseVisualStyleBackColor = false;
            // 
            // btn_Detay
            // 
            this.btn_Detay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Detay.Location = new System.Drawing.Point(177, 256);
            this.btn_Detay.Name = "btn_Detay";
            this.btn_Detay.Size = new System.Drawing.Size(75, 23);
            this.btn_Detay.TabIndex = 11;
            this.btn_Detay.Text = "DETAY";
            this.btn_Detay.UseVisualStyleBackColor = true;
            this.btn_Detay.Click += new System.EventHandler(this.btn_Detay_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Adres";
            // 
            // txt_OgrenciAdres
            // 
            this.txt_OgrenciAdres.Location = new System.Drawing.Point(208, 89);
            this.txt_OgrenciAdres.Name = "txt_OgrenciAdres";
            this.txt_OgrenciAdres.Size = new System.Drawing.Size(100, 20);
            this.txt_OgrenciAdres.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Açıklama";
            // 
            // txt_OgrenciAciklama
            // 
            this.txt_OgrenciAciklama.Location = new System.Drawing.Point(208, 142);
            this.txt_OgrenciAciklama.Name = "txt_OgrenciAciklama";
            this.txt_OgrenciAciklama.Size = new System.Drawing.Size(100, 20);
            this.txt_OgrenciAciklama.TabIndex = 15;
            // 
            // frmOgrenciCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_OgrenciAciklama);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_OgrenciAdres);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_Detay);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.btn_Guncelle);
            this.Controls.Add(this.btn_Kaydet);
            this.Controls.Add(this.lst_Ogrenciler);
            this.Controls.Add(this.txt_Telefon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmb_Sehir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_OgrenciAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmOgrenciCRUD";
            this.Text = "frmOgrenciCRUD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_OgrenciAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_Sehir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Telefon;
        private System.Windows.Forms.ListView lst_Ogrenciler;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btn_Kaydet;
        private System.Windows.Forms.Button btn_Guncelle;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.Button btn_Detay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_OgrenciAdres;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_OgrenciAciklama;
    }
}