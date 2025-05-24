using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arac_kiralama_otomasyonu
{
    public partial class FormPersonelPanel: Form
    {
        public FormPersonelPanel()
        {
            InitializeComponent();
        }

        private void FormPersonelPanel_Load(object sender, EventArgs e)
        {
            lblBaslik.Text = "Hoş geldin, " + FormGiris.girisYapan;
        }

        private void btnRezervasyonYap_Click(object sender, EventArgs e)
        {
            FormRezervasyon frm = new FormRezervasyon();
            frm.Show();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit(); // veya tekrar giriş ekranına dönmek istersen:
                                // new FormGiris().Show(); this.Hide();
        }
    }
}
