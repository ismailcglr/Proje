namespace Proje.Formlar
{
    partial class FrmMusteriTaksitleri
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
            this.lblMusteriAdi = new System.Windows.Forms.Label();
            this.grdTaksitler = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblKalanBorc = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblOdenenBorc = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblToplamBorc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOdemeAl = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTaksitler)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblMusteriAdi);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(924, 60);
            this.panel1.TabIndex = 0;
            // 
            // lblMusteriAdi
            // 
            this.lblMusteriAdi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMusteriAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMusteriAdi.Location = new System.Drawing.Point(0, 0);
            this.lblMusteriAdi.Name = "lblMusteriAdi";
            this.lblMusteriAdi.Size = new System.Drawing.Size(924, 60);
            this.lblMusteriAdi.TabIndex = 0;
            this.lblMusteriAdi.Text = "-";
            this.lblMusteriAdi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grdTaksitler
            // 
            this.grdTaksitler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTaksitler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdTaksitler.Location = new System.Drawing.Point(0, 96);
            this.grdTaksitler.Name = "grdTaksitler";
            this.grdTaksitler.Size = new System.Drawing.Size(924, 344);
            this.grdTaksitler.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblKalanBorc);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.lblOdenenBorc);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lblToplamBorc);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnOdemeAl);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(924, 36);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lblKalanBorc
            // 
            this.lblKalanBorc.AutoSize = true;
            this.lblKalanBorc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKalanBorc.ForeColor = System.Drawing.Color.Red;
            this.lblKalanBorc.Location = new System.Drawing.Point(627, 10);
            this.lblKalanBorc.Name = "lblKalanBorc";
            this.lblKalanBorc.Size = new System.Drawing.Size(16, 17);
            this.lblKalanBorc.TabIndex = 6;
            this.lblKalanBorc.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(515, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "KALAN BORÇ";
            // 
            // lblOdenenBorc
            // 
            this.lblOdenenBorc.AutoSize = true;
            this.lblOdenenBorc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOdenenBorc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblOdenenBorc.Location = new System.Drawing.Point(432, 9);
            this.lblOdenenBorc.Name = "lblOdenenBorc";
            this.lblOdenenBorc.Size = new System.Drawing.Size(16, 17);
            this.lblOdenenBorc.TabIndex = 4;
            this.lblOdenenBorc.Text = "0";
            this.lblOdenenBorc.Click += new System.EventHandler(this.lblOdenenBorc_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(305, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "ODENEN BORÇ";
            // 
            // lblToplamBorc
            // 
            this.lblToplamBorc.AutoSize = true;
            this.lblToplamBorc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamBorc.ForeColor = System.Drawing.Color.Blue;
            this.lblToplamBorc.Location = new System.Drawing.Point(240, 10);
            this.lblToplamBorc.Name = "lblToplamBorc";
            this.lblToplamBorc.Size = new System.Drawing.Size(16, 17);
            this.lblToplamBorc.TabIndex = 2;
            this.lblToplamBorc.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(115, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "TOPLAM BORÇ";
            // 
            // btnOdemeAl
            // 
            this.btnOdemeAl.Location = new System.Drawing.Point(6, 6);
            this.btnOdemeAl.Name = "btnOdemeAl";
            this.btnOdemeAl.Size = new System.Drawing.Size(103, 23);
            this.btnOdemeAl.TabIndex = 0;
            this.btnOdemeAl.Text = "ÖDEME AL";
            this.btnOdemeAl.UseVisualStyleBackColor = true;
            this.btnOdemeAl.Click += new System.EventHandler(this.btnOdemeAl_Click);
            // 
            // FrmMusteriTaksitleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 440);
            this.Controls.Add(this.grdTaksitler);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmMusteriTaksitleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MÜŞTERİ TAKSİTLERİ";
            this.Load += new System.EventHandler(this.FrmMusteriTaksitleri_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdTaksitler)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMusteriAdi;
        private System.Windows.Forms.DataGridView grdTaksitler;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnOdemeAl;
        private System.Windows.Forms.Label lblKalanBorc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblOdenenBorc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblToplamBorc;
        private System.Windows.Forms.Label label1;
    }
}