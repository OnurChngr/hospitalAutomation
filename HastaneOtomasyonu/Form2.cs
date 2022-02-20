using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace HastaneOtomasyonu
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection();
        SqlCommand command = new SqlCommand();
        SqlDataReader dr;
        Hasta h = new Hasta();   

        private void btnSil_Click(object sender, EventArgs e)
        {
            lstMuayeneBilgi.Items.Remove(lstMuayeneBilgi.SelectedItem);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglanti.ConnectionString = ConfigurationManager.ConnectionStrings["connect"].ConnectionString;
            baglanti.Open();

            command.CommandText = "insert into hasta values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)";
            command.Parameters.AddWithValue("@p1", h.ad);
            command.Parameters.AddWithValue("@p2", h.soyad);
            command.Parameters.AddWithValue("@p3", h.tc);
            command.Parameters.AddWithValue("@p4", h.hastalik);
            command.Parameters.AddWithValue("@p5", h.sehir);
            command.Parameters.AddWithValue("@p6", h.doktor);
            command.Parameters.AddWithValue("@p7", h.bolum);

            command.Connection = baglanti;
            command.ExecuteNonQuery();

            MessageBox.Show("Kayıt Eklendi");
            baglanti.Close();


            h.ad = txtHastaAd.Text;
            h.soyad=txtHastaSoyad.Text;
            h.tc=txtTc.Text;
            h.hastalik = cmbhastalik.Text;
            h.sehir = cmbSehir.Text;
            h.doktor=cmbDoktor.Text;
            h.bolum=cmbBolum.Text;
            lstMuayeneBilgi.Items.Add(h.ad+" "+h.soyad + " " +h.tc + " " +h.hastalik + " " +h.sehir + " " +h.doktor + " " +h.bolum);

        }
    }
}
