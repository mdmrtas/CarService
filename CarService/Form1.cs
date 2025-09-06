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

namespace CarService
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        public static void BaglantiAc()
        {
            try
            {
                //Veritabanı bağlantısını kontrollü şekilde açar
                if (CarService.SqlBaglanti.BaglantiOlustur().State == ConnectionState.Closed)
                    CarService.SqlBaglanti.BaglantiOlustur().Open();
            }
            catch (Exception Hata)
            {
                //Sistem hata mesajı
                MessageBox.Show(Hata.Message, "Bağlantı Aç Hata Penceresi");
            }
        }


        private void btnPersonelGiris_Click(object sender, EventArgs e)
        {
            Personel_Şifre_Giriş personelGirisForm = new Personel_Şifre_Giriş();
            personelGirisForm.Show();
            this.Hide(); //
        }

        private void btnYoneticiGiris_Click(object sender, EventArgs e)
        {
            Yönetici_Şifre_Giriş yoneticiGirisForm = new Yönetici_Şifre_Giriş();
            yoneticiGirisForm.Show(); // Yeni formu gösterir (mevcut form açık kalır)
             this.Hide(); // İsterseniz mevcut (giriş seçimi) formu gizleyebilirsiniz
        }
    }
}
