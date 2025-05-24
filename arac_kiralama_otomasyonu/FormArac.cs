using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace arac_kiralama_otomasyonu
{
    public partial class FormArac: Form
    {
        public FormArac()
        {
            InitializeComponent();
        }
        private void AracListele()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tbl_Arac", bgl.baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            // Kolon başlıklarını düzenle
            dataGridView1.Columns["Plaka"].HeaderText = "Plaka";
            dataGridView1.Columns["Marka"].HeaderText = "Marka";
            dataGridView1.Columns["Model"].HeaderText = "Model";
            dataGridView1.Columns["Renk"].HeaderText = "Renk";
            dataGridView1.Columns["Durum"].HeaderText = "Durum";
            dataGridView1.Columns["FiyatGunluk"].HeaderText = "Günlük Fiyat (₺)";
            
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.RowTemplate.Height = 28;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
        }
        SqlBaglanti bgl = new SqlBaglanti();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            string plaka = txtPlaka.Text;
            string marka = txtMarka.Text;
            string model = txtModel.Text;
            string renk = txtRenk.Text;
            string durum = cmbDurum.Text;
            decimal fiyatGunluk = Convert.ToDecimal(txtFiyatGunluk.Text);

            // Arac sınıfını kullan
            Arac a = new Arac(plaka, marka, model, renk, durum, fiyatGunluk);
            a.Ekle(); // MessageBox ve log işlemi

            // SQL'e kayıt işlemi
            SqlCommand komut = new SqlCommand("INSERT INTO Tbl_Arac (Plaka, Marka, Model, Renk, Durum, FiyatGunluk) VALUES (@p1, @p2, @p3, @p4, @p5, @p6)", bgl.baglanti);
            komut.Parameters.AddWithValue("@p1", plaka);
            komut.Parameters.AddWithValue("@p2", marka);
            komut.Parameters.AddWithValue("@p3", model);
            komut.Parameters.AddWithValue("@p4", renk);
            komut.Parameters.AddWithValue("@p5", durum);
            komut.Parameters.AddWithValue("@p6", fiyatGunluk);

            bgl.BaglantiAc();
            komut.ExecuteNonQuery();
            bgl.BaglantiKapat();

            MessageBox.Show("Araç veritabanına kaydedildi.");
            AracListele();
        }

        private void FormArac_Load(object sender, EventArgs e)
        {
            AracListele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txtPlaka.Text = dataGridView1.Rows[secilen].Cells["Plaka"].Value.ToString();
            txtMarka.Text = dataGridView1.Rows[secilen].Cells["Marka"].Value.ToString();
            txtModel.Text = dataGridView1.Rows[secilen].Cells["Model"].Value.ToString();
            txtRenk.Text = dataGridView1.Rows[secilen].Cells["Renk"].Value.ToString();
            cmbDurum.Text = dataGridView1.Rows[secilen].Cells["Durum"].Value.ToString();
            txtFiyatGunluk.Text = dataGridView1.Rows[secilen].Cells["FiyatGunluk"].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("DELETE FROM Tbl_Arac WHERE Plaka = @p1", bgl.baglanti);
            komut.Parameters.AddWithValue("@p1", txtPlaka.Text);

            bgl.BaglantiAc();
            komut.ExecuteNonQuery();
            bgl.BaglantiKapat();

            MessageBox.Show("Araç silindi.");
            AracListele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("UPDATE Tbl_Arac SET Marka=@p2, Model=@p3, Renk=@p4, Durum=@p5, FiyatGunluk=@p6 WHERE Plaka = @p1", bgl.baglanti);
            komut.Parameters.AddWithValue("@p1", txtPlaka.Text);
            komut.Parameters.AddWithValue("@p2", txtMarka.Text);
            komut.Parameters.AddWithValue("@p3", txtModel.Text);
            komut.Parameters.AddWithValue("@p4", txtRenk.Text);
            komut.Parameters.AddWithValue("@p5", cmbDurum.Text);
            komut.Parameters.AddWithValue("@p6", Convert.ToDecimal(txtFiyatGunluk.Text));

            bgl.BaglantiAc();
            komut.ExecuteNonQuery();
            bgl.BaglantiKapat();

            MessageBox.Show("Araç bilgisi güncellendi.");
            AracListele();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            string aranan = txtAra.Text.Trim();

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tbl_Arac WHERE Plaka LIKE @p OR Marka LIKE @p OR Model LIKE @p", bgl.baglanti);
            da.SelectCommand.Parameters.AddWithValue("@p", "%" + aranan + "%");

            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            string aranan = txtAra.Text.Trim();

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tbl_Arac WHERE Plaka LIKE @p OR Marka LIKE @p OR Model LIKE @p", bgl.baglanti);
            da.SelectCommand.Parameters.AddWithValue("@p", "%" + aranan + "%");

            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
