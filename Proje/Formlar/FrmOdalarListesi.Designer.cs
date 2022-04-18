namespace Proje.Formlar
{
    partial class FrmOdalarListesi
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
            this.btnOdaDuzenle = new System.Windows.Forms.Button();
            this.btnDemirbas = new System.Windows.Forms.Button();
            this.btnYeniOda = new System.Windows.Forms.Button();
            this.grdOdalar = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdOdalar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnOdaDuzenle);
            this.panel1.Controls.Add(this.btnDemirbas);
            this.panel1.Controls.Add(this.btnYeniOda);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(789, 65);
            this.panel1.TabIndex = 0;
            // 
            // btnOdaDuzenle
            // 
            this.btnOdaDuzenle.Location = new System.Drawing.Point(307, 22);
            this.btnOdaDuzenle.Name = "btnOdaDuzenle";
            this.btnOdaDuzenle.Size = new System.Drawing.Size(113, 23);
            this.btnOdaDuzenle.TabIndex = 2;
            this.btnOdaDuzenle.Text = "ODA DÜZENLE";
            this.btnOdaDuzenle.UseVisualStyleBackColor = true;
            this.btnOdaDuzenle.Click += new System.EventHandler(this.btnOdaDuzenle_Click);
            // 
            // btnDemirbas
            // 
            this.btnDemirbas.Location = new System.Drawing.Point(163, 22);
            this.btnDemirbas.Name = "btnDemirbas";
            this.btnDemirbas.Size = new System.Drawing.Size(118, 23);
            this.btnDemirbas.TabIndex = 1;
            this.btnDemirbas.Text = "DEMİRBAŞLAR";
            this.btnDemirbas.UseVisualStyleBackColor = true;
            this.btnDemirbas.Click += new System.EventHandler(this.btnDemirbas_Click_1);
            // 
            // btnYeniOda
            // 
            this.btnYeniOda.Location = new System.Drawing.Point(12, 22);
            this.btnYeniOda.Name = "btnYeniOda";
            this.btnYeniOda.Size = new System.Drawing.Size(118, 23);
            this.btnYeniOda.TabIndex = 0;
            this.btnYeniOda.Text = "YENİ ODA EKLE";
            this.btnYeniOda.UseVisualStyleBackColor = true;
            this.btnYeniOda.Click += new System.EventHandler(this.btnYeniOda_Click);
            // 
            // grdOdalar
            // 
            this.grdOdalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdOdalar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdOdalar.Location = new System.Drawing.Point(0, 65);
            this.grdOdalar.Name = "grdOdalar";
            this.grdOdalar.Size = new System.Drawing.Size(789, 275);
            this.grdOdalar.TabIndex = 1;
            // 
            // FrmOdalarListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 340);
            this.Controls.Add(this.grdOdalar);
            this.Controls.Add(this.panel1);
            this.Name = "FrmOdalarListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ODALAR LİSTESİ";
            this.Load += new System.EventHandler(this.FrmOdalarListesi_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdOdalar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView grdOdalar;
        private System.Windows.Forms.Button btnYeniOda;
        private System.Windows.Forms.Button btnDemirbas;
        private System.Windows.Forms.Button btnOdaDuzenle;
    }
}