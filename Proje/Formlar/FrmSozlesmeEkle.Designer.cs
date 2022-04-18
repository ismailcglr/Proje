namespace Proje.Formlar
{
    partial class FrmSozlesmeEkle
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbSozlesmeMusteri = new System.Windows.Forms.ComboBox();
            this.cbSozlesmeOda = new System.Windows.Forms.ComboBox();
            this.tbSozlesmeToplamTutar = new System.Windows.Forms.TextBox();
            this.numSozlesmeTaksit = new System.Windows.Forms.NumericUpDown();
            this.dtpSozlesmeBaslangic = new System.Windows.Forms.DateTimePicker();
            this.dtpSozlesmeBitis = new System.Windows.Forms.DateTimePicker();
            this.btnSozlesmeSave = new System.Windows.Forms.Button();
            this.btnSozlesmeCancel = new System.Windows.Forms.Button();
            this.dtpIlkSozlesmeTarih = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numSozlesmeTaksit)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "MÜŞTERİ ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ODA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "TOPLAM TUTAR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "TAKSİT SAYISI";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "BAŞLANGIÇ TARİHİ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "BİTİŞ TARİHİ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // cbSozlesmeMusteri
            // 
            this.cbSozlesmeMusteri.DisplayMember = "Ad";
            this.cbSozlesmeMusteri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSozlesmeMusteri.FormattingEnabled = true;
            this.cbSozlesmeMusteri.Location = new System.Drawing.Point(150, 15);
            this.cbSozlesmeMusteri.Name = "cbSozlesmeMusteri";
            this.cbSozlesmeMusteri.Size = new System.Drawing.Size(121, 21);
            this.cbSozlesmeMusteri.TabIndex = 6;
            this.cbSozlesmeMusteri.ValueMember = "Id";
            // 
            // cbSozlesmeOda
            // 
            this.cbSozlesmeOda.DisplayMember = "OdaAdi";
            this.cbSozlesmeOda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSozlesmeOda.FormattingEnabled = true;
            this.cbSozlesmeOda.Location = new System.Drawing.Point(150, 42);
            this.cbSozlesmeOda.Name = "cbSozlesmeOda";
            this.cbSozlesmeOda.Size = new System.Drawing.Size(121, 21);
            this.cbSozlesmeOda.TabIndex = 7;
            this.cbSozlesmeOda.ValueMember = "Id";
            // 
            // tbSozlesmeToplamTutar
            // 
            this.tbSozlesmeToplamTutar.Location = new System.Drawing.Point(150, 69);
            this.tbSozlesmeToplamTutar.Name = "tbSozlesmeToplamTutar";
            this.tbSozlesmeToplamTutar.Size = new System.Drawing.Size(121, 20);
            this.tbSozlesmeToplamTutar.TabIndex = 8;
            // 
            // numSozlesmeTaksit
            // 
            this.numSozlesmeTaksit.Location = new System.Drawing.Point(150, 95);
            this.numSozlesmeTaksit.Name = "numSozlesmeTaksit";
            this.numSozlesmeTaksit.Size = new System.Drawing.Size(121, 20);
            this.numSozlesmeTaksit.TabIndex = 9;
            // 
            // dtpSozlesmeBaslangic
            // 
            this.dtpSozlesmeBaslangic.Location = new System.Drawing.Point(150, 152);
            this.dtpSozlesmeBaslangic.Name = "dtpSozlesmeBaslangic";
            this.dtpSozlesmeBaslangic.Size = new System.Drawing.Size(200, 20);
            this.dtpSozlesmeBaslangic.TabIndex = 10;
            // 
            // dtpSozlesmeBitis
            // 
            this.dtpSozlesmeBitis.Location = new System.Drawing.Point(150, 178);
            this.dtpSozlesmeBitis.Name = "dtpSozlesmeBitis";
            this.dtpSozlesmeBitis.Size = new System.Drawing.Size(200, 20);
            this.dtpSozlesmeBitis.TabIndex = 11;
            // 
            // btnSozlesmeSave
            // 
            this.btnSozlesmeSave.Location = new System.Drawing.Point(81, 223);
            this.btnSozlesmeSave.Name = "btnSozlesmeSave";
            this.btnSozlesmeSave.Size = new System.Drawing.Size(103, 42);
            this.btnSozlesmeSave.TabIndex = 12;
            this.btnSozlesmeSave.Text = "KAYDET";
            this.btnSozlesmeSave.UseVisualStyleBackColor = true;
            this.btnSozlesmeSave.Click += new System.EventHandler(this.btnSozlesmeSave_Click);
            // 
            // btnSozlesmeCancel
            // 
            this.btnSozlesmeCancel.Location = new System.Drawing.Point(212, 223);
            this.btnSozlesmeCancel.Name = "btnSozlesmeCancel";
            this.btnSozlesmeCancel.Size = new System.Drawing.Size(103, 42);
            this.btnSozlesmeCancel.TabIndex = 13;
            this.btnSozlesmeCancel.Text = "İPTAL";
            this.btnSozlesmeCancel.UseVisualStyleBackColor = true;
            this.btnSozlesmeCancel.Click += new System.EventHandler(this.btnSozlesmeCancel_Click);
            // 
            // dtpIlkSozlesmeTarih
            // 
            this.dtpIlkSozlesmeTarih.Location = new System.Drawing.Point(150, 126);
            this.dtpIlkSozlesmeTarih.Name = "dtpIlkSozlesmeTarih";
            this.dtpIlkSozlesmeTarih.Size = new System.Drawing.Size(200, 20);
            this.dtpIlkSozlesmeTarih.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "İLK TAKSİT TARİHİ";
            // 
            // FrmSozlesmeEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 308);
            this.Controls.Add(this.dtpIlkSozlesmeTarih);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSozlesmeCancel);
            this.Controls.Add(this.btnSozlesmeSave);
            this.Controls.Add(this.dtpSozlesmeBitis);
            this.Controls.Add(this.dtpSozlesmeBaslangic);
            this.Controls.Add(this.numSozlesmeTaksit);
            this.Controls.Add(this.tbSozlesmeToplamTutar);
            this.Controls.Add(this.cbSozlesmeOda);
            this.Controls.Add(this.cbSozlesmeMusteri);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSozlesmeEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YENİ SÖZLEŞME OLUŞTUR";
            this.Load += new System.EventHandler(this.FrmSozlesmeEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numSozlesmeTaksit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbSozlesmeMusteri;
        private System.Windows.Forms.ComboBox cbSozlesmeOda;
        private System.Windows.Forms.TextBox tbSozlesmeToplamTutar;
        private System.Windows.Forms.NumericUpDown numSozlesmeTaksit;
        private System.Windows.Forms.DateTimePicker dtpSozlesmeBaslangic;
        private System.Windows.Forms.DateTimePicker dtpSozlesmeBitis;
        private System.Windows.Forms.Button btnSozlesmeSave;
        private System.Windows.Forms.Button btnSozlesmeCancel;
        private System.Windows.Forms.DateTimePicker dtpIlkSozlesmeTarih;
        private System.Windows.Forms.Label label7;
    }
}