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
//using System.Security.Cryptography;

namespace CarService
{
    public partial class Yönetici_Şifre_Giriş : Form
    {
        public Yönetici_Şifre_Giriş()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {

            string kullaniciAdi = txtKullanıcıAdi.Text;
            string girilenSifre = txtSifre.Text;

            SqlConnection connection = SqlBaglanti.BaglantiOlustur();
            SqlDataReader okuyucu = null;

            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();

                string sorgu = "SELECT * FROM Yöneticiler WHERE KullaniciAdi = @kullaniciAdi AND Sifre = @sifre";
                SqlCommand komut = new SqlCommand(sorgu, connection);
                komut.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
                komut.Parameters.AddWithValue("@sifre", girilenSifre);

                okuyucu = komut.ExecuteReader();

                if (okuyucu.Read())
                {
                    YöneticiPanel yoneticiEkrani = new YöneticiPanel();
                    yoneticiEkrani.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre yanlış!");
                }
            }
            catch (Exception Hata)
            {
                MessageBox.Show("Hata oluştu: " + Hata.Message);
            }
            //➔ Eğer okuyucu nesnesi gerçekten var ve
            //Hala açık ise (IsClosed == false demek), ➔ O zaman okuyucu.Close(); yap ➔ Okuyucuyu kapat.
            finally
            {
                if (okuyucu != null && !okuyucu.IsClosed)
                    okuyucu.Close();

                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        private void Yönetici_Şifre_Giriş_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnGiris;
        }
    }
}