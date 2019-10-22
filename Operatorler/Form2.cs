using System;
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
            string s1 = txtSayi1.Text;
            string s2 = txtSayi2.Text;

            //Disaridan alinan iki sayının toplamiyla farkinin birbirine bolumunden kalanin sonucu kactir? (Farkın toplama bolumunden kalan kactir?)
        }

        private void btnOrnek2_Click(object sender, EventArgs e)
        {
            string s1 = txtSayi1.Text;
            string s2 = txtSayi2.Text;
            //Disaridan girilen bir sayının 10 eksiginin 20 fazlasinin 2ye bolumunden kalaninin karesi kactir?
        }

        private void btnOrnek3_Click(object sender, EventArgs e)
        {
            string s1 = txtSayi1.Text;
            string s2 = txtSayi2.Text;
            //Disaridan girilen iki sayının karelerinin toplami ile karelerinin farki toplami kactir?
        }

        private void btnOrnek4_Click(object sender, EventArgs e)
        {
            string s1 = txtSayi1.Text;
            string s2 = txtSayi2.Text;
            //Vize notu'nun % 30'u, final notu'nun % 70'ini alıp öğrencinin not ortalamasini cikartan bir uygulama yaziniz... DİKKAT => Notlar ondalikli olabilir?
        }

        private void btnOrnek5_Click(object sender, EventArgs e)
        {
            string s1 = txtSayi1.Text;
            string s2 = txtSayi2.Text;
            // Dışarıdan kullanıcı adını ve soyadını ayrı ayrı olarak alnız ve  adi.soyadi@hotmail.com şeklinde mail adresi oluşturup kullanıcıya gösteriniz.
        }
    }
}
