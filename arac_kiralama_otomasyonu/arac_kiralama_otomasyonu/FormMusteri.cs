using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arac_kiralama_otomasyonu
{
    public partial class FormMusteri: Form
    {
        SqlBaglanti bgl = new SqlBaglanti();
        public FormMusteri()
        {
            InitializeComponent();
        }

        private void FormMusteri_Load(object sender, EventArgs e)
        {
            MusteriListele();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void MusteriListele()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tbl_Musteri", bgl.baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            // Kolon başlıklarını düzenle
            dataGridView1.Columns["TC"].HeaderText = "T.C. Kimlik No";
            dataGridView1.Columns["AdSoyad"].HeaderText = "Adı Soyadı";
            dataGridView1.Columns["Telefon"].HeaderText = "Telefon Numarası";
            dataGridView1.Columns["Adres"].HeaderText = "Adres Bilgisi";
            dataGridView1.Columns["TC"].Width = 120;
            dataGridView1.Columns["AdSoyad"].Width = 150;
            dataGridView1.Columns["Telefon"].Width = 120;
            dataGridView1.Columns["Adres"].Width = 200;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 10);

        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            string tc = txtTC.Text;
            string ad = txtAdSoyad.Text;
            string tel = txtTelefon.Text;
            string adres = txtAdres.Text;

            // Sql kayıt işlemi
            SqlCommand komut = new SqlCommand("INSERT INTO Tbl_Musteri (TC, AdSoyad, Telefon, Adres) VALUES (@tc, @ad, @tel, @adres)", bgl.baglanti);
            komut.Parameters.AddWithValue("@tc", tc);
            komut.Parameters.AddWithValue("@ad", ad);
            komut.Parameters.AddWithValue("@tel", tel);
            komut.Parameters.AddWithValue("@adres", adres);

            bgl.BaglantiAc();
            komut.ExecuteNonQuery();
            bgl.BaglantiKapat();

            MessageBox.Show("Müşteri başarıyla veritabanına kaydedildi.");

            // Listeleme işlemi varsa:
            MusteriListele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("DELETE FROM Tbl_Musteri WHERE TC = @tc", bgl.baglanti);
            komut.Parameters.AddWithValue("@tc", txtTC.Text);

            bgl.BaglantiAc();
            komut.ExecuteNonQuery();
            bgl.BaglantiKapat();

            MessageBox.Show("Müşteri silindi.");
            MusteriListele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txtTC.Text = dataGridView1.Rows[secilen].Cells["TC"].Value.ToString();
            txtAdSoyad.Text = dataGridView1.Rows[secilen].Cells["AdSoyad"].Value.ToString();
            txtTelefon.Text = dataGridView1.Rows[secilen].Cells["Telefon"].Value.ToString();
            txtAdres.Text = dataGridView1.Rows[secilen].Cells["Adres"].Value.ToString();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("UPDATE Tbl_Musteri SET AdSoyad = @ad, Telefon = @tel, Adres = @adres WHERE TC = @tc", bgl.baglanti);
            komut.Parameters.AddWithValue("@tc", txtTC.Text);
            komut.Parameters.AddWithValue("@ad", txtAdSoyad.Text);
            komut.Parameters.AddWithValue("@tel", txtTelefon.Text);
            komut.Parameters.AddWithValue("@adres", txtAdres.Text);

            bgl.BaglantiAc();
            komut.ExecuteNonQuery();
            bgl.BaglantiKapat();

            MessageBox.Show("Müşteri güncellendi.");
            MusteriListele();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            string aranan = txtAra.Text.Trim();

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tbl_Musteri WHERE AdSoyad LIKE @arama OR TC LIKE @arama", bgl.baglanti);
            da.SelectCommand.Parameters.AddWithValue("@arama", "%" + aranan + "%");

            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            string aranan = txtAra.Text.Trim();

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tbl_Musteri WHERE AdSoyad LIKE @arama OR TC LIKE @arama", bgl.baglanti);
            da.SelectCommand.Parameters.AddWithValue("@arama", "%" + aranan + "%");

            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
