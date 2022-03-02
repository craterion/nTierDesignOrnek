namespace ders33_Tkrr_Ogrenci_Ders.UI.FORMS.Sehir
{
    partial class frmSehirCRUD
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
            this.btn_Sil = new System.Windows.Forms.Button();
            this.btn_Guncelle = new System.Windows.Forms.Button();
            this.btn_Kaydet = new System.Windows.Forms.Button();
            this.lst_sehirler = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txt_SehirAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(211, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "ŞEHİR CRUD İŞLEMLERİ FORMU";
            // 
            // btn_Sil
            // 
            this.btn_Sil.BackColor = System.Drawing.Color.IndianRed;
            this.btn_Sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Sil.Location = new System.Drawing.Point(113, 195);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(92, 37);
            this.btn_Sil.TabIndex = 20;
            this.btn_Sil.Text = "SİL";
            this.btn_Sil.UseVisualStyleBackColor = false;
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.BackColor = System.Drawing.SystemColors.Info;
            this.btn_Guncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Guncelle.Location = new System.Drawing.Point(113, 151);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(92, 38);
            this.btn_Guncelle.TabIndex = 19;
            this.btn_Guncelle.Text = "GÜNCELLE";
            this.btn_Guncelle.UseVisualStyleBackColor = false;
            this.btn_Guncelle.Click += new System.EventHandler(this.btn_Guncelle_Click);
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_Kaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Kaydet.Location = new System.Drawing.Point(113, 107);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(92, 38);
            this.btn_Kaydet.TabIndex = 18;
            this.btn_Kaydet.Text = "KAYDET";
            this.btn_Kaydet.UseVisualStyleBackColor = false;
            this.btn_Kaydet.Click += new System.EventHandler(this.btn_Kaydet_Click);
            // 
            // lst_sehirler
            // 
            this.lst_sehirler.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lst_sehirler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lst_sehirler.GridLines = true;
            this.lst_sehirler.HideSelection = false;
            this.lst_sehirler.Location = new System.Drawing.Point(344, 43);
            this.lst_sehirler.Name = "lst_sehirler";
            this.lst_sehirler.Size = new System.Drawing.Size(429, 239);
            this.lst_sehirler.TabIndex = 17;
            this.lst_sehirler.UseCompatibleStateImageBehavior = false;
            this.lst_sehirler.View = System.Windows.Forms.View.Details;
            this.lst_sehirler.SelectedIndexChanged += new System.EventHandler(this.lst_sehirler_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "SehirID";
            this.columnHeader1.Width = 76;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Şehir Adı";
            this.columnHeader2.Width = 343;
            // 
            // txt_SehirAdi
            // 
            this.txt_SehirAdi.Location = new System.Drawing.Point(210, 43);
            this.txt_SehirAdi.Name = "txt_SehirAdi";
            this.txt_SehirAdi.Size = new System.Drawing.Size(128, 20);
            this.txt_SehirAdi.TabIndex = 12;
            this.txt_SehirAdi.TextChanged += new System.EventHandler(this.txt_SehirAdi_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "ŞEHİR ADI";
            // 
            // frmSehirCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.btn_Guncelle);
            this.Controls.Add(this.btn_Kaydet);
            this.Controls.Add(this.lst_sehirler);
            this.Controls.Add(this.txt_SehirAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmSehirCRUD";
            this.Text = "frmSehirCRUD";
            this.Load += new System.EventHandler(this.frmSehirCRUD_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.Button btn_Guncelle;
        private System.Windows.Forms.Button btn_Kaydet;
        private System.Windows.Forms.ListView lst_sehirler;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TextBox txt_SehirAdi;
        private System.Windows.Forms.Label label2;
    }
}