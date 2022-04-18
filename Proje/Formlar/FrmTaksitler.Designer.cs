namespace Proje.Formlar
{
    partial class FrmTaksitler
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
            this.btnOdemeal = new System.Windows.Forms.Button();
            this.btnOdenmeyenler = new System.Windows.Forms.Button();
            this.btnOdenenler = new System.Windows.Forms.Button();
            this.btnButunTaksitler = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblOdenmeyenToplam = new System.Windows.Forms.Label();
            this.lblGider1 = new System.Windows.Forms.Label();
            this.lblOdenenToplam = new System.Windows.Forms.Label();
            this.lblGelir1 = new System.Windows.Forms.Label();
            this.lblTaksitlerToplamı = new System.Windows.Forms.Label();
            this.lblTaksitlerToplamı1 = new System.Windows.Forms.Label();
            this.grdTaksitler = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTaksitler)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnOdemeal);
            this.panel1.Controls.Add(this.btnOdenmeyenler);
            this.panel1.Controls.Add(this.btnOdenenler);
            this.panel1.Controls.Add(this.btnButunTaksitler);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(736, 53);
            this.panel1.TabIndex = 0;
            // 
            // btnOdemeal
            // 
            this.btnOdemeal.Location = new System.Drawing.Point(519, 12);
            this.btnOdemeal.Name = "btnOdemeal";
            this.btnOdemeal.Size = new System.Drawing.Size(166, 23);
            this.btnOdemeal.TabIndex = 3;
            this.btnOdemeal.Text = "ÖDEME AL";
            this.btnOdemeal.UseVisualStyleBackColor = true;
            this.btnOdemeal.Click += new System.EventHandler(this.btnOdemeal_Click);
            // 
            // btnOdenmeyenler
            // 
            this.btnOdenmeyenler.Location = new System.Drawing.Point(347, 12);
            this.btnOdenmeyenler.Name = "btnOdenmeyenler";
            this.btnOdenmeyenler.Size = new System.Drawing.Size(166, 23);
            this.btnOdenmeyenler.TabIndex = 2;
            this.btnOdenmeyenler.Text = "ÖDENMEYENLER";
            this.btnOdenmeyenler.UseVisualStyleBackColor = true;
            this.btnOdenmeyenler.Click += new System.EventHandler(this.btnOdenmeyenler_Click);
            // 
            // btnOdenenler
            // 
            this.btnOdenenler.Location = new System.Drawing.Point(175, 12);
            this.btnOdenenler.Name = "btnOdenenler";
            this.btnOdenenler.Size = new System.Drawing.Size(166, 23);
            this.btnOdenenler.TabIndex = 1;
            this.btnOdenenler.Text = "ÖDENENLER";
            this.btnOdenenler.UseVisualStyleBackColor = true;
            this.btnOdenenler.Click += new System.EventHandler(this.btnOdenenler_Click);
            // 
            // btnButunTaksitler
            // 
            this.btnButunTaksitler.Location = new System.Drawing.Point(3, 12);
            this.btnButunTaksitler.Name = "btnButunTaksitler";
            this.btnButunTaksitler.Size = new System.Drawing.Size(166, 23);
            this.btnButunTaksitler.TabIndex = 0;
            this.btnButunTaksitler.Text = "BÜTÜN TAKSİTLER";
            this.btnButunTaksitler.UseVisualStyleBackColor = true;
            this.btnButunTaksitler.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblOdenmeyenToplam);
            this.panel2.Controls.Add(this.lblGider1);
            this.panel2.Controls.Add(this.lblOdenenToplam);
            this.panel2.Controls.Add(this.lblGelir1);
            this.panel2.Controls.Add(this.lblTaksitlerToplamı);
            this.panel2.Controls.Add(this.lblTaksitlerToplamı1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(736, 39);
            this.panel2.TabIndex = 1;
            // 
            // lblOdenmeyenToplam
            // 
            this.lblOdenmeyenToplam.AutoSize = true;
            this.lblOdenmeyenToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOdenmeyenToplam.ForeColor = System.Drawing.Color.Red;
            this.lblOdenmeyenToplam.Location = new System.Drawing.Point(616, 12);
            this.lblOdenmeyenToplam.Name = "lblOdenmeyenToplam";
            this.lblOdenmeyenToplam.Size = new System.Drawing.Size(16, 17);
            this.lblOdenmeyenToplam.TabIndex = 18;
            this.lblOdenmeyenToplam.Text = "0";
            // 
            // lblGider1
            // 
            this.lblGider1.AutoSize = true;
            this.lblGider1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGider1.ForeColor = System.Drawing.Color.Red;
            this.lblGider1.Location = new System.Drawing.Point(437, 12);
            this.lblGider1.Name = "lblGider1";
            this.lblGider1.Size = new System.Drawing.Size(173, 17);
            this.lblGider1.TabIndex = 17;
            this.lblGider1.Text = "ÖDENMEYEN TOPLAM";
            // 
            // lblOdenenToplam
            // 
            this.lblOdenenToplam.AutoSize = true;
            this.lblOdenenToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOdenenToplam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblOdenenToplam.Location = new System.Drawing.Point(373, 12);
            this.lblOdenenToplam.Name = "lblOdenenToplam";
            this.lblOdenenToplam.Size = new System.Drawing.Size(16, 17);
            this.lblOdenenToplam.TabIndex = 16;
            this.lblOdenenToplam.Text = "0";
            // 
            // lblGelir1
            // 
            this.lblGelir1.AutoSize = true;
            this.lblGelir1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGelir1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblGelir1.Location = new System.Drawing.Point(226, 12);
            this.lblGelir1.Name = "lblGelir1";
            this.lblGelir1.Size = new System.Drawing.Size(141, 17);
            this.lblGelir1.TabIndex = 15;
            this.lblGelir1.Text = "ÖDENEN TOPLAM";
            this.lblGelir1.Click += new System.EventHandler(this.lblGelir1_Click);
            // 
            // lblTaksitlerToplamı
            // 
            this.lblTaksitlerToplamı.AutoSize = true;
            this.lblTaksitlerToplamı.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTaksitlerToplamı.ForeColor = System.Drawing.Color.Blue;
            this.lblTaksitlerToplamı.Location = new System.Drawing.Point(175, 12);
            this.lblTaksitlerToplamı.Name = "lblTaksitlerToplamı";
            this.lblTaksitlerToplamı.Size = new System.Drawing.Size(16, 17);
            this.lblTaksitlerToplamı.TabIndex = 14;
            this.lblTaksitlerToplamı.Text = "0";
            // 
            // lblTaksitlerToplamı1
            // 
            this.lblTaksitlerToplamı1.AutoSize = true;
            this.lblTaksitlerToplamı1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTaksitlerToplamı1.ForeColor = System.Drawing.Color.Blue;
            this.lblTaksitlerToplamı1.Location = new System.Drawing.Point(5, 12);
            this.lblTaksitlerToplamı1.Name = "lblTaksitlerToplamı1";
            this.lblTaksitlerToplamı1.Size = new System.Drawing.Size(164, 17);
            this.lblTaksitlerToplamı1.TabIndex = 13;
            this.lblTaksitlerToplamı1.Text = "TAKSİTLER TOPLAMI";
            // 
            // grdTaksitler
            // 
            this.grdTaksitler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTaksitler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdTaksitler.Location = new System.Drawing.Point(0, 92);
            this.grdTaksitler.Name = "grdTaksitler";
            this.grdTaksitler.Size = new System.Drawing.Size(736, 210);
            this.grdTaksitler.TabIndex = 2;
            this.grdTaksitler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdTaksitler_CellContentClick);
            // 
            // FrmTaksitler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 302);
            this.Controls.Add(this.grdTaksitler);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmTaksitler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TAKSİTLER";
            this.Load += new System.EventHandler(this.FrmTaksitler_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTaksitler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView grdTaksitler;
        private System.Windows.Forms.Button btnOdemeal;
        private System.Windows.Forms.Button btnOdenmeyenler;
        private System.Windows.Forms.Button btnOdenenler;
        private System.Windows.Forms.Button btnButunTaksitler;
        private System.Windows.Forms.Label lblOdenmeyenToplam;
        private System.Windows.Forms.Label lblGider1;
        private System.Windows.Forms.Label lblOdenenToplam;
        private System.Windows.Forms.Label lblGelir1;
        private System.Windows.Forms.Label lblTaksitlerToplamı;
        private System.Windows.Forms.Label lblTaksitlerToplamı1;
    }
}