namespace Proje.Formlar
{
    partial class FrmMusteriEkle
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbMusteriAdi = new System.Windows.Forms.TextBox();
            this.tbMusteriSoyadi = new System.Windows.Forms.TextBox();
            this.dtpMusteriDogumTarih = new System.Windows.Forms.DateTimePicker();
            this.tbMusteriTc = new System.Windows.Forms.TextBox();
            this.tbMusteriTel = new System.Windows.Forms.TextBox();
            this.tbMusteriAdres = new System.Windows.Forms.TextBox();
            this.btnMusteriSave = new System.Windows.Forms.Button();
            this.btnMusteriCancel = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADI";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "SOYADI";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "DOĞUM TARİHİ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "TC KİMLİK NO";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "CEP TELEFONU ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "ADRESİ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // tbMusteriAdi
            // 
            this.tbMusteriAdi.Location = new System.Drawing.Point(196, 25);
            this.tbMusteriAdi.Name = "tbMusteriAdi";
            this.tbMusteriAdi.Size = new System.Drawing.Size(173, 20);
            this.tbMusteriAdi.TabIndex = 6;
            this.tbMusteriAdi.TextChanged += new System.EventHandler(this.tbMusteriAdi_TextChanged);
            // 
            // tbMusteriSoyadi
            // 
            this.tbMusteriSoyadi.Location = new System.Drawing.Point(196, 53);
            this.tbMusteriSoyadi.Name = "tbMusteriSoyadi";
            this.tbMusteriSoyadi.Size = new System.Drawing.Size(173, 20);
            this.tbMusteriSoyadi.TabIndex = 7;
            this.tbMusteriSoyadi.TextChanged += new System.EventHandler(this.tbMusteriSoyadi_TextChanged);
            // 
            // dtpMusteriDogumTarih
            // 
            this.dtpMusteriDogumTarih.Location = new System.Drawing.Point(196, 85);
            this.dtpMusteriDogumTarih.Name = "dtpMusteriDogumTarih";
            this.dtpMusteriDogumTarih.Size = new System.Drawing.Size(173, 20);
            this.dtpMusteriDogumTarih.TabIndex = 8;
            this.dtpMusteriDogumTarih.ValueChanged += new System.EventHandler(this.dtpMusteriDogumTarih_ValueChanged);
            // 
            // tbMusteriTc
            // 
            this.tbMusteriTc.Location = new System.Drawing.Point(196, 116);
            this.tbMusteriTc.Name = "tbMusteriTc";
            this.tbMusteriTc.Size = new System.Drawing.Size(100, 20);
            this.tbMusteriTc.TabIndex = 9;
            this.tbMusteriTc.TextChanged += new System.EventHandler(this.tbMusteriTc_TextChanged);
            // 
            // tbMusteriTel
            // 
            this.tbMusteriTel.Location = new System.Drawing.Point(196, 142);
            this.tbMusteriTel.Name = "tbMusteriTel";
            this.tbMusteriTel.Size = new System.Drawing.Size(100, 20);
            this.tbMusteriTel.TabIndex = 10;
            this.tbMusteriTel.TextChanged += new System.EventHandler(this.tbMusteriTel_TextChanged);
            // 
            // tbMusteriAdres
            // 
            this.tbMusteriAdres.Location = new System.Drawing.Point(196, 177);
            this.tbMusteriAdres.Name = "tbMusteriAdres";
            this.tbMusteriAdres.Size = new System.Drawing.Size(173, 20);
            this.tbMusteriAdres.TabIndex = 11;
            this.tbMusteriAdres.TextChanged += new System.EventHandler(this.tbMusteriAdres_TextChanged);
            // 
            // btnMusteriSave
            // 
            this.btnMusteriSave.Location = new System.Drawing.Point(70, 228);
            this.btnMusteriSave.Name = "btnMusteriSave";
            this.btnMusteriSave.Size = new System.Drawing.Size(86, 43);
            this.btnMusteriSave.TabIndex = 12;
            this.btnMusteriSave.Text = "KAYDET";
            this.btnMusteriSave.UseVisualStyleBackColor = true;
            this.btnMusteriSave.Click += new System.EventHandler(this.btnMusteriSave_Click);
            // 
            // btnMusteriCancel
            // 
            this.btnMusteriCancel.Location = new System.Drawing.Point(196, 228);
            this.btnMusteriCancel.Name = "btnMusteriCancel";
            this.btnMusteriCancel.Size = new System.Drawing.Size(90, 43);
            this.btnMusteriCancel.TabIndex = 13;
            this.btnMusteriCancel.Text = "İPTAL";
            this.btnMusteriCancel.UseVisualStyleBackColor = true;
            this.btnMusteriCancel.Click += new System.EventHandler(this.btnMusteriCancel_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmMusteriEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 284);
            this.Controls.Add(this.btnMusteriCancel);
            this.Controls.Add(this.btnMusteriSave);
            this.Controls.Add(this.tbMusteriAdres);
            this.Controls.Add(this.tbMusteriTel);
            this.Controls.Add(this.tbMusteriTc);
            this.Controls.Add(this.dtpMusteriDogumTarih);
            this.Controls.Add(this.tbMusteriSoyadi);
            this.Controls.Add(this.tbMusteriAdi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMusteriEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MÜŞTERİ EKLE";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
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
        private System.Windows.Forms.TextBox tbMusteriAdi;
        private System.Windows.Forms.TextBox tbMusteriSoyadi;
        private System.Windows.Forms.DateTimePicker dtpMusteriDogumTarih;
        private System.Windows.Forms.TextBox tbMusteriTc;
        private System.Windows.Forms.TextBox tbMusteriTel;
        private System.Windows.Forms.TextBox tbMusteriAdres;
        private System.Windows.Forms.Button btnMusteriSave;
        private System.Windows.Forms.Button btnMusteriCancel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}