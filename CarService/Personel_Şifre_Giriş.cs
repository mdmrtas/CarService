using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CarService
{
    public partial class Personel_Şifre_Giriş : Form
    {
        public Personel_Şifre_Giriş()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string KullaniciAdi = txtKullanıcıAdi.Text.Trim();
            string Sifre = txtSifre.Text.Trim();

            using (SqlConnection connection = SqlBaglanti.BaglantiOlustur())
            {
                try
                {
                    connection.Open();

                    // Kullanıcı adı ve şifreye ek olarak, PersoneLID, Ad, Soyad bilgilerini de çekelim
                    string sorgu = "SELECT PersoneLID, Ad, Soyad FROM Personel WHERE KullaniciAdi = @KullaniciAdi AND Sifre = @Sifre"; // <-- Burası değişti!
                    using (SqlCommand komut = new SqlCommand(sorgu, connection))
                    {
                        komut.Parameters.AddWithValue("@KullaniciAdi", KullaniciAdi);
                        komut.Parameters.AddWithValue("@Sifre", Sifre);

                        using (SqlDataReader okuyucu = komut.ExecuteReader())
                        {
                            if (okuyucu.Read())
                            {
                                // Personel bilgileri okundu
                                // Tablo adıyla eşleşen 'PersoneLID' sütununu kullan
                                int personelID = okuyucu.GetInt32(okuyucu.GetOrdinal("PersoneLID")); // <-- Burası değişti!
                                string ad = okuyucu.GetString(okuyucu.GetOrdinal("Ad"));
                                string soyad = okuyucu.GetString(okuyucu.GetOrdinal("Soyad"));

                                // Giriş başarılıysa, giriş kaydını PersonelGiris tablosuna ekle
                                KaydetPersonelGiris(personelID, ad, soyad);

                                // Personel Ekranını aç
                                PersonelEkranı ekran = new PersonelEkranı();
                                ekran.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Kullanıcı adı veya şifre hatalı.", "Giriş Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
                catch (Exception Hata)
                {
                    MessageBox.Show("Veritabanı bağlantı hatası: " + Hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                        connection.Close();
                }
            }
        }

        // Yeni metod: Personel girişini veritabanına kaydetmek için
        private void KaydetPersonelGiris(int personelID, string ad, string soyad)
        {
            using (SqlConnection connection = SqlBaglanti.BaglantiOlustur())
            {
                try
                {
                    connection.Open();

                    // Giriş zamanını al
                    DateTime girisZamani = DateTime.Now;

                    // PersonelGiris tablosuna yeni bir kayıt ekle
                    // Sorguda ve parametrede 'PersoneLID' kullan
                    string insertSorgu = "INSERT INTO PersonelGiris (PersoneLID, Ad, Soyad, GirisTarihi, CıkısTarihi) VALUES (@PersoneLID, @Ad, @Soyad, @GirisTarihi, NULL)"; // <-- Burası değişti!
                    using (SqlCommand insertKomut = new SqlCommand(insertSorgu, connection))
                    {
                        insertKomut.Parameters.AddWithValue("@PersoneLID", personelID); // <-- Burası değişti!
                        insertKomut.Parameters.AddWithValue("@Ad", ad);
                        insertKomut.Parameters.AddWithValue("@Soyad", soyad);
                        insertKomut.Parameters.AddWithValue("@GirisTarihi", girisZamani);
                        insertKomut.ExecuteNonQuery();
                    }
                    // MessageBox.Show("Giriş kaydı başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information); // Debug için açabilirsiniz
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Giriş kaydı eklenirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Personel_Şifre_Giriş_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnGiris;
        }

        private void btnPersonelGiris_Click(object sender, EventArgs e)
        {
            // Boş bırakılmış, gerekirse işlem ekleyebilirsin
        }
    }
}