using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operatorler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Matematiksel işlemler

        private void btnToplama_Click(object sender, EventArgs e)
        {

            // + operatorü sayısal değerlerde, toplama -  metinsel değerlerde ise, birleştirme(yan yana yazma işlemi yapar)
            int s1 = 120;
            int s2 = 25;

            int toplam = s1 + s2;
            MessageBox.Show("Toplama işleminin sonucu : " + toplam);  // Çıktı => 145
            //MessageBox.Show("Toplama işleminin sonucu : " + s1 + s2);  // Çıktı => 12025
            //MessageBox.Show("Toplama işleminin sonucu : " + (s1 + s2));  // Çıktı => 145
        }

        private void btnCikartma_Click(object sender, EventArgs e)
        {
            int s1 = 120;
            int s2 = 30;
            int fark = s1 - s2;

            MessageBox.Show("Çıkartma işleminin sonucu : " + fark);
        }

        private void btnCarpma_Click(object sender, EventArgs e)
        {
            long s1 = 100;
            long s2 = 12;
            long carpim = s1 * s2;

            MessageBox.Show("Çarpma işleminin sonucu : " + carpim);
        }

        private void btnBolme_Click(object sender, EventArgs e)
        {
            double s1 = 120.6;
            double s2 = 12.5;
            double bolum = s1 / s2;

            MessageBox.Show("Bölme işleminin sonucu : " + bolum); 
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            int s1 = 100;
            double s2 = 10.5;
            double mod = s1 % s2;

            MessageBox.Show("Mod işlemi sonucu : " + mod);
        }
    }
}
