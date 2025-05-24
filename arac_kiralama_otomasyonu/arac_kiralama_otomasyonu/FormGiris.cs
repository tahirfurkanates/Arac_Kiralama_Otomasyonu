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
    public partial class FormGiris: Form
    {
        public static string girisYapan = "";
        SqlBaglanti bgl = new SqlBaglanti();
        public FormGiris()
        {
            InitializeComponent();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            if (rbAdmin.Checked)
            {
                SqlCommand komut = new SqlCommand("SELECT * FROM Tbl_Admin WHERE KullaniciAdi = @kadi AND Sifre = @sifre", bgl.baglanti);
                komut.Parameters.AddWithValue("@kadi", txtKullaniciAdi.Text);
                komut.Parameters.AddWithValue("@sifre", txtSifre.Text);

                bgl.BaglantiAc();
                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    girisYapan = txtKullaniciAdi.Text;

                    FormAdminPanel frm = new FormAdminPanel();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatalı admin bilgileri!");
                }
                bgl.BaglantiKapat();
            }
            else if (rbPersonel.Checked)
            {
                SqlCommand komut = new SqlCommand("SELECT * FROM Tbl_Personel WHERE KullaniciAdi = @kadi AND Sifre = @sifre", bgl.baglanti);
                komut.Parameters.AddWithValue("@kadi", txtKullaniciAdi.Text);
                komut.Parameters.AddWithValue("@sifre", txtSifre.Text);

                bgl.BaglantiAc();
                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    girisYapan = txtKullaniciAdi.Text;

                    FormPersonelPanel frm = new FormPersonelPanel();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatalı personel bilgileri!");
                }
                bgl.BaglantiKapat();
            }
            else
            {
                MessageBox.Show("Lütfen giriş tipi seçin (Admin veya Personel)");

            }
        }
    }
}
