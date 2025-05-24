namespace arac_kiralama_otomasyonu
{
    partial class FormRezervasyon
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
            this.cmbMusteriTC = new System.Windows.Forms.ComboBox();
            this.cmbAracPlaka = new System.Windows.Forms.ComboBox();
            this.dtAlis = new System.Windows.Forms.DateTimePicker();
            this.dtIade = new System.Windows.Forms.DateTimePicker();
            this.txtGunSayisi = new System.Windows.Forms.TextBox();
            this.txtToplamTutar = new System.Windows.Forms.TextBox();
            this.btnRezerveEt = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnAra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müşteri TC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Araç Plaka";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Alış Tarihi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "İade Tarihi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Gün Sayısı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Toplam Tutar";
            // 
            // cmbMusteriTC
            // 
            this.cmbMusteriTC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMusteriTC.FormattingEnabled = true;
            this.cmbMusteriTC.Location = new System.Drawing.Point(142, 89);
            this.cmbMusteriTC.Name = "cmbMusteriTC";
            this.cmbMusteriTC.Size = new System.Drawing.Size(121, 24);
            this.cmbMusteriTC.TabIndex = 6;
            // 
            // cmbAracPlaka
            // 
            this.cmbAracPlaka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAracPlaka.FormattingEnabled = true;
            this.cmbAracPlaka.Location = new System.Drawing.Point(142, 119);
            this.cmbAracPlaka.Name = "cmbAracPlaka";
            this.cmbAracPlaka.Size = new System.Drawing.Size(121, 24);
            this.cmbAracPlaka.TabIndex = 7;
            this.cmbAracPlaka.SelectedIndexChanged += new System.EventHandler(this.cmbAracPlaka_SelectedIndexChanged);
            // 
            // dtAlis
            // 
            this.dtAlis.Location = new System.Drawing.Point(142, 33);
            this.dtAlis.Name = "dtAlis";
            this.dtAlis.Size = new System.Drawing.Size(200, 22);
            this.dtAlis.TabIndex = 8;
            this.dtAlis.ValueChanged += new System.EventHandler(this.dtAlis_ValueChanged);
            // 
            // dtIade
            // 
            this.dtIade.Location = new System.Drawing.Point(142, 61);
            this.dtIade.Name = "dtIade";
            this.dtIade.Size = new System.Drawing.Size(200, 22);
            this.dtIade.TabIndex = 9;
            this.dtIade.ValueChanged += new System.EventHandler(this.dtIade_ValueChanged);
            // 
            // txtGunSayisi
            // 
            this.txtGunSayisi.Location = new System.Drawing.Point(142, 149);
            this.txtGunSayisi.Name = "txtGunSayisi";
            this.txtGunSayisi.Size = new System.Drawing.Size(100, 22);
            this.txtGunSayisi.TabIndex = 10;
            // 
            // txtToplamTutar
            // 
            this.txtToplamTutar.Location = new System.Drawing.Point(142, 177);
            this.txtToplamTutar.Name = "txtToplamTutar";
            this.txtToplamTutar.Size = new System.Drawing.Size(100, 22);
            this.txtToplamTutar.TabIndex = 11;
            // 
            // btnRezerveEt
            // 
            this.btnRezerveEt.Location = new System.Drawing.Point(88, 256);
            this.btnRezerveEt.Name = "btnRezerveEt";
            this.btnRezerveEt.Size = new System.Drawing.Size(96, 34);
            this.btnRezerveEt.TabIndex = 12;
            this.btnRezerveEt.Text = "Rezerve Et";
            this.btnRezerveEt.UseVisualStyleBackColor = true;
            this.btnRezerveEt.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(363, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(739, 447);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(142, 205);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(100, 22);
            this.txtAra.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Ara";
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(88, 305);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(96, 34);
            this.btnSil.TabIndex = 16;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(88, 358);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(96, 34);
            this.btnAra.TabIndex = 17;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            // 
            // FormRezervasyon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 536);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnRezerveEt);
            this.Controls.Add(this.txtToplamTutar);
            this.Controls.Add(this.txtGunSayisi);
            this.Controls.Add(this.dtIade);
            this.Controls.Add(this.dtAlis);
            this.Controls.Add(this.cmbAracPlaka);
            this.Controls.Add(this.cmbMusteriTC);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormRezervasyon";
            this.Text = "FormRezervasyon";
            this.Load += new System.EventHandler(this.FormRezervasyon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.ComboBox cmbMusteriTC;
        private System.Windows.Forms.ComboBox cmbAracPlaka;
        private System.Windows.Forms.DateTimePicker dtAlis;
        private System.Windows.Forms.DateTimePicker dtIade;
        private System.Windows.Forms.TextBox txtGunSayisi;
        private System.Windows.Forms.TextBox txtToplamTutar;
        private System.Windows.Forms.Button btnRezerveEt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnAra;
    }
}