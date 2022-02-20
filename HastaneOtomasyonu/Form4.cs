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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        string ad, soyad, tc, tel;

        private void btnSil_Click(object sender, EventArgs e)
        {
            lstKulEkle.Items.Remove(lstKulEkle.SelectedIndex);
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            ad = txtAd.Text;
            soyad = txtSoyad.Text;
            tc = txtTc.Text;
            tel = txtTel.Text;
            lstKulEkle.Items.Add(ad+" "+soyad + " " +tc + " " +tel);
        }
    }
}
