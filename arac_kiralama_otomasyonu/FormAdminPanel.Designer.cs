namespace arac_kiralama_otomasyonu
{
    partial class FormAdminPanel
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
            this.btnMusteriYonetimi = new System.Windows.Forms.Button();
            this.btnAracYonetimi = new System.Windows.Forms.Button();
            this.btnRezervasyonlar = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMusteriYonetimi
            // 
            this.btnMusteriYonetimi.Location = new System.Drawing.Point(87, 215);
            this.btnMusteriYonetimi.Name = "btnMusteriYonetimi";
            this.btnMusteriYonetimi.Size = new System.Drawing.Size(75, 72);
            this.btnMusteriYonetimi.TabIndex = 0;
            this.btnMusteriYonetimi.Text = "Müşteri Yönetimi";
            this.btnMusteriYonetimi.UseVisualStyleBackColor = true;
            this.btnMusteriYonetimi.Click += new System.EventHandler(this.btnMusteriYonetimi_Click);
            // 
            // btnAracYonetimi
            // 
            this.btnAracYonetimi.Location = new System.Drawing.Point(168, 215);
            this.btnAracYonetimi.Name = "btnAracYonetimi";
            this.btnAracYonetimi.Size = new System.Drawing.Size(75, 73);
            this.btnAracYonetimi.TabIndex = 1;
            this.btnAracYonetimi.Text = "Araç Yönetimi";
            this.btnAracYonetimi.UseVisualStyleBackColor = true;
            this.btnAracYonetimi.Click += new System.EventHandler(this.btnAracYonetimi_Click);
            // 
            // btnRezervasyonlar
            // 
            this.btnRezervasyonlar.Location = new System.Drawing.Point(249, 216);
            this.btnRezervasyonlar.Name = "btnRezervasyonlar";
            this.btnRezervasyonlar.Size = new System.Drawing.Size(108, 72);
            this.btnRezervasyonlar.TabIndex = 2;
            this.btnRezervasyonlar.Text = "Rezervasyon yönetimi";
            this.btnRezervasyonlar.UseVisualStyleBackColor = true;
            this.btnRezervasyonlar.Click += new System.EventHandler(this.btnRezervasyonlar_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(363, 215);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(75, 72);
            this.btnCikis.TabIndex = 3;
            this.btnCikis.Text = "Çıkış Yap";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Location = new System.Drawing.Point(221, 137);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(86, 16);
            this.lblBaslik.TabIndex = 4;
            this.lblBaslik.Text = "Admin Paneli";
            // 
            // FormAdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 457);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnRezervasyonlar);
            this.Controls.Add(this.btnAracYonetimi);
            this.Controls.Add(this.btnMusteriYonetimi);
            this.Name = "FormAdminPanel";
            this.Text = "FormAdminPanel";
            this.Load += new System.EventHandler(this.FormAdminPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMusteriYonetimi;
        private System.Windows.Forms.Button btnAracYonetimi;
        private System.Windows.Forms.Button btnRezervasyonlar;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Label lblBaslik;
    }
}