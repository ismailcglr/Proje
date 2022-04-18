namespace Proje.Formlar
{
    partial class FrmSozlesmeler
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnSozlesmeEkle = new System.Windows.Forms.Button();
            this.grdSozlesmeler = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSozlesmeler)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnSozlesmeEkle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(721, 45);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(162, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "SÖZLEŞME SİL ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSozlesmeEkle
            // 
            this.btnSozlesmeEkle.Location = new System.Drawing.Point(12, 12);
            this.btnSozlesmeEkle.Name = "btnSozlesmeEkle";
            this.btnSozlesmeEkle.Size = new System.Drawing.Size(144, 23);
            this.btnSozlesmeEkle.TabIndex = 0;
            this.btnSozlesmeEkle.Text = "SÖZLEŞME OLUŞTUR";
            this.btnSozlesmeEkle.UseVisualStyleBackColor = true;
            this.btnSozlesmeEkle.Click += new System.EventHandler(this.btnSozlesmeEkle_Click);
            // 
            // grdSozlesmeler
            // 
            this.grdSozlesmeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSozlesmeler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdSozlesmeler.Location = new System.Drawing.Point(0, 45);
            this.grdSozlesmeler.Name = "grdSozlesmeler";
            this.grdSozlesmeler.Size = new System.Drawing.Size(721, 239);
            this.grdSozlesmeler.TabIndex = 1;
            // 
            // FrmSozlesmeler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 284);
            this.Controls.Add(this.grdSozlesmeler);
            this.Controls.Add(this.panel1);
            this.Name = "FrmSozlesmeler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SÖZLEŞMELER";
            this.Load += new System.EventHandler(this.FrmSozlesmeler_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdSozlesmeler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSozlesmeEkle;
        private System.Windows.Forms.DataGridView grdSozlesmeler;
        private System.Windows.Forms.Button button1;
    }
}