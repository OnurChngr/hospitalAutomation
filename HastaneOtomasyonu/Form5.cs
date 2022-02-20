using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneOtomasyonu
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        string ad, soyad, tc, hastalik, sehir, doktor, bolum;

        private void button1_Click(object sender, EventArgs e)
        {
            ad = txtHastaAd.Text;
            soyad = txtHastaSoyad.Text;
            tc = txtTc.Text;
            hastalik = cmbhastalik.Text;
            sehir = cmbSehir.Text;
            doktor = cmbDoktor.Text;
            bolum = cmbBolum.Text;
            lstMuayeneBilgi.Items.Add(ad + " " + soyad + " " + tc + " " + hastalik + " " + sehir + " " + doktor + " " + bolum);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            lstMuayeneBilgi.Items.Remove(lstMuayeneBilgi.SelectedItem);
        }
    
    }
}
