using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arac_kiralama_otomasyonu
{
    public class Personel : Kullanici
    {
        public override string YetkiGetir()
        {
            return "Sadece rezervasyon yapabilir";
        }
    }
}
