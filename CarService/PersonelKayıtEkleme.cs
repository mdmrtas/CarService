using System;
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
    public partial class PersonelKayıtEkleme : Form
    {
        public PersonelKayıtEkleme()
        {
            InitializeComponent();
        }

        // public static SqlConnection Baglanti = new SqlConnection("Data Source=LAPTOP-OJS2NRNS\\SQLEXPRESS01;Initial Catalog=DbOtoBakimServis;Integrated Security=True"); // Bu satırı silin


        private void groupBox1_Enter(object sender, EventArgs e)
        {
            // Bu olay şu anda kullanılmıyor.
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Bu olay şu anda kullanılmıyor.
        }

        private void btnPersonelEkleme_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = SqlBaglanti.BaglantiOlustur(); // Bağlantıyı SqlBaglanti sınıfından alıyoruz.

            try
            {
                if (txtTcKimlik.Text == "" || txtAd.Text == "" || txtTelefon.Text == "" || cmbYetki.Text == "" || txtSifre.Text == "")
                {
                    MessageBox.Show("Lütfen gerekli alanları doldurunuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                SqlCommand komut = new SqlCommand("INSERT INTO Personel (TC, Ad,Soyad, Telefon, Adres, Gorevi, Yetkisi, Maas, Sifre, AktifMi,KullaniciAdi,Mail) VALUES (@TC, @Ad,@Soyad, @Telefon, @Adres, @Gorevi, @Yetkisi, @Maas, @Sifre, @AktifMi,@KullaniciAdi,@Mail)", baglanti);

                komut.Parameters.AddWithValue("@TC", txtTcKimlik.Text);
                komut.Parameters.AddWithValue("@Ad", txtAd.Text);
                komut.Parameters.AddWithValue("@Soyad", txtAd.Text);
                komut.Parameters.AddWithValue("@Telefon", txtTelefon.Text);
                komut.Parameters.AddWithValue("@Adres", rctxtAdres.Text);
                komut.Parameters.AddWithValue("@Gorevi", cmbGorev.Text);
                komut.Parameters.AddWithValue("@Yetkisi", cmbYetki.Text);
                komut.Parameters.AddWithValue("@Maas", txtMaas.Text);
                komut.Parameters.AddWithValue("@Sifre", txtSifre.Text);
                komut.Parameters.AddWithValue("@KullaniciAdi", txtKullaniciAdi.Text);
                komut.Parameters.AddWithValue("@Mail", txtEmail.Text);

                // AktifMi değeri ayarlanıyor
                int aktifMi = 0; // Varsayılan Pasif
                if (radAktif.Checked) // Kontrolü radAktif.Checked üzerinden yapıyoruz.
                    aktifMi = 1;
                else if (radPasif.Checked) // Kontrolü radPasif.Checked üzerinden yapıyoruz.
                    aktifMi = 0;

                komut.Parameters.AddWithValue("@AktifMi", aktifMi);

                komut.ExecuteNonQuery();

                MessageBox.Show("Personel başarıyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close(); // Formu kapatıyoruz
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();
            }
        }
    }
}