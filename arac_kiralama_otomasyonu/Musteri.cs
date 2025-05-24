using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arac_kiralama_otomasyonu
{
    public class Musteri : IArayuz2, IArayuz3
    {
        // 🔐 Encapsulation – private değişkenler
        private string _tc;
        private string _adSoyad;
        private string _telefon;
        private string _adres; // Yeni eklendi

        // 🧱 Property'ler
        public string TC { get => _tc; set => _tc = value; }
        public string AdSoyad { get => _adSoyad; set => _adSoyad = value; }
        public string Telefon { get => _telefon; set => _telefon = value; }
        public string Adres { get => _adres; set => _adres = value; } // Yeni eklendi

        // 🧩 Constructor – yapıcı metot
        public Musteri(string tc, string adSoyad, string telefon, string adres)
        {
            TC = tc;
            AdSoyad = adSoyad;
            Telefon = telefon;
            Adres = adres;
        }

        // 🛠 CRUD Metotları
        public void Ekle()
        {
            MessageBox.Show("Müşteri eklendi: " + AdSoyad);
            Log("Yeni müşteri eklendi: " + AdSoyad + " - TC: " + TC);
        }

        public void Listele()
        {
            MessageBox.Show("Müşteriler listelendi.");
        }

        // 📌 Overloading örneği
        public void Ara(string kriter)
        {
            MessageBox.Show("Müşteri arandı: " + kriter);
        }

        public void Ara(int tcNo)
        {
            MessageBox.Show("Müşteri TC ile arandı: " + tcNo);
        }

        public void Guncelle()
        {
            MessageBox.Show("Müşteri güncellendi.");
        }

        public void Sil()
        {
            MessageBox.Show("Müşteri silindi.");
        }

        // 📋 Log metodu – log.txt’ye yaz
        public void Log(string mesaj)
        {
            File.AppendAllText("log.txt", DateTime.Now + " - " + mesaj + Environment.NewLine);
        }
    }
}
