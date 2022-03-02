namespace ders33_Tkrr_Ogrenci_Ders.UI.FORMS.Ogrenci
{
    partial class frmOgrenciDERS
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
            this.cmb_Ogrencş = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_Ders = new System.Windows.Forms.ComboBox();
            this.txt_Notu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Kaydet = new System.Windows.Forms.Button();
            this.lst_OgrenciDers = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txt_OgrenciAra = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(196, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ÖĞRENCİNİN ALDIĞI DERSLER FORMU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(61, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Öğrenci";
            // 
            // cmb_Ogrencş
            // 
            this.cmb_Ogrencş.FormattingEnabled = true;
            this.cmb_Ogrencş.Location = new System.Drawing.Point(280, 71);
            this.cmb_Ogrencş.Name = "cmb_Ogrencş";
            this.cmb_Ogrencş.Size = new System.Drawing.Size(121, 21);
            this.cmb_Ogrencş.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(64, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "DERS";
            // 
            // cmb_Ders
            // 
            this.cmb_Ders.FormattingEnabled = true;
            this.cmb_Ders.Location = new System.Drawing.Point(280, 122);
            this.cmb_Ders.Name = "cmb_Ders";
            this.cmb_Ders.Size = new System.Drawing.Size(121, 21);
            this.cmb_Ders.TabIndex = 4;
            // 
            // txt_Notu
            // 
            this.txt_Notu.Location = new System.Drawing.Point(280, 182);
            this.txt_Notu.Name = "txt_Notu";
            this.txt_Notu.Size = new System.Drawing.Size(100, 20);
            this.txt_Notu.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(64, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Notu";
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Kaydet.Location = new System.Drawing.Point(64, 268);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(150, 33);
            this.btn_Kaydet.TabIndex = 7;
            this.btn_Kaydet.Text = "KAYDET";
            this.btn_Kaydet.UseVisualStyleBackColor = true;
            // 
            // lst_OgrenciDers
            // 
            this.lst_OgrenciDers.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lst_OgrenciDers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lst_OgrenciDers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lst_OgrenciDers.GridLines = true;
            this.lst_OgrenciDers.HideSelection = false;
            this.lst_OgrenciDers.Location = new System.Drawing.Point(440, 71);
            this.lst_OgrenciDers.Name = "lst_OgrenciDers";
            this.lst_OgrenciDers.Size = new System.Drawing.Size(348, 230);
            this.lst_OgrenciDers.TabIndex = 8;
            this.lst_OgrenciDers.UseCompatibleStateImageBehavior = false;
            this.lst_OgrenciDers.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Öğrenci Adı";
            this.columnHeader1.Width = 156;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Aldığı Ders";
            this.columnHeader2.Width = 112;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Notu";
            // 
            // txt_OgrenciAra
            // 
            this.txt_OgrenciAra.Location = new System.Drawing.Point(660, 42);
            this.txt_OgrenciAra.Name = "txt_OgrenciAra";
            this.txt_OgrenciAra.Size = new System.Drawing.Size(100, 20);
            this.txt_OgrenciAra.TabIndex = 9;
            this.txt_OgrenciAra.TextChanged += new System.EventHandler(this.txt_OgrenciAra_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label5.Location = new System.Drawing.Point(588, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Öğrenci Ara:";
            // 
            // frmOgrenciDERS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_OgrenciAra);
            this.Controls.Add(this.lst_OgrenciDers);
            this.Controls.Add(this.btn_Kaydet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Notu);
            this.Controls.Add(this.cmb_Ders);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb_Ogrencş);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmOgrenciDERS";
            this.Text = "frmOgrenciDERS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_Ogrencş;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_Ders;
        private System.Windows.Forms.TextBox txt_Notu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Kaydet;
        private System.Windows.Forms.ListView lst_OgrenciDers;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TextBox txt_OgrenciAra;
        private System.Windows.Forms.Label label5;
    }
}