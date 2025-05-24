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
    public partial class FormAdminPanel: Form
    {
        public FormAdminPanel()
        {
            InitializeComponent();
        }

        private void btnMusteriYonetimi_Click(object sender, EventArgs e)
        {
            FormMusteri frm = new FormMusteri();
            frm.Show();
        }

        private void btnAracYonetimi_Click(object sender, EventArgs e)
        {
            FormArac frm = new FormArac(); // daha önce birlikte yaptığımız form
            frm.Show();
        }

        private void btnRezervasyonlar_Click(object sender, EventArgs e)
        {
            FormRezervasyon frm = new FormRezervasyon();
            frm.Show();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormAdminPanel_Load(object sender, EventArgs e)
        {
            lblBaslik.Text = "Hoş geldin, " + FormGiris.girisYapan;
        }
    }
}
