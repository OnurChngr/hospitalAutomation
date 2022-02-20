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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGiriş_Click(object sender, EventArgs e)
        {
            string kulad, sifre;
            kulad = txtkulad.Text;
            sifre = txtsifre.Text;
            if (kulad=="onur cihangir"&&sifre=="1234")
            {
                Form2 form2 = new Form2();
                form2.Show();
            }
            

           else if (kulad=="nilay ünsal"&&sifre=="12345")
            {
                Form3 form3 = new Form3();
                form3.Show();

            }
            else
            {
                MessageBox.Show("Girmiş olduğunuz kullanıcı adı veya şifre yanlıştır.Lütfen tekrar deneyiniz!!");
            }
        }
    }
}
