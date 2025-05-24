using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace arac_kiralama_otomasyonu
{

    public partial class FormRezervasyon: Form
    {
        SqlBaglanti bgl = new SqlBaglanti();
        public FormRezervasyon()
        {
            InitializeComponent();
        }
        private void AlanlariTemizle()
        {
            cmbMusteriTC.SelectedIndex = -1;
            cmbAracPlaka.SelectedIndex = -1;
            dtAlis.Value = DateTime.Now;
            dtIade.Value = DateTime.Now.AddDays(1); // En az 1 gün sonrası
            txtGunSayisi.Text = "";
            txtToplamTutar.Text = "";
        }
        private void AracComboDoldur()
        {
            cmbAracPlaka.Items.Clear();

            DateTime alis = dtAlis.Value.Date;
            DateTime iade = dtIade.Value.Date;

            SqlCommand cmd = new SqlCommand(@"
        SELECT Plaka FROM Tbl_Arac 
        WHERE Plaka NOT IN (
            SELECT AracPlaka FROM Tbl_Rezervasyon
            WHERE (@alis < IadeTarihi AND @iade > AlisTarihi)
        )", bgl.baglanti);

            cmd.Parameters.AddWithValue("@alis", alis);
            cmd.Parameters.AddWithValue("@iade", iade);

            bgl.BaglantiAc();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbAracPlaka.Items.Add(dr[0].ToString());
            }
            bgl.BaglantiKapat();
        }
        private void MusteriComboDoldur()
        {
            cmbMusteriTC.Items.Clear();
            SqlCommand cmd = new SqlCommand("SELECT TC FROM Tbl_Musteri", bgl.baglanti);
            bgl.BaglantiAc();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbMusteriTC.Items.Add(dr[0].ToString());
            }
            bgl.BaglantiKapat();
        }
        private void UcretHesapla()
        {
            TimeSpan fark = dtIade.Value.Date - dtAlis.Value.Date;
            int gun = fark.Days;

            if (gun <= 0)
            {
                txtGunSayisi.Text = "0";
                txtToplamTutar.Text = "0";
                return;
            }

            txtGunSayisi.Text = gun.ToString();

            SqlCommand komut = new SqlCommand("SELECT FiyatGunluk FROM Tbl_Arac WHERE Plaka = @plaka", bgl.baglanti);
            komut.Parameters.AddWithValue("@plaka", cmbAracPlaka.Text);

            bgl.BaglantiAc();
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                decimal fiyatGunluk = Convert.ToDecimal(dr[0]);

                // Overloading 
                RezervasyonHesaplayici hesaplayici = new RezervasyonHesaplayici();
                decimal toplam = hesaplayici.Hesapla(dtAlis.Value.Date, dtIade.Value.Date, fiyatGunluk);

                txtToplamTutar.Text = toplam.ToString("F2");
            }
            bgl.BaglantiKapat();
        }
        private void RezervasyonListele()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tbl_Rezervasyon", bgl.baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            // Kolon başlıklarını düzenle
            dataGridView1.Columns["MusteriTC"].HeaderText = "T.C. Kimlik No";
            dataGridView1.Columns["AracPlaka"].HeaderText = "Plaka";
            dataGridView1.Columns["AlisTarihi"].HeaderText = "Alış Tarihi";
            dataGridView1.Columns["IadeTarihi"].HeaderText = "İade Tarihi";
            dataGridView1.Columns["GunSayisi"].HeaderText = "Gün";
            dataGridView1.Columns["ToplamTutar"].HeaderText = "Toplam ₺";

            // Görsel ayarlar (opsiyonel)
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dataGridView1.RowTemplate.Height = 28;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }


        private void ComboBoxlariDoldur()
        {
            cmbMusteriTC.Items.Clear();
            cmbAracPlaka.Items.Clear();

            // Müşteri TC'leri
            SqlCommand cmdMusteri = new SqlCommand("SELECT TC FROM Tbl_Musteri", bgl.baglanti);
            bgl.BaglantiAc();
            SqlDataReader dr1 = cmdMusteri.ExecuteReader();
            while (dr1.Read())
            {
                cmbMusteriTC.Items.Add(dr1[0].ToString());
            }
            bgl.BaglantiKapat();

            // Tarih aralığına göre araçları getir
            DateTime alis = dtAlis.Value.Date;
            DateTime iade = dtIade.Value.Date;

            SqlCommand cmdArac = new SqlCommand(@"
        SELECT Plaka FROM Tbl_Arac 
        WHERE Plaka NOT IN (
            SELECT AracPlaka FROM Tbl_Rezervasyon
            WHERE (@alis < IadeTarihi AND @iade > AlisTarihi)
        )", bgl.baglanti);

            cmdArac.Parameters.AddWithValue("@alis", alis);
            cmdArac.Parameters.AddWithValue("@iade", iade);

            bgl.BaglantiAc();
            SqlDataReader dr2 = cmdArac.ExecuteReader();
            while (dr2.Read())
            {
                cmbAracPlaka.Items.Add(dr2[0].ToString());
            }
            bgl.BaglantiKapat();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbMusteriTC.Text == "" || cmbAracPlaka.Text == "" || txtGunSayisi.Text == "0")
            {
                MessageBox.Show("Lütfen tüm alanları düzgün şekilde doldurun!");
                return;
            }

            SqlCommand komut = new SqlCommand("INSERT INTO Tbl_Rezervasyon (MusteriTC, AracPlaka, AlisTarihi, IadeTarihi, GunSayisi, ToplamTutar) VALUES (@tc, @plaka, @alis, @iade, @gun, @tutar)", bgl.baglanti);
            komut.Parameters.AddWithValue("@tc", cmbMusteriTC.Text);
            komut.Parameters.AddWithValue("@plaka", cmbAracPlaka.Text);
            komut.Parameters.AddWithValue("@alis", dtAlis.Value.Date);
            komut.Parameters.AddWithValue("@iade", dtIade.Value.Date);
            komut.Parameters.AddWithValue("@gun", Convert.ToInt32(txtGunSayisi.Text));
            komut.Parameters.AddWithValue("@tutar", Convert.ToDecimal(txtToplamTutar.Text));

            bgl.BaglantiAc();
            komut.ExecuteNonQuery();
            bgl.BaglantiKapat();

            // 🟢 LOG METODU BURAYA EKLENİR
            IslemYardimcisi.Log("Rezervasyon eklendi: " + cmbMusteriTC.Text + " → " + cmbAracPlaka.Text);

            // Araç durumu artık "Kirada" olmalı
            SqlCommand durumGuncelle = new SqlCommand("UPDATE Tbl_Arac SET Durum = 'Kirada' WHERE Plaka = @p", bgl.baglanti);
            durumGuncelle.Parameters.AddWithValue("@p", cmbAracPlaka.Text);
            bgl.BaglantiAc();
            durumGuncelle.ExecuteNonQuery();
            bgl.BaglantiKapat();

            MessageBox.Show("Rezervasyon başarıyla kaydedildi!");

            RezervasyonListele(); // varsa listeyi yenile
            AlanlariTemizle();
            AracComboDoldur(); // sadece araçlar yeniden yüklensin
        }

        private void FormRezervasyon_Load(object sender, EventArgs e)
        {
            MusteriComboDoldur();   // ✅ yalnızca bir kez yüklenir
            AracComboDoldur();      // ✅ tarihe göre doldurulur
            RezervasyonListele();

            cmbMusteriTC.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAracPlaka.DropDownStyle = ComboBoxStyle.DropDownList;

            txtGunSayisi.ReadOnly = true;
            txtToplamTutar.ReadOnly = true;
        }

        private void dtAlis_ValueChanged(object sender, EventArgs e)
        {
            AracComboDoldur();
            UcretHesapla();
        }

        private void dtIade_ValueChanged(object sender, EventArgs e)
        {
            AracComboDoldur();
            UcretHesapla();
        }

        private void cmbAracPlaka_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcretHesapla();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            cmbMusteriTC.Text = dataGridView1.Rows[secilen].Cells["MusteriTC"].Value.ToString();
            cmbAracPlaka.Text = dataGridView1.Rows[secilen].Cells["AracPlaka"].Value.ToString();
            dtAlis.Value = Convert.ToDateTime(dataGridView1.Rows[secilen].Cells["AlisTarihi"].Value);
            dtIade.Value = Convert.ToDateTime(dataGridView1.Rows[secilen].Cells["IadeTarihi"].Value);
            txtGunSayisi.Text = dataGridView1.Rows[secilen].Cells["GunSayisi"].Value.ToString();
            txtToplamTutar.Text = dataGridView1.Rows[secilen].Cells["ToplamTutar"].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            string rezervasyonId = dataGridView1.Rows[secilen].Cells["ID"].Value.ToString();
            string plaka = dataGridView1.Rows[secilen].Cells["AracPlaka"].Value.ToString();

            DialogResult cevap = MessageBox.Show("Bu rezervasyonu silmek istediğine emin misin?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (cevap == DialogResult.Yes)
            {
                // REZERVASYONU SİL
                SqlCommand komut = new SqlCommand("DELETE FROM Tbl_Rezervasyon WHERE ID = @id", bgl.baglanti);
                komut.Parameters.AddWithValue("@id", rezervasyonId);
                bgl.BaglantiAc();
                komut.ExecuteNonQuery();
                bgl.BaglantiKapat();

                // ARAÇ DURUMUNU MÜSAİT YAP
                SqlCommand guncelle = new SqlCommand("UPDATE Tbl_Arac SET Durum = 'Müsait' WHERE Plaka = @p", bgl.baglanti);
                guncelle.Parameters.AddWithValue("@p", plaka);
                bgl.BaglantiAc();
                guncelle.ExecuteNonQuery();
                bgl.BaglantiKapat();

                MessageBox.Show("Rezervasyon silindi. Araç tekrar müsait hale getirildi.");

                RezervasyonListele();
                AlanlariTemizle();
            }
        }
    }
}
