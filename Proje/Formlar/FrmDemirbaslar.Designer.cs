namespace Proje.Formlar
{
    partial class FrmDemirbaslar
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
            this.lblOdaBilgi = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDemirbasDelete = new System.Windows.Forms.Button();
            this.btnDemirbasSave = new System.Windows.Forms.Button();
            this.numDemirbasAdet = new System.Windows.Forms.NumericUpDown();
            this.tbDemirbasAdi = new System.Windows.Forms.TextBox();
            this.lblDemirbasAdet = new System.Windows.Forms.Label();
            this.lblDemirbasAdi = new System.Windows.Forms.Label();
            this.gridDemirbaslar = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDemirbasAdet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDemirbaslar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblOdaBilgi);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(644, 62);
            this.panel1.TabIndex = 0;
            // 
            // lblOdaBilgi
            // 
            this.lblOdaBilgi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOdaBilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOdaBilgi.Location = new System.Drawing.Point(0, 0);
            this.lblOdaBilgi.Name = "lblOdaBilgi";
            this.lblOdaBilgi.Size = new System.Drawing.Size(644, 62);
            this.lblOdaBilgi.TabIndex = 0;
            this.lblOdaBilgi.Text = "-";
            this.lblOdaBilgi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDemirbasDelete);
            this.groupBox1.Controls.Add(this.btnDemirbasSave);
            this.groupBox1.Controls.Add(this.numDemirbasAdet);
            this.groupBox1.Controls.Add(this.tbDemirbasAdi);
            this.groupBox1.Controls.Add(this.lblDemirbasAdet);
            this.groupBox1.Controls.Add(this.lblDemirbasAdi);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 259);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(644, 131);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnDemirbasDelete
            // 
            this.btnDemirbasDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDemirbasDelete.Location = new System.Drawing.Point(505, 19);
            this.btnDemirbasDelete.Name = "btnDemirbasDelete";
            this.btnDemirbasDelete.Size = new System.Drawing.Size(118, 39);
            this.btnDemirbasDelete.TabIndex = 5;
            this.btnDemirbasDelete.Text = "SEÇİLİ DEMİRBAŞI SİL";
            this.btnDemirbasDelete.UseVisualStyleBackColor = true;
            this.btnDemirbasDelete.Click += new System.EventHandler(this.btnDemirbasDelete_Click);
            // 
            // btnDemirbasSave
            // 
            this.btnDemirbasSave.Location = new System.Drawing.Point(268, 38);
            this.btnDemirbasSave.Name = "btnDemirbasSave";
            this.btnDemirbasSave.Size = new System.Drawing.Size(95, 50);
            this.btnDemirbasSave.TabIndex = 4;
            this.btnDemirbasSave.Text = "DEMİRBAŞ KAYDET";
            this.btnDemirbasSave.UseVisualStyleBackColor = true;
            this.btnDemirbasSave.Click += new System.EventHandler(this.btnDemirbasSave_Click);
            // 
            // numDemirbasAdet
            // 
            this.numDemirbasAdet.Location = new System.Drawing.Point(115, 68);
            this.numDemirbasAdet.Name = "numDemirbasAdet";
            this.numDemirbasAdet.Size = new System.Drawing.Size(120, 20);
            this.numDemirbasAdet.TabIndex = 3;
            // 
            // tbDemirbasAdi
            // 
            this.tbDemirbasAdi.Location = new System.Drawing.Point(135, 38);
            this.tbDemirbasAdi.Name = "tbDemirbasAdi";
            this.tbDemirbasAdi.Size = new System.Drawing.Size(100, 20);
            this.tbDemirbasAdi.TabIndex = 2;
            // 
            // lblDemirbasAdet
            // 
            this.lblDemirbasAdet.AutoSize = true;
            this.lblDemirbasAdet.Location = new System.Drawing.Point(33, 68);
            this.lblDemirbasAdet.Name = "lblDemirbasAdet";
            this.lblDemirbasAdet.Size = new System.Drawing.Size(36, 13);
            this.lblDemirbasAdet.TabIndex = 1;
            this.lblDemirbasAdet.Text = "ADET";
            // 
            // lblDemirbasAdi
            // 
            this.lblDemirbasAdi.AutoSize = true;
            this.lblDemirbasAdi.Location = new System.Drawing.Point(33, 38);
            this.lblDemirbasAdi.Name = "lblDemirbasAdi";
            this.lblDemirbasAdi.Size = new System.Drawing.Size(84, 13);
            this.lblDemirbasAdi.TabIndex = 0;
            this.lblDemirbasAdi.Text = "DEMİRBAŞ ADI";
            // 
            // gridDemirbaslar
            // 
            this.gridDemirbaslar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDemirbaslar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridDemirbaslar.Location = new System.Drawing.Point(0, 62);
            this.gridDemirbaslar.Name = "gridDemirbaslar";
            this.gridDemirbaslar.Size = new System.Drawing.Size(644, 197);
            this.gridDemirbaslar.TabIndex = 2;
            // 
            // FrmDemirbaslar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 390);
            this.Controls.Add(this.gridDemirbaslar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "FrmDemirbaslar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DEMİRBAŞ LİSTESİ";
            this.Load += new System.EventHandler(this.FrmDemirbaslar_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDemirbasAdet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDemirbaslar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView gridDemirbaslar;
        private System.Windows.Forms.Label lblOdaBilgi;
        private System.Windows.Forms.Label lblDemirbasAdet;
        private System.Windows.Forms.Label lblDemirbasAdi;
        private System.Windows.Forms.NumericUpDown numDemirbasAdet;
        private System.Windows.Forms.TextBox tbDemirbasAdi;
        private System.Windows.Forms.Button btnDemirbasSave;
        private System.Windows.Forms.Button btnDemirbasDelete;
    }
}