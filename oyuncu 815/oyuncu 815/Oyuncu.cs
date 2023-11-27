using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oyuncu_815
{
    internal class Oyuncu
    {
        public string Ad { get; set; }

        public string Soyad { get; set; }

        public string Posta { get; set; }

         public DateTime KayitTarih { get; set; }
       
        public bool Aktif { get; set; }

        public string Id { get; set; }

        public double Puan { get; set; }

        public Oyuncu (string ıd,string ad, string soyad, string posta, DateTime kayitTarih,double puan, bool aktif)
        {
            Ad = ad;
            Soyad = soyad;
            Posta = posta;
            KayitTarih = kayitTarih;
            Aktif = aktif;
            Id = ıd;
            Puan = puan;
        }
    }
}
