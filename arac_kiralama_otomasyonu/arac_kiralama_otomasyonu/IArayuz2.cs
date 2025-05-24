using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arac_kiralama_otomasyonu
{
    interface IArayuz2
    {
        void Ekle();
        void Listele();
        void Ara(string kriter);
        void Guncelle();
        void Sil();
    }
}
