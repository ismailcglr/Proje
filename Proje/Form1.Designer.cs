namespace Proje
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.odallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odaEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odaListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşterilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşlterilerListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sözleşmelerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sözleşmeEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sözleşmelerListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kasaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taksitlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.odallToolStripMenuItem,
            this.müşterilerToolStripMenuItem,
            this.sözleşmelerToolStripMenuItem,
            this.kasaToolStripMenuItem,
            this.taksitlerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(465, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // odallToolStripMenuItem
            // 
            this.odallToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.odaEkleToolStripMenuItem,
            this.odaListesiToolStripMenuItem});
            this.odallToolStripMenuItem.Name = "odallToolStripMenuItem";
            this.odallToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.odallToolStripMenuItem.Text = "Odalar";
            // 
            // odaEkleToolStripMenuItem
            // 
            this.odaEkleToolStripMenuItem.Name = "odaEkleToolStripMenuItem";
            this.odaEkleToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.odaEkleToolStripMenuItem.Text = "Oda Ekle";
            this.odaEkleToolStripMenuItem.Click += new System.EventHandler(this.odaEkleToolStripMenuItem_Click);
            // 
            // odaListesiToolStripMenuItem
            // 
            this.odaListesiToolStripMenuItem.Name = "odaListesiToolStripMenuItem";
            this.odaListesiToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.odaListesiToolStripMenuItem.Text = "Oda Listesi";
            this.odaListesiToolStripMenuItem.Click += new System.EventHandler(this.odaListesiToolStripMenuItem_Click);
            // 
            // müşterilerToolStripMenuItem
            // 
            this.müşterilerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müşteriEkleToolStripMenuItem,
            this.müşlterilerListesiToolStripMenuItem});
            this.müşterilerToolStripMenuItem.Name = "müşterilerToolStripMenuItem";
            this.müşterilerToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.müşterilerToolStripMenuItem.Text = "Müşteriler";
            // 
            // müşteriEkleToolStripMenuItem
            // 
            this.müşteriEkleToolStripMenuItem.Name = "müşteriEkleToolStripMenuItem";
            this.müşteriEkleToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.müşteriEkleToolStripMenuItem.Text = "Müşteri Ekle";
            this.müşteriEkleToolStripMenuItem.Click += new System.EventHandler(this.müşteriEkleToolStripMenuItem_Click);
            // 
            // müşlterilerListesiToolStripMenuItem
            // 
            this.müşlterilerListesiToolStripMenuItem.Name = "müşlterilerListesiToolStripMenuItem";
            this.müşlterilerListesiToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.müşlterilerListesiToolStripMenuItem.Text = "Müşlteriler Listesi";
            this.müşlterilerListesiToolStripMenuItem.Click += new System.EventHandler(this.müşlterilerListesiToolStripMenuItem_Click);
            // 
            // sözleşmelerToolStripMenuItem
            // 
            this.sözleşmelerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sözleşmeEkleToolStripMenuItem,
            this.sözleşmelerListesiToolStripMenuItem});
            this.sözleşmelerToolStripMenuItem.Name = "sözleşmelerToolStripMenuItem";
            this.sözleşmelerToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.sözleşmelerToolStripMenuItem.Text = "Sözleşmeler";
            // 
            // sözleşmeEkleToolStripMenuItem
            // 
            this.sözleşmeEkleToolStripMenuItem.Name = "sözleşmeEkleToolStripMenuItem";
            this.sözleşmeEkleToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.sözleşmeEkleToolStripMenuItem.Text = "Sözleşme Oluştur";
            this.sözleşmeEkleToolStripMenuItem.Click += new System.EventHandler(this.sözleşmeEkleToolStripMenuItem_Click);
            // 
            // sözleşmelerListesiToolStripMenuItem
            // 
            this.sözleşmelerListesiToolStripMenuItem.Name = "sözleşmelerListesiToolStripMenuItem";
            this.sözleşmelerListesiToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.sözleşmelerListesiToolStripMenuItem.Text = "Sözleşmeler Listesi";
            this.sözleşmelerListesiToolStripMenuItem.Click += new System.EventHandler(this.sözleşmelerListesiToolStripMenuItem_Click);
            // 
            // kasaToolStripMenuItem
            // 
            this.kasaToolStripMenuItem.Name = "kasaToolStripMenuItem";
            this.kasaToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.kasaToolStripMenuItem.Text = "Kasa";
            this.kasaToolStripMenuItem.Click += new System.EventHandler(this.kasaToolStripMenuItem_Click);
            // 
            // taksitlerToolStripMenuItem
            // 
            this.taksitlerToolStripMenuItem.Name = "taksitlerToolStripMenuItem";
            this.taksitlerToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.taksitlerToolStripMenuItem.Text = "Taksitler";
            this.taksitlerToolStripMenuItem.Click += new System.EventHandler(this.taksitlerToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 237);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "YÖNETİCİ PANELİ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem odallToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odaEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odaListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşterilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşlterilerListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sözleşmelerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sözleşmeEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sözleşmelerListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kasaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taksitlerToolStripMenuItem;
    }
}

