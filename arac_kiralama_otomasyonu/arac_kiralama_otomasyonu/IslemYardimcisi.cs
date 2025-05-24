using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arac_kiralama_otomasyonu
{
    public static class IslemYardimcisi
    {
        public static void Log(string mesaj)
        {
            MessageBox.Show("BİLGİ " + mesaj);
        }
    }
}
