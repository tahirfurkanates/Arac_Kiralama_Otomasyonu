using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arac_kiralama_otomasyonu
{
    public class RezervasyonHesaplayici
    {
        // Gün sayısı ve günlük fiyatla hesaplama
        public decimal Hesapla(int gun, decimal fiyatGunluk)
        {
            return gun * fiyatGunluk;
        }

        // Alış ve iade tarihi ile hesaplama
        public decimal Hesapla(DateTime alis, DateTime iade, decimal fiyatGunluk)
        {
            int gun = (iade - alis).Days;
            return gun > 0 ? gun * fiyatGunluk : 0;
        }
    }
}
