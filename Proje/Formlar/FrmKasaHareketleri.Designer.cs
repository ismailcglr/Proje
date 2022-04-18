namespace Proje.Formlar
{
    partial class FrmKasaHareketleri
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
            this.btnKasaOdemeAl = new System.Windows.Forms.Button();
            this.btnKasaOdemeYap = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblGider = new System.Windows.Forms.Label();
            this.lblGider1 = new System.Windows.Forms.Label();
            this.lblGelir = new System.Windows.Forms.Label();
            this.lblGelir1 = new System.Windows.Forms.Label();
            this.lblKasadakiPara = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.grdKasa = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdKasa)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnKasaOdemeAl);
            this.panel1.Controls.Add(this.btnKasaOdemeYap);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(956, 65);
            this.panel1.TabIndex = 0;
            // 
            // btnKasaOdemeAl
            // 
            this.btnKasaOdemeAl.Location = new System.Drawing.Point(140, 12);
            this.btnKasaOdemeAl.Name = "btnKasaOdemeAl";
            this.btnKasaOdemeAl.Size = new System.Drawing.Size(122, 33);
            this.btnKasaOdemeAl.TabIndex = 1;
            this.btnKasaOdemeAl.Text = "ÖDEME AL";
            this.btnKasaOdemeAl.UseVisualStyleBackColor = true;
            this.btnKasaOdemeAl.Click += new System.EventHandler(this.btnKasaOdemeAl_Click);
            // 
            // btnKasaOdemeYap
            // 
            this.btnKasaOdemeYap.Location = new System.Drawing.Point(12, 12);
            this.btnKasaOdemeYap.Name = "btnKasaOdemeYap";
            this.btnKasaOdemeYap.Size = new System.Drawing.Size(122, 33);
            this.btnKasaOdemeYap.TabIndex = 0;
            this.btnKasaOdemeYap.Text = "ÖDEME YAP";
            this.btnKasaOdemeYap.UseVisualStyleBackColor = true;
            this.btnKasaOdemeYap.Click += new System.EventHandler(this.btnKasaOdemeYap_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblGider);
            this.panel2.Controls.Add(this.lblGider1);
            this.panel2.Controls.Add(this.lblGelir);
            this.panel2.Controls.Add(this.lblGelir1);
            this.panel2.Controls.Add(this.lblKasadakiPara);
            this.panel2.Controls.Add(this.lbl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(956, 44);
            this.panel2.TabIndex = 1;
            // 
            // lblGider
            // 
            this.lblGider.AutoSize = true;
            this.lblGider.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGider.ForeColor = System.Drawing.Color.Red;
            this.lblGider.Location = new System.Drawing.Point(403, 13);
            this.lblGider.Name = "lblGider";
            this.lblGider.Size = new System.Drawing.Size(16, 17);
            this.lblGider.TabIndex = 12;
            this.lblGider.Text = "0";
            // 
            // lblGider1
            // 
            this.lblGider1.AutoSize = true;
            this.lblGider1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGider1.ForeColor = System.Drawing.Color.Red;
            this.lblGider1.Location = new System.Drawing.Point(341, 13);
            this.lblGider1.Name = "lblGider1";
            this.lblGider1.Size = new System.Drawing.Size(56, 17);
            this.lblGider1.TabIndex = 11;
            this.lblGider1.Text = "GİDER";
            this.lblGider1.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblGelir
            // 
            this.lblGelir.AutoSize = true;
            this.lblGelir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGelir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblGelir.Location = new System.Drawing.Point(262, 13);
            this.lblGelir.Name = "lblGelir";
            this.lblGelir.Size = new System.Drawing.Size(16, 17);
            this.lblGelir.TabIndex = 10;
            this.lblGelir.Text = "0";
            // 
            // lblGelir1
            // 
            this.lblGelir1.AutoSize = true;
            this.lblGelir1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGelir1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblGelir1.Location = new System.Drawing.Point(202, 13);
            this.lblGelir1.Name = "lblGelir1";
            this.lblGelir1.Size = new System.Drawing.Size(54, 17);
            this.lblGelir1.TabIndex = 9;
            this.lblGelir1.Text = "GELİR";
            // 
            // lblKasadakiPara
            // 
            this.lblKasadakiPara.AutoSize = true;
            this.lblKasadakiPara.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKasadakiPara.ForeColor = System.Drawing.Color.Blue;
            this.lblKasadakiPara.Location = new System.Drawing.Point(147, 13);
            this.lblKasadakiPara.Name = "lblKasadakiPara";
            this.lblKasadakiPara.Size = new System.Drawing.Size(16, 17);
            this.lblKasadakiPara.TabIndex = 8;
            this.lblKasadakiPara.Text = "0";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl1.ForeColor = System.Drawing.Color.Blue;
            this.lbl1.Location = new System.Drawing.Point(12, 13);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(129, 17);
            this.lbl1.TabIndex = 7;
            this.lbl1.Text = "KASADAKİ PARA";
            // 
            // grdKasa
            // 
            this.grdKasa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdKasa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdKasa.Location = new System.Drawing.Point(0, 109);
            this.grdKasa.Name = "grdKasa";
            this.grdKasa.Size = new System.Drawing.Size(956, 325);
            this.grdKasa.TabIndex = 2;
            // 
            // FrmKasaHareketleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 434);
            this.Controls.Add(this.grdKasa);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmKasaHareketleri";
            this.Text = "KASA HAREKETLERİ";
            this.Load += new System.EventHandler(this.FrmKasaHareketleri_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdKasa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView grdKasa;
        private System.Windows.Forms.Label lblGider;
        private System.Windows.Forms.Label lblGider1;
        private System.Windows.Forms.Label lblGelir;
        private System.Windows.Forms.Label lblGelir1;
        private System.Windows.Forms.Label lblKasadakiPara;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btnKasaOdemeAl;
        private System.Windows.Forms.Button btnKasaOdemeYap;
    }
}