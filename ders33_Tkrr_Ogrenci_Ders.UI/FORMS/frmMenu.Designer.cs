namespace ders33_Tkrr_Ogrenci_Ders.UI.FORMS
{
    partial class frmMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dERSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dERSToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.şEHİRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciKaydetFormuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.şehirCRUDFormuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dersCRUDFormuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrencininDersleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dERSToolStripMenuItem,
            this.şEHİRToolStripMenuItem,
            this.dERSToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dERSToolStripMenuItem
            // 
            this.dERSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öğrenciKaydetFormuToolStripMenuItem,
            this.öğrencininDersleriToolStripMenuItem});
            this.dERSToolStripMenuItem.Name = "dERSToolStripMenuItem";
            this.dERSToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.dERSToolStripMenuItem.Text = "ÖĞRENCİ";
            // 
            // dERSToolStripMenuItem1
            // 
            this.dERSToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dersCRUDFormuToolStripMenuItem});
            this.dERSToolStripMenuItem1.Name = "dERSToolStripMenuItem1";
            this.dERSToolStripMenuItem1.Size = new System.Drawing.Size(58, 24);
            this.dERSToolStripMenuItem1.Text = "DERS";
            // 
            // şEHİRToolStripMenuItem
            // 
            this.şEHİRToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.şehirCRUDFormuToolStripMenuItem});
            this.şEHİRToolStripMenuItem.Name = "şEHİRToolStripMenuItem";
            this.şEHİRToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.şEHİRToolStripMenuItem.Text = "ŞEHİR";
            // 
            // öğrenciKaydetFormuToolStripMenuItem
            // 
            this.öğrenciKaydetFormuToolStripMenuItem.Name = "öğrenciKaydetFormuToolStripMenuItem";
            this.öğrenciKaydetFormuToolStripMenuItem.Size = new System.Drawing.Size(227, 24);
            this.öğrenciKaydetFormuToolStripMenuItem.Text = "Öğrenci CRUD Formu";
            this.öğrenciKaydetFormuToolStripMenuItem.Click += new System.EventHandler(this.öğrenciKaydetFormuToolStripMenuItem_Click);
            // 
            // şehirCRUDFormuToolStripMenuItem
            // 
            this.şehirCRUDFormuToolStripMenuItem.Name = "şehirCRUDFormuToolStripMenuItem";
            this.şehirCRUDFormuToolStripMenuItem.Size = new System.Drawing.Size(208, 24);
            this.şehirCRUDFormuToolStripMenuItem.Text = "Şehir CRUD Formu";
            this.şehirCRUDFormuToolStripMenuItem.Click += new System.EventHandler(this.şehirCRUDFormuToolStripMenuItem_Click);
            // 
            // dersCRUDFormuToolStripMenuItem
            // 
            this.dersCRUDFormuToolStripMenuItem.Name = "dersCRUDFormuToolStripMenuItem";
            this.dersCRUDFormuToolStripMenuItem.Size = new System.Drawing.Size(205, 24);
            this.dersCRUDFormuToolStripMenuItem.Text = "Ders CRUD Formu";
            this.dersCRUDFormuToolStripMenuItem.Click += new System.EventHandler(this.dersCRUDFormuToolStripMenuItem_Click);
            // 
            // öğrencininDersleriToolStripMenuItem
            // 
            this.öğrencininDersleriToolStripMenuItem.Name = "öğrencininDersleriToolStripMenuItem";
            this.öğrencininDersleriToolStripMenuItem.Size = new System.Drawing.Size(262, 24);
            this.öğrencininDersleriToolStripMenuItem.Text = "Öğrencilerin Aldığı Dersler";
            this.öğrencininDersleriToolStripMenuItem.Click += new System.EventHandler(this.öğrencininDersleriToolStripMenuItem_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.Text = "frmMenu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dERSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrenciKaydetFormuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrencininDersleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem şEHİRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem şehirCRUDFormuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dERSToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dersCRUDFormuToolStripMenuItem;
    }
}