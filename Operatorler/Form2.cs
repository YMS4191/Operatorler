using System;
using System.Drawing;
using System.Windows.Forms;

namespace Operatorler
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnOrnek1_Click(object sender, EventArgs e)
        {
            //string s1 = txtSayi1.Text;
            //string s2 = txtSayi2.Text;

            //int sayi1 = Convert.ToInt32(s1);
            //int sayi2 = Convert.ToInt32(s2);


            //Disaridan alinan iki sayının toplamiyla farkinin birbirine bolumunden kalanin sonucu kactir? (Farkın toplama bolumunden kalan kactir?)

            int sayi1 = Convert.ToInt32(txtSayi1.Text);
            int sayi2 = Convert.ToInt32(txtSayi2.Text);
            int toplam = sayi1 + sayi2;
            int fark = sayi1 - sayi2;

            int bolumdenKalan = toplam % fark;
            MessageBox.Show("İşlem sonucu : " + bolumdenKalan);

            // int bolumdenKalan1 = (sayi1 + sayi2) % (sayi1 - sayi2); 
            // MessageBox.Show("İşlem sonucu : " + (sayi1 + sayi2) % (sayi1 - sayi2));
            // MessageBox.Show("İşlem sonucu : " + (Convert.ToInt32(txtSayi1.Text) + Convert.ToInt32(txtSayi2.Text)) % (Convert.ToInt32(txtSayi1.Text) - Convert.ToInt32(txtSayi2.Text)));

        }

        private void btnOrnek2_Click(object sender, EventArgs e)
        {
            // 1) Disaridan girilen bir sayı 
            int sayi = int.Parse(txtSayi1.Text);

            // 2) Disaridan girilen bir sayının 10 eksigi 
            sayi = sayi - 10;

            // 3) Disaridan girilen bir sayının 10 eksiginin 20 fazlasi 
            sayi = sayi + 20;

            // 4) Disaridan girilen bir sayının 10 eksiginin 20 fazlasinin 2ye bolumunden kalan
            int mod = sayi % 2;

            //5 Disaridan girilen bir sayının 10 eksiginin 20 fazlasinin 2ye bolumunden kalaninin karesi kactir?

            sayi = mod * mod;
            MessageBox.Show("İşlem sonucu : " + sayi);


            sayi = int.Parse(txtSayi1.Text);
            double sonuc = (sayi - 10 + 20) % 2;
            MessageBox.Show("İşlem sonucu : " + (sonuc * sonuc));
        }

        private void btnOrnek3_Click(object sender, EventArgs e)
        {
            //Disaridan girilen iki sayının karelerinin toplami ile karelerinin farki toplami kactir?
            int s1 = Convert.ToInt32(txtSayi1.Text);
            int s2 = int.Parse(txtSayi2.Text);

            int birinciKare = s1 * s1;
            int ikinciKare = s2 * s2;

            int toplam = birinciKare + ikinciKare;
            int fark = birinciKare - ikinciKare;
            int sonuc = toplam + fark;

            MessageBox.Show("İşlem sonucu  : " + sonuc);
        }

        private void btnOrnek4_Click(object sender, EventArgs e)
        {
            //Vize notu'nun % 30'u, final notu'nun % 70'ini alıp öğrencinin not ortalamasini cikartan bir uygulama yaziniz... DİKKAT => Notlar ondalikli olabilir?

            double vize = double.Parse(txtSayi1.Text);
            double final = double.Parse(txtSayi2.Text);

            double sonuc = (vize * 0.30) + (final * 0.70);

            MessageBox.Show("Not ortalamanız : " + sonuc);
        }

        private void btnOrnek5_Click(object sender, EventArgs e)
        {

            // Dışarıdan kullanıcı adını ve soyadını ayrı ayrı olarak alnız ve  adi.soyadi@hotmail.com şeklinde mail adresi oluşturup kullanıcıya gösteriniz.

            string isim = txtSayi1.Text;
            string soyisim = txtSayi2.Text;

            string mail = isim + "." + soyisim + "@hotmail.com";
            MessageBox.Show(mail);

        }

    }
}
