using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oyuncu_815
{
    public partial class Form1 : Form
    {
        Oyuncu oyuncu1;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            string rId = random.Next(1000, 10000).ToString();
            oyuncu1 = new Oyuncu(rId,txtAd.Text, txtSoyad.Text, txtPosta.Text, DateTime.Now ,100,false);
           /* oyuncu1.Ad = txtAd.Text;
            oyuncu1.Soyad = txtSoyad.Text;
            oyuncu1.Posta = txtPosta.Text;
           oyuncu1.Id = random.Next(1000,10000).ToString();
            oyuncu1.Puan = 100;
            oyuncu1.Aktif = false;
            oyuncu1.KayitTarih = DateTime.Now;*/

            MessageBox.Show( "Bilgileriniz:" + "\nAd :" + oyuncu1.Ad
                          + "\nSoyad :" + oyuncu1.Soyad
                          + "\nE-posta :" + oyuncu1.Posta
                          + "\nId :" + oyuncu1.Id
                          + "\nPuan :" + oyuncu1.Puan);

        }
    }
}
