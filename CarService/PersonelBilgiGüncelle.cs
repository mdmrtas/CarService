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
    public partial class PersonelBilgiGüncelle : Form
    {
        public PersonelBilgiGüncelle()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Bu olay şu anda kullanılmıyor.
        }

        
        
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnPersonelGüncelle_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = SqlBaglanti.BaglantiOlustur(); // Bağlantıyı SqlBaglanti sınıfından alıyoruz.

            try
            {
                // Gerekli alan kontrolüne Personel ID'yi de ekleyin
                if (txtKullaniciAdi.Text == "" || txtTcKimlik.Text == "" || txtAd.Text == "" ||
                    txtTelefon.Text == "" || cmbYetki.Text == "" || txtSifre.Text == "")
                {
                    MessageBox.Show("Lütfen gerekli alanları doldurunuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                // SQL sorgusu: Personel bilgilerini güncelle
                string bilguncelle = "UPDATE PERSONEL SET TC=@TC ,Ad=@Ad, Soyad=@Soyad, KullaniciAdi = @KullaniciAdi ,Sifre = @Sifre , Telefon = @Telefon , Mail = @Mail , Adres = @Adres, Gorevi = @Gorevi , Yetkisi = @Yetkisi, Maas = @Maas, AktifMi = @AktifMi   WHERE PersonelID = @PersonelID";

                SqlCommand degistir = new SqlCommand(bilguncelle, baglanti);
                degistir.Parameters.AddWithValue("@TC", txtTcKimlik.Text);
                degistir.Parameters.AddWithValue("@Ad", txtAd.Text);
                degistir.Parameters.AddWithValue("@Soyad", txtSoyad.Text);
                degistir.Parameters.AddWithValue("@KullaniciAdi", txtKullaniciAdi.Text);
                degistir.Parameters.AddWithValue("@Sifre", txtSifre.Text);
                degistir.Parameters.AddWithValue("@Telefon", txtTelefon.Text);
                degistir.Parameters.AddWithValue("@Mail", txtEmail.Text);
                degistir.Parameters.AddWithValue("@Adres", rctxtAdres.Text);
                degistir.Parameters.AddWithValue("@Gorevi", cmbGorev.Text);
                degistir.Parameters.AddWithValue("@Yetkisi", cmbYetki.Text);
                degistir.Parameters.AddWithValue("@Maas", txtMaas.Text.Replace(',','.'));
                degistir.Parameters.AddWithValue("@PersonelID", txtPersonalID.Text);

                // AktifMi kontrolü
                int aktifMi = radAktif.Checked ? 1 : 0;
                degistir.Parameters.AddWithValue("@AktifMi", aktifMi);

                degistir.ExecuteNonQuery();

                MessageBox.Show("Personel bilgileri güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (IndexOutOfRangeException ex)
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