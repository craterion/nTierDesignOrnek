namespace ders33_Tkrr_Ogrenci_Ders.UI.FORMS.Ders
{
    partial class frmDersCRUD
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
            this.lst_DersAdi = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txt_DersAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(231, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "DERS CRUD İŞLEMLERİ FORMU";
            // 
            // btn_Sil
            // 
            this.btn_Sil.BackColor = System.Drawing.Color.IndianRed;
            this.btn_Sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Sil.Location = new System.Drawing.Point(23, 206);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(284, 37);
            this.btn_Sil.TabIndex = 26;
            this.btn_Sil.Text = "SİL";
            this.btn_Sil.UseVisualStyleBackColor = false;
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.BackColor = System.Drawing.SystemColors.Info;
            this.btn_Guncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Guncelle.Location = new System.Drawing.Point(23, 162);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(284, 38);
            this.btn_Guncelle.TabIndex = 25;
            this.btn_Guncelle.Text = "GÜNCELLE";
            this.btn_Guncelle.UseVisualStyleBackColor = false;
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_Kaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Kaydet.Location = new System.Drawing.Point(23, 118);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(284, 38);
            this.btn_Kaydet.TabIndex = 24;
            this.btn_Kaydet.Text = "KAYDET";
            this.btn_Kaydet.UseVisualStyleBackColor = false;
            // 
            // lst_DersAdi
            // 
            this.lst_DersAdi.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lst_DersAdi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lst_DersAdi.GridLines = true;
            this.lst_DersAdi.HideSelection = false;
            this.lst_DersAdi.Location = new System.Drawing.Point(349, 54);
            this.lst_DersAdi.Name = "lst_DersAdi";
            this.lst_DersAdi.Size = new System.Drawing.Size(429, 239);
            this.lst_DersAdi.TabIndex = 23;
            this.lst_DersAdi.UseCompatibleStateImageBehavior = false;
            this.lst_DersAdi.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "DersID";
            this.columnHeader1.Width = 76;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ders Adı";
            this.columnHeader2.Width = 343;
            // 
            // txt_DersAdi
            // 
            this.txt_DersAdi.Location = new System.Drawing.Point(215, 54);
            this.txt_DersAdi.Name = "txt_DersAdi";
            this.txt_DersAdi.Size = new System.Drawing.Size(128, 20);
            this.txt_DersAdi.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "DERS ADI";
            // 
            // frmDersCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.btn_Guncelle);
            this.Controls.Add(this.btn_Kaydet);
            this.Controls.Add(this.lst_DersAdi);
            this.Controls.Add(this.txt_DersAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmDersCRUD";
            this.Text = "frmDersCRUD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.Button btn_Guncelle;
        private System.Windows.Forms.Button btn_Kaydet;
        private System.Windows.Forms.ListView lst_DersAdi;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TextBox txt_DersAdi;
        private System.Windows.Forms.Label label2;
    }
}