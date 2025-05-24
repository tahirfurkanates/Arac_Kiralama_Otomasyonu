using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arac_kiralama_otomasyonu
{
    public class Kullanici
    {
        public string KullaniciAdi { get; set; }

        // override
        public virtual string YetkiGetir()
        {
            return "Genel Kullanıcı";
        }
    }
}
