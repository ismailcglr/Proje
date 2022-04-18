namespace Proje.Formlar
{
    partial class FrmMusterilerListesi
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMusteriDel = new System.Windows.Forms.Button();
            this.btnMusteriTaksitleri = new System.Windows.Forms.Button();
            this.btnMusteriDuzenle = new System.Windows.Forms.Button();
            this.btnMusteriEkle = new System.Windows.Forms.Button();
            this.grdMusteriler = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMusteriler)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnMusteriDel);
            this.panel1.Controls.Add(this.btnMusteriTaksitleri);
            this.panel1.Controls.Add(this.btnMusteriDuzenle);
            this.panel1.Controls.Add(this.btnMusteriEkle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(937, 74);
            this.panel1.TabIndex = 0;
            // 
            // btnMusteriDel
            // 
            this.btnMusteriDel.Location = new System.Drawing.Point(583, 22);
            this.btnMusteriDel.Name = "btnMusteriDel";
            this.btnMusteriDel.Size = new System.Drawing.Size(169, 28);
            this.btnMusteriDel.TabIndex = 3;
            this.btnMusteriDel.Text = "MÜŞTERİ SİL";
            this.btnMusteriDel.UseVisualStyleBackColor = true;
            this.btnMusteriDel.Click += new System.EventHandler(this.btnMusteriDel_Click);
            // 
            // btnMusteriTaksitleri
            // 
            this.btnMusteriTaksitleri.Location = new System.Drawing.Point(313, 22);
            this.btnMusteriTaksitleri.Name = "btnMusteriTaksitleri";
            this.btnMusteriTaksitleri.Size = new System.Drawing.Size(151, 28);
            this.btnMusteriTaksitleri.TabIndex = 2;
            this.btnMusteriTaksitleri.Text = "MÜŞTERİ TAKSİTLERİ";
            this.btnMusteriTaksitleri.UseVisualStyleBackColor = true;
            this.btnMusteriTaksitleri.Click += new System.EventHandler(this.btnMusteriTaksitleri_Click);
            // 
            // btnMusteriDuzenle
            // 
            this.btnMusteriDuzenle.Location = new System.Drawing.Point(165, 22);
            this.btnMusteriDuzenle.Name = "btnMusteriDuzenle";
            this.btnMusteriDuzenle.Size = new System.Drawing.Size(142, 28);
            this.btnMusteriDuzenle.TabIndex = 1;
            this.btnMusteriDuzenle.Text = "MÜŞTERİ DÜZENLE";
            this.btnMusteriDuzenle.UseVisualStyleBackColor = true;
            this.btnMusteriDuzenle.Click += new System.EventHandler(this.btnMusteriDuzenle_Click);
            // 
            // btnMusteriEkle
            // 
            this.btnMusteriEkle.Location = new System.Drawing.Point(17, 22);
            this.btnMusteriEkle.Name = "btnMusteriEkle";
            this.btnMusteriEkle.Size = new System.Drawing.Size(142, 28);
            this.btnMusteriEkle.TabIndex = 0;
            this.btnMusteriEkle.Text = "MÜŞTERİ EKLE";
            this.btnMusteriEkle.UseVisualStyleBackColor = true;
            this.btnMusteriEkle.Click += new System.EventHandler(this.btnMusteriEkle_Click);
            // 
            // grdMusteriler
            // 
            this.grdMusteriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMusteriler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdMusteriler.Location = new System.Drawing.Point(0, 74);
            this.grdMusteriler.Name = "grdMusteriler";
            this.grdMusteriler.Size = new System.Drawing.Size(937, 339);
            this.grdMusteriler.TabIndex = 1;
            // 
            // FrmMusterilerListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 413);
            this.Controls.Add(this.grdMusteriler);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMusterilerListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MÜŞTERİLER";
            this.Load += new System.EventHandler(this.FrmMusterilerListesi_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdMusteriler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMusteriDuzenle;
        private System.Windows.Forms.Button btnMusteriEkle;
        private System.Windows.Forms.DataGridView grdMusteriler;
        private System.Windows.Forms.Button btnMusteriTaksitleri;
        private System.Windows.Forms.Button btnMusteriDel;
    }
}