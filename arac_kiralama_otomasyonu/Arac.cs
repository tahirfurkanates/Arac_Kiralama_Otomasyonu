using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arac_kiralama_otomasyonu
{
    public class Arac : IArayuz4
    {
        // 🔐 Encapsulation – private alanlar
        private string _plaka;
        private string _marka;
        private string _model;
        private string _renk;
        private string _durum;
        private decimal _fiyatGunluk;

        // 🧱 Property'ler
        public string Plaka { get => _plaka; set => _plaka = value; }
        public string Marka { get => _marka; set => _marka = value; }
        public string Model { get => _model; set => _model = value; }
        public string Renk { get => _renk; set => _renk = value; }
        public string Durum { get => _durum; set => _durum = value; }
        public decimal FiyatGunluk { get => _fiyatGunluk; set => _fiyatGunluk = value; }

        // 🧩 Constructor
        public Arac(string plaka, string marka, string model, string renk, string durum, decimal fiyatGunluk)
        {
            Plaka = plaka;
            Marka = marka;
            Model = model;
            Renk = renk;
            Durum = durum;
            FiyatGunluk = fiyatGunluk;
        }

        // 🔁 CRUD Metotları
        public void Ekle()
        {
            MessageBox.Show("Araç eklendi: " + Plaka);
            Log("Yeni araç eklendi: " + Plaka);
        }

        public void Listele()
        {
            MessageBox.Show("Araçlar listelendi.");
        }

        public void Ara(string kriter)
        {
            MessageBox.Show("Araç arandı: " + kriter);
        }

        public void Guncelle()
        {
            MessageBox.Show("Araç güncellendi: " + Plaka);
        }

        public void Sil()
        {
            MessageBox.Show("Araç silindi: " + Plaka);
        }

        // 📋 Log metodu
        public void Log(string mesaj)
        {
            File.AppendAllText("log.txt", DateTime.Now + " - " + mesaj + Environment.NewLine);
        }

        // 💾 Yedekleme işlemi
        public void YedekAl()
        {
            MessageBox.Show("Araç verisi yedeklendi.");
        }
    }
}
