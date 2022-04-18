namespace Proje.Formlar
{
    partial class FrmOdemeYap
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
            this.lblOdemeTarih = new System.Windows.Forms.Label();
            this.lblOdemeTutar = new System.Windows.Forms.Label();
            this.lblOdemeAcıklama = new System.Windows.Forms.Label();
            this.dtpOdemeTarih = new System.Windows.Forms.DateTimePicker();
            this.tbOdemeTutar = new System.Windows.Forms.TextBox();
            this.tbOdemeAcıklama = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblOdemeTarih
            // 
            this.lblOdemeTarih.AutoSize = true;
            this.lblOdemeTarih.Location = new System.Drawing.Point(27, 20);
            this.lblOdemeTarih.Name = "lblOdemeTarih";
            this.lblOdemeTarih.Size = new System.Drawing.Size(40, 13);
            this.lblOdemeTarih.TabIndex = 0;
            this.lblOdemeTarih.Text = "TARİH";
            // 
            // lblOdemeTutar
            // 
            this.lblOdemeTutar.AutoSize = true;
            this.lblOdemeTutar.Location = new System.Drawing.Point(27, 53);
            this.lblOdemeTutar.Name = "lblOdemeTutar";
            this.lblOdemeTutar.Size = new System.Drawing.Size(44, 13);
            this.lblOdemeTutar.TabIndex = 1;
            this.lblOdemeTutar.Text = "TUTAR";
            // 
            // lblOdemeAcıklama
            // 
            this.lblOdemeAcıklama.AutoSize = true;
            this.lblOdemeAcıklama.Location = new System.Drawing.Point(27, 79);
            this.lblOdemeAcıklama.Name = "lblOdemeAcıklama";
            this.lblOdemeAcıklama.Size = new System.Drawing.Size(60, 13);
            this.lblOdemeAcıklama.TabIndex = 2;
            this.lblOdemeAcıklama.Text = "AÇIKLAMA";
            // 
            // dtpOdemeTarih
            // 
            this.dtpOdemeTarih.Location = new System.Drawing.Point(98, 20);
            this.dtpOdemeTarih.Name = "dtpOdemeTarih";
            this.dtpOdemeTarih.Size = new System.Drawing.Size(169, 20);
            this.dtpOdemeTarih.TabIndex = 3;
            // 
            // tbOdemeTutar
            // 
            this.tbOdemeTutar.Location = new System.Drawing.Point(98, 46);
            this.tbOdemeTutar.Name = "tbOdemeTutar";
            this.tbOdemeTutar.Size = new System.Drawing.Size(62, 20);
            this.tbOdemeTutar.TabIndex = 4;
            // 
            // tbOdemeAcıklama
            // 
            this.tbOdemeAcıklama.Location = new System.Drawing.Point(98, 72);
            this.tbOdemeAcıklama.Name = "tbOdemeAcıklama";
            this.tbOdemeAcıklama.Size = new System.Drawing.Size(248, 20);
            this.tbOdemeAcıklama.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(30, 107);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(91, 45);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "KAYDET";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(127, 107);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 45);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "İPTAL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmOdemeYap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 173);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbOdemeAcıklama);
            this.Controls.Add(this.tbOdemeTutar);
            this.Controls.Add(this.dtpOdemeTarih);
            this.Controls.Add(this.lblOdemeAcıklama);
            this.Controls.Add(this.lblOdemeTutar);
            this.Controls.Add(this.lblOdemeTarih);
            this.Name = "FrmOdemeYap";
            this.Text = "ÖDEME YAP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOdemeTarih;
        private System.Windows.Forms.Label lblOdemeTutar;
        private System.Windows.Forms.Label lblOdemeAcıklama;
        private System.Windows.Forms.DateTimePicker dtpOdemeTarih;
        private System.Windows.Forms.TextBox tbOdemeTutar;
        private System.Windows.Forms.TextBox tbOdemeAcıklama;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}