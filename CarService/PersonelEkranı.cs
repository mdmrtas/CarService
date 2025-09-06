using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text; // StringBuilder için eklendi
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CarService
{
    public partial class PersonelEkranı : Form
    {
        public PersonelEkranı()
        {
            InitializeComponent();
        }

        // SqlBaglanti sınıfınızın statik bir metot veya özellik ile bağlantı döndürdüğünü varsayıyorum.
        // Örneğin: public static SqlConnection BaglantiOlustur() { ... }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Menü öğesi tıklama olayı
        }

        private void label6_Click(object sender, EventArgs e)
        {
            // Label tıklama olayı
        }

        // Seçilen bakımın BakimID'sini tutacak global bir değişken
        private int _secilenBakimID = -1;
        private int _secilenAracID = -1; // Araç bilgilerini güncellerken kullanmak için

        private void btnBakımEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPlaka.Text))
            {
                MessageBox.Show("Plaka bilgisi girilmelidir!");
                return;
            }

            if (cmbBakimTuru.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bakım türünü seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SqlConnection baglanti = SqlBaglanti.BaglantiOlustur();
            SqlCommand komut = null;

            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                int aracID;

                // 1. Araç var mı kontrol et
                string kontrol = "SELECT AracID FROM AracBilgileri WHERE Plaka = @Plaka";
                komut = new SqlCommand(kontrol, baglanti);
                komut.Parameters.AddWithValue("@Plaka", txtPlaka.Text.Trim());

                object sonuc = komut.ExecuteScalar();

                if (sonuc != null)
                {
                    // Araç zaten kayıtlı
                    aracID = Convert.ToInt32(sonuc);
                }
                else
                {
                    // Araç yoksa ekle
                    string aracEkle = "INSERT INTO AracBilgileri (Plaka, Marka, SasiNo, Kilometre, AracSahipID) " +
                                      "VALUES (@Plaka, @Marka, @SasiNo, @Kilometre, @AracSahipID); SELECT SCOPE_IDENTITY();"; // Yeni eklenen ID'yi döndürmek için

                    komut = new SqlCommand(aracEkle, baglanti);
                    komut.Parameters.AddWithValue("@Plaka", txtPlaka.Text.Trim());
                    komut.Parameters.AddWithValue("@Marka", cmbMarka.Text.Trim()); // Eğer cmbMarka bir ComboBox ise .Text kullanın
                    komut.Parameters.AddWithValue("@SasiNo", txtSasiNumarası.Text.Trim());

                    if (int.TryParse(txtKilometre.Text, out int kilometre))
                    {
                        komut.Parameters.AddWithValue("@Kilometre", kilometre);
                    }
                    else
                    {
                        MessageBox.Show("Kilometre bilgisi geçersiz formatta.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (cmbAracSahip.SelectedValue == null || !int.TryParse(cmbAracSahip.SelectedValue.ToString(), out int aracSahipID))
                    {
                        MessageBox.Show("Lütfen geçerli bir araç sahibi seçiniz.");
                        return;
                    }
                    komut.Parameters.AddWithValue("@AracSahipID", aracSahipID);

                    aracID = Convert.ToInt32(komut.ExecuteScalar()); // Yeni eklenen AracID'yi al
                }

                if (cmbIlgilenenPersonel.SelectedValue == null || !int.TryParse(cmbIlgilenenPersonel.SelectedValue.ToString(), out int personelID))
                {
                    MessageBox.Show("Lütfen geçerli bir personel seçiniz.");
                    return;
                }

                // 3. Bakım kaydını ekle
                string bakimEkle = "INSERT INTO AracBakımKaydı " +
                                   "(AracID, BakimTarihi, TeslimTarihi, BakımTuru, GarantiDurumu, PersonelID, SasiNo, Durum) " +
                                   "VALUES (@AracID, @BakimTarihi, @TeslimTarihi, @BakımTuru, @GarantiDurumu, @PersonelID, @SasiNo, @Durum)";

                komut = new SqlCommand(bakimEkle, baglanti);
                komut.Parameters.AddWithValue("@AracID", aracID);
                komut.Parameters.AddWithValue("@BakimTarihi", dateBakımTarihi.Value.Date);
                komut.Parameters.AddWithValue("@TeslimTarihi", DBNull.Value); // Yeni eklenen kayıtlar başlangıçta tamamlanmamış olacak
                komut.Parameters.AddWithValue("@BakımTuru", cmbBakimTuru.SelectedItem.ToString().Trim());
                komut.Parameters.AddWithValue("@GarantiDurumu", cmbGaranti.SelectedItem?.ToString().Trim() ?? (object)DBNull.Value);
                komut.Parameters.AddWithValue("@PersonelID", personelID);
                komut.Parameters.AddWithValue("@SasiNo", txtSasiNumarası.Text.Trim());
                komut.Parameters.AddWithValue("@Durum", "Beklemede"); // Bakım eklenirken durumu 'Beklemede' olarak ayarla

                komut.ExecuteNonQuery();
                MessageBox.Show("Bakım kaydı başarıyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Form temizleme
                TemizleFormAlanlari();

                // DataGridView'leri güncelle
                BekleyenIslemleriYukle();
                BitenIslemleriYukle(); // Her ihtimale karşı
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata oluştu: " + hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();
            }
        }

        private void TemizleFormAlanlari()
        {
            _secilenBakimID = -1; // Seçili ID'yi sıfırla
            _secilenAracID = -1; // Seçili AracID'yi sıfırla

            txtPlaka.Clear();
            cmbMarka.SelectedIndex = -1;
            txtSasiNumarası.Clear();
            txtKilometre.Clear();
            cmbIlgilenenPersonel.SelectedIndex = -1;
            cmbAracSahip.SelectedIndex = -1;
            cmbBakimTuru.SelectedIndex = -1;
            cmbGaranti.SelectedIndex = -1;
            dateBakımTarihi.Value = DateTime.Now.Date;
            dateTeslimTarihi.Value = DateTime.Now.Date; // Teslim tarihi alanını da temizleyebiliriz
            dateTeslimTarihi.Checked = false; // CheckBox varsa işaretini kaldır

            // Arama/Filtreleme alanlarını da temizle
            txtPlakaAra.Clear();
            cmbMarkaAra.SelectedIndex = -1;
        }

        // *** GÜNCEL METOT: Bekleyen ve Biten İşlemleri Filtreleyerek Yükleme ***
        private void FiltreleVeYukleIslemler(bool isBekleyen, bool applyFilter)
        {
            SqlConnection baglanti = SqlBaglanti.BaglantiOlustur();
            try
            {
                baglanti.Open();

                string baseSorgu = "SELECT B.BakimID, A.AracID, A.Plaka, A.Marka, A.SasiNo, A.Kilometre, " +
                                   "B.BakımTuru, B.BakimTarihi, B.TeslimTarihi, B.GarantiDurumu, B.Durum, " +
                                   "P.PersonelID, P.Ad + ' ' + P.Soyad AS PersonelAdSoyad, " +
                                   "ASB.AracSahipID, ASB.Ad + ' ' + ASB.Soyad AS AracSahipAdSoyad " +
                                   "FROM AracBakımKaydı B " +
                                   "JOIN AracBilgileri A ON A.AracID = B.AracID " +
                                   "JOIN Personel P ON P.PersonelID = B.PersonelID " +
                                   "JOIN AracSahipBilgileri ASB ON ASB.AracSahipID = A.AracSahipID ";

                StringBuilder whereClause = new StringBuilder();
                SqlCommand komut = new SqlCommand();
                komut.Connection = baglanti;

                // Teslim Tarihi veya Durum kriteri
                if (isBekleyen)
                {
                    whereClause.Append(" (B.TeslimTarihi IS NULL OR B.Durum = 'Beklemede')");
                }
                else // Biten işlemler
                {
                    whereClause.Append(" (B.TeslimTarihi IS NOT NULL OR B.Durum = 'Tamamlandı')");
                }

                // Filtreleme uygulanacaksa
                if (applyFilter)
                {
                    // Plaka Filtresi
                    if (!string.IsNullOrWhiteSpace(txtPlakaAra.Text))
                    {
                        if (whereClause.Length > 0) whereClause.Append(" AND ");
                        whereClause.Append(" A.Plaka LIKE @PlakaFiltre ");
                        komut.Parameters.AddWithValue("@PlakaFiltre", "%" + txtPlakaAra.Text.Trim() + "%");
                    }

                    // Marka Filtresi
                    // cmbMarkaArama.SelectedValue'nun null olup olmadığını kontrol edin
                    if (cmbMarkaAra.SelectedValue != null && !string.IsNullOrWhiteSpace(cmbMarkaAra.SelectedValue.ToString()))
                    {
                        if (whereClause.Length > 0) whereClause.Append(" AND ");
                        whereClause.Append(" A.Marka = @MarkaFiltre ");
                        komut.Parameters.AddWithValue("@MarkaFiltre", cmbMarkaAra.SelectedValue.ToString());
                    }
                }

                string finalSorgu = baseSorgu;
                if (whereClause.Length > 0)
                {
                    finalSorgu += " WHERE " + whereClause.ToString();
                }

                komut.CommandText = finalSorgu;
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (isBekleyen)
                {
                    dgvBekleyenIsler.DataSource = dt;
                    GizleDataGridViewSutunlari(dgvBekleyenIsler);
                }
                else
                {
                    dgvBitenIsler.DataSource = dt;
                    GizleDataGridViewSutunlari(dgvBitenIsler);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"İşlemler yüklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();
            }
        }

        // Ortak sütun gizleme metodu
        private void GizleDataGridViewSutunlari(DataGridView dgv)
        {
            if (dgv.Columns.Contains("BakimID")) dgv.Columns["BakimID"].Visible = false;
            if (dgv.Columns.Contains("AracID")) dgv.Columns["AracID"].Visible = false;
            if (dgv.Columns.Contains("PersonelID")) dgv.Columns["PersonelID"].Visible = false;
            if (dgv.Columns.Contains("AracSahipID")) dgv.Columns["AracSahipID"].Visible = false;
            // Diğer gizlemek istediğiniz sütunlar varsa buraya ekleyin
        }

        // Mevcut BekleyenIslemleriYukle ve BitenIslemleriYukle metotlarını basitleştiriyoruz
        private void BekleyenIslemleriYukle()
        {
            FiltreleVeYukleIslemler(true, false); // Filtre uygulamadan tüm bekleyenleri yükle
        }

        private void BitenIslemleriYukle()
        {
            FiltreleVeYukleIslemler(false, false); // Filtre uygulamadan tüm bitenleri yükle
        }   


        private void btnTemizle_Click(object sender, EventArgs e)
        {
            TemizleFormAlanlari();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            // GroupBox enter olayı
        }

        private void PersonelEkranı_Load(object sender, EventArgs e)
        {
            // Form yüklendiğinde personel, araç sahipleri, bakım türleri ve markaları yükle
            YuklePersonel();
            YukleAracSahipleri();
            YukleBakimTurleri(); // Yeni eklendi
            YukleMarkalar();     // Yeni eklendi (hem ana form hem de arama kısmı için)

            // DataGridView olaylarını bağla
            dgvBekleyenIsler.CellClick += dgvBekleyenIsler_CellClick;
            dgvBitenIsler.CellClick += dgvBitenIsler_CellClick;

            // Başlangıçta filtre uygulamadan tüm bekleyen ve biten işlemleri yükle
            FiltreleVeYukleIslemler(true, false); // Bekleyenleri yükle
            FiltreleVeYukleIslemler(false, false); // Bitenleri yükle
        }

        private void YuklePersonel()
        {
            SqlConnection baglanti = SqlBaglanti.BaglantiOlustur();
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("SELECT PersonelID, Ad + ' ' + Soyad AS AdSoyad FROM Personel", baglanti);
                SqlDataAdapter adapter = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                cmbIlgilenenPersonel.DataSource = dt;
                cmbIlgilenenPersonel.DisplayMember = "AdSoyad";
                cmbIlgilenenPersonel.ValueMember = "PersonelID";
                cmbIlgilenenPersonel.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Personel listesi yüklenemedi: " + ex.Message);
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();
            }
        }

        private void YukleAracSahipleri()
        {
            SqlConnection baglanti = SqlBaglanti.BaglantiOlustur();
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand(
                    "SELECT AracSahipID, Ad + ' ' + Soyad AS AdSoyad FROM AracSahipBilgileri",
                    baglanti
                );

                SqlDataAdapter adapter = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                cmbAracSahip.DataSource = dt;
                cmbAracSahip.DisplayMember = "AdSoyad";
                cmbAracSahip.ValueMember = "AracSahipID";
                cmbAracSahip.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Araç sahipleri yüklenemedi: " + ex.Message);
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();
            }
        }

        // *** YENİ: Bakım Türlerini Yükleme Metodu ***
        private void YukleBakimTurleri()
        {
            SqlConnection baglanti = SqlBaglanti.BaglantiOlustur();
            try
            {
                baglanti.Open();
                // Bakım türlerini çeken sorgunuzu buraya yazın.
                // Eğer ayrı bir BakimTurleri tablonuz varsa oradan çekin.
                // Yoksa mevcut kayıtlardan DISTINCT BakımTuru çekebilirsiniz.
                SqlCommand komut = new SqlCommand("SELECT DISTINCT BakımTuru FROM AracBakımKaydı WHERE BakımTuru IS NOT NULL", baglanti);
                SqlDataAdapter adapter = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                cmbBakimTuru.DataSource = dt;
                cmbBakimTuru.DisplayMember = "BakımTuru"; // Sütun adınız
                cmbBakimTuru.ValueMember = "BakımTuru";   // Eğer ID yoksa aynı sütunu kullanın
                cmbBakimTuru.SelectedIndex = -1; // İlk başta boş seçili olsun
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bakım türleri yüklenemedi: " + ex.Message);
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();
            }
        }

        // *** YENİ: Markaları Yükleme Metodu (hem ana form hem arama için) ***
        private void YukleMarkalar()
        {
            SqlConnection baglanti = SqlBaglanti.BaglantiOlustur();
            try
            {
                baglanti.Open();
                // Markaları AracBilgileri tablosundan DISTINCT olarak çekin
                SqlCommand komut = new SqlCommand("SELECT DISTINCT Marka FROM AracBilgileri WHERE Marka IS NOT NULL", baglanti);
                SqlDataAdapter adapter = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // Ana formdaki cmbMarka için
                cmbMarka.DataSource = dt.Copy(); // Kopyasını kullan ki iki ComboBox bağımsız olsun
                cmbMarka.DisplayMember = "Marka";
                cmbMarka.ValueMember = "Marka";
                cmbMarka.SelectedIndex = -1;

                // Arama/Filtreleme kısmındaki cmbMarkaArama için
                cmbMarkaAra.DataSource = dt; // Aynı DataTable'ı kullanabiliriz
                cmbMarkaAra.DisplayMember = "Marka";
                cmbMarkaAra.ValueMember = "Marka";
                cmbMarkaAra.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Marka listesi yüklenemedi: " + ex.Message);
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();
            }
        }

        private void aracSahipBilgiKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AracSahipBilgiEkran frmaracSahipBilgiEkran = new AracSahipBilgiEkran();
            frmaracSahipBilgiEkran.ShowDialog();
            YukleAracSahipleri(); // Yeni araç sahibi eklendiyse listeyi güncelle
        }

        private void btnIslemiTamamla_Click(object sender, EventArgs e)
        {
            if (dgvBekleyenIsler.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen tamamlanacak bir işlem seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dgvBekleyenIsler.SelectedRows[0].Cells["BakimID"].Value == null)
            {
                MessageBox.Show("Seçilen kaydın Bakım ID'si bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int secilenBakimID = Convert.ToInt32(dgvBekleyenIsler.SelectedRows[0].Cells["BakimID"].Value);

            SqlConnection baglanti = SqlBaglanti.BaglantiOlustur();
            SqlCommand komut = null;

            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                string sorgu = "UPDATE AracBakımKaydı SET TeslimTarihi = @TeslimTarihi, Durum = @Durum WHERE BakimID = @BakimID";
                komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@TeslimTarihi", DateTime.Now.Date);
                komut.Parameters.AddWithValue("@Durum", "Tamamlandı");
                komut.Parameters.AddWithValue("@BakimID", secilenBakimID);

                int affectedRows = komut.ExecuteNonQuery();

                if (affectedRows > 0)
                {
                    MessageBox.Show("İşlem başarıyla tamamlandı ve teslim tarihi güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BekleyenIslemleriYukle();
                    BitenIslemleriYukle();
                    TemizleFormAlanlari(); // Tamamlama sonrası form alanlarını temizle
                }
                else
                {
                    MessageBox.Show("İşlem güncellenemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata oluştu: " + hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();
            }
        }

        private void btnBakımSil_Click(object sender, EventArgs e)
        {
            DataGridView selectedDgv = null;
            int selectedBakimID = -1;

            if (tabControl1.SelectedTab.Name == "tabPage1") // TabControl adınız 'tabControl1' ise
            {
                selectedDgv = dgvBekleyenIsler;
            }
            else if (tabControl1.SelectedTab.Name == "tabPage2")
            {
                selectedDgv = dgvBitenIsler;
            }

            if (selectedDgv == null || selectedDgv.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silmek istediğiniz bir işlem seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (selectedDgv.SelectedRows[0].Cells["BakimID"].Value == null)
            {
                MessageBox.Show("Seçilen kaydın Bakım ID'si bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            selectedBakimID = Convert.ToInt32(selectedDgv.SelectedRows[0].Cells["BakimID"].Value);

            DialogResult result = MessageBox.Show("Seçili bakım kaydını silmek istediğinizden emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                SqlConnection baglanti = SqlBaglanti.BaglantiOlustur();
                SqlCommand komut = null;

                try
                {
                    if (baglanti.State == ConnectionState.Closed)
                        baglanti.Open();

                    string sorgu = "DELETE FROM AracBakımKaydı WHERE BakimID = @BakimID";
                    komut = new SqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@BakimID", selectedBakimID);

                    int affectedRows = komut.ExecuteNonQuery();

                    if (affectedRows > 0)
                    {
                        MessageBox.Show("Bakım kaydı başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BekleyenIslemleriYukle();
                        BitenIslemleriYukle();
                        TemizleFormAlanlari(); // Silme sonrası form alanlarını temizle
                    }
                    else
                    {
                        MessageBox.Show("Bakım kaydı silinemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception hata)
                {
                    MessageBox.Show("Hata oluştu: " + hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (baglanti.State == ConnectionState.Open)
                        baglanti.Close();
                }
            }
        }

        // Yeni Eklenen Metotlar ve Olay İşleyicileri

        // DataGridView'de bir hücreye tıklandığında çalışacak olay
        private void dgvBekleyenIsler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Başlık satırına tıklanmaması için kontrol
            if (e.RowIndex >= 0)
            {
                DataGridViewRow secilenSatir = dgvBekleyenIsler.Rows[e.RowIndex];
                VerileriFormaYukle(secilenSatir);
            }
        }

        private void dgvBitenIsler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Başlık satırına tıklanmaması için kontrol
            if (e.RowIndex >= 0)
            {
                DataGridViewRow secilenSatir = dgvBitenIsler.Rows[e.RowIndex];
                VerileriFormaYukle(secilenSatir);
            }
        }

        private void VerileriFormaYukle(DataGridViewRow satir)
        {
            try
            {
                // Global ID değişkenlerini güncelle
                _secilenBakimID = Convert.ToInt32(satir.Cells["BakimID"].Value);
                _secilenAracID = Convert.ToInt32(satir.Cells["AracID"].Value);

                // TextBox'ları doldur
                txtPlaka.Text = satir.Cells["Plaka"].Value?.ToString();
                txtSasiNumarası.Text = satir.Cells["SasiNo"].Value?.ToString();
                txtKilometre.Text = satir.Cells["Kilometre"].Value?.ToString();

                // ComboBox'ları doldur
                // Marka
                // Eğer cmbMarka bir DataTable'a bağlıysa SelectedValue ile atama yapın
                // Aksi takdirde, Items.Contains kontrolü ve Text ataması doğru olabilir
                string markaValue = satir.Cells["Marka"].Value?.ToString();
                if (markaValue != null && cmbMarka.DataSource is DataTable dtMarka)
                {
                    // Eğer ComboBox'ın DataSource'u bir DataTable ise, ValueMember'a göre bulmaya çalışın
                    DataRow[] foundRows = dtMarka.Select($"Marka = '{markaValue.Replace("'", "''")}'");
                    if (foundRows.Length > 0)
                    {
                        cmbMarka.SelectedValue = markaValue;
                    }
                    else
                    {
                        // Listedede yoksa ve ComboBox DropDown ise direkt atama yapın
                        cmbMarka.Text = markaValue;
                    }
                }
                else if (cmbMarka.Items.Contains(markaValue)) // DataSource yoksa veya ItemsCollection kullanılıyorsa
                {
                    cmbMarka.Text = markaValue;
                }
                else
                {
                    cmbMarka.SelectedIndex = -1; // Bulunamazsa boş bırak
                }


                // Bakım Türü
                string bakimTuruValue = satir.Cells["BakımTuru"].Value?.ToString();
                if (bakimTuruValue != null && cmbBakimTuru.DataSource is DataTable dtBakimTuru)
                {
                    DataRow[] foundRows = dtBakimTuru.Select($"BakımTuru = '{bakimTuruValue.Replace("'", "''")}'");
                    if (foundRows.Length > 0)
                    {
                        cmbBakimTuru.SelectedValue = bakimTuruValue;
                    }
                    else
                    {
                        cmbBakimTuru.Text = bakimTuruValue;
                    }
                }
                else if (cmbBakimTuru.Items.Contains(bakimTuruValue))
                {
                    cmbBakimTuru.Text = bakimTuruValue;
                }
                else
                {
                    cmbBakimTuru.SelectedIndex = -1; // Bulunamazsa boş bırak
                }

                // Garanti Durumu
                string garantiDurumuValue = satir.Cells["GarantiDurumu"].Value?.ToString();
                if (garantiDurumuValue != null && cmbGaranti.Items.Contains(garantiDurumuValue))
                {
                    cmbGaranti.Text = garantiDurumuValue;
                }
                else
                {
                    cmbGaranti.SelectedIndex = -1; // Yoksa boş seç
                }

                // Personel
                if (satir.Cells["PersonelID"].Value != DBNull.Value)
                {
                    cmbIlgilenenPersonel.SelectedValue = Convert.ToInt32(satir.Cells["PersonelID"].Value);
                }
                else
                {
                    cmbIlgilenenPersonel.SelectedIndex = -1;
                }

                // Araç Sahip
                if (satir.Cells["AracSahipID"].Value != DBNull.Value)
                {
                    cmbAracSahip.SelectedValue = Convert.ToInt32(satir.Cells["AracSahipID"].Value);
                }
                else
                {
                    cmbAracSahip.SelectedIndex = -1;
                }

                // DateTimePicker'ları doldur
                if (satir.Cells["BakimTarihi"].Value != DBNull.Value)
                {
                    dateBakımTarihi.Value = Convert.ToDateTime(satir.Cells["BakimTarihi"].Value);
                }
                else
                {
                    dateBakımTarihi.Value = DateTime.Now.Date; // Varsayılan değer
                }

                if (satir.Cells["TeslimTarihi"].Value != DBNull.Value)
                {
                    dateTeslimTarihi.Value = Convert.ToDateTime(satir.Cells["TeslimTarihi"].Value);
                    dateTeslimTarihi.Checked = true; // Eğer DateTimePicker'ın ShowCheckBox özelliği varsa işaretle
                }
                else
                {
                    dateTeslimTarihi.Value = DateTime.Now.Date; // Varsayılan değer
                    dateTeslimTarihi.Checked = false; // Eğer DateTimePicker'ın ShowCheckBox özelliği varsa işareti kaldır
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seçilen kayıttaki veriler forma yüklenirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TemizleFormAlanlari(); // Hata durumunda formu temizle
            }
        }

        private void btnBakımGuncelle_Click(object sender, EventArgs e)
        {
            if (_secilenBakimID == -1)
            {
                MessageBox.Show("Lütfen güncellenecek bir bakım kaydı seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPlaka.Text))
            {
                MessageBox.Show("Plaka bilgisi girilmelidir!");
                return;
            }

            if (cmbBakimTuru.SelectedItem == null && cmbBakimTuru.Text == "") // Hem SelectedItem hem de Text boşsa
            {
                MessageBox.Show("Lütfen bakım türünü seçiniz veya giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SqlConnection baglanti = SqlBaglanti.BaglantiOlustur();
            SqlTransaction transaction = null; // İşlem yönetimi için transaction kullanacağız

            try
            {
                baglanti.Open();
                transaction = baglanti.BeginTransaction(); // İşlemi başlat

                // 1. AracBilgileri tablosunu güncelle
                string aracUpdateSorgu = "UPDATE AracBilgileri SET Plaka = @Plaka, Marka = @Marka, SasiNo = @SasiNo, Kilometre = @Kilometre, AracSahipID = @AracSahipID WHERE AracID = @AracID";
                SqlCommand aracKomut = new SqlCommand(aracUpdateSorgu, baglanti, transaction);

                aracKomut.Parameters.AddWithValue("@Plaka", txtPlaka.Text.Trim());
                aracKomut.Parameters.AddWithValue("@Marka", cmbMarka.Text.Trim());
                aracKomut.Parameters.AddWithValue("@SasiNo", txtSasiNumarası.Text.Trim());

                if (int.TryParse(txtKilometre.Text, out int kilometre))
                {
                    aracKomut.Parameters.AddWithValue("@Kilometre", kilometre);
                }
                else
                {
                    MessageBox.Show("Kilometre bilgisi geçersiz formatta.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    transaction.Rollback(); // Hata durumunda işlemi geri al
                    return;
                }

                if (cmbAracSahip.SelectedValue == null || !int.TryParse(cmbAracSahip.SelectedValue.ToString(), out int aracSahipID))
                {
                    MessageBox.Show("Lütfen geçerli bir araç sahibi seçiniz.");
                    transaction.Rollback();
                    return;
                }
                aracKomut.Parameters.AddWithValue("@AracSahipID", aracSahipID);
                aracKomut.Parameters.AddWithValue("@AracID", _secilenAracID); // Daha önce kaydettiğimiz AracID'yi kullan

                aracKomut.ExecuteNonQuery();

                // 2. AracBakımKaydı tablosunu güncelle
                string bakimUpdateSorgu = "UPDATE AracBakımKaydı SET BakimTarihi = @BakimTarihi, TeslimTarihi = @TeslimTarihi, " +
                                           "BakımTuru = @BakımTuru, GarantiDurumu = @GarantiDurumu, PersonelID = @PersonelID, " +
                                           "SasiNo = @SasiNo, Durum = @Durum WHERE BakimID = @BakimID"; // SasiNo ve Durum güncellendi

                SqlCommand bakimKomut = new SqlCommand(bakimUpdateSorgu, baglanti, transaction);

                bakimKomut.Parameters.AddWithValue("@BakimTarihi", dateBakımTarihi.Value.Date);
                // Teslim tarihi için kontrol: eğer DateTimePicker'ın CheckBox'ı işaretli değilse (yani boşsa) DBNull gönder
                if (dateTeslimTarihi.Checked)
                {
                    bakimKomut.Parameters.AddWithValue("@TeslimTarihi", dateTeslimTarihi.Value.Date);
                }
                else
                {
                    bakimKomut.Parameters.AddWithValue("@TeslimTarihi", DBNull.Value);
                }

                bakimKomut.Parameters.AddWithValue("@BakımTuru", cmbBakimTuru.Text.Trim()); // SelectedItem yerine Text'i kullan
                bakimKomut.Parameters.AddWithValue("@GarantiDurumu", cmbGaranti.SelectedItem?.ToString().Trim() ?? (object)DBNull.Value);

                if (cmbIlgilenenPersonel.SelectedValue == null || !int.TryParse(cmbIlgilenenPersonel.SelectedValue.ToString(), out int personelID))
                {
                    MessageBox.Show("Lütfen geçerli bir personel seçiniz.");
                    transaction.Rollback();
                    return;
                }
                bakimKomut.Parameters.AddWithValue("@PersonelID", personelID);
                bakimKomut.Parameters.AddWithValue("@SasiNo", txtSasiNumarası.Text.Trim()); // SasiNo da burada güncellenebilir

                // Durum bilgisini güncelle
                // Eğer teslim tarihi ayarlıysa 'Tamamlandı', değilse 'Beklemede' yapabiliriz.
                string durum = dateTeslimTarihi.Checked ? "Tamamlandı" : "Beklemede";
                bakimKomut.Parameters.AddWithValue("@Durum", durum);

                bakimKomut.Parameters.AddWithValue("@BakimID", _secilenBakimID);

                bakimKomut.ExecuteNonQuery();

                transaction.Commit(); // İşlemi onayla
                MessageBox.Show("Bakım kaydı başarıyla güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                BekleyenIslemleriYukle(); // Listeleri yenile
                BitenIslemleriYukle();
                TemizleFormAlanlari(); // Güncelleme sonrası form alanlarını temizle
            }
            catch (Exception hata)
            {
                if (transaction != null)
                {
                    transaction.Rollback(); // Hata oluşursa işlemi geri al
                }
                MessageBox.Show("Hata oluştu: " + hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();
            }
        }

        // *** GÜNCEL: "Ara" Butonu Click Olayı ***
        private void btnAra_Click(object sender, EventArgs e)
        {
            // Hangi sekme aktifse orayı güncelle
            if (tabControl1.SelectedTab.Name == "tabPage1") // "Bekleyen İşlemler" sekmesi
            {
                FiltreleVeYukleIslemler(true, true); // Bekleyenleri filtreleyerek yükle
            }
            else if (tabControl1.SelectedTab.Name == "tabPage2") // "Biten İşlemler" sekmesi
            {
                FiltreleVeYukleIslemler(false, true); // Bitenleri filtreleyerek yükle
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Personel_Şifre_Giriş girisFormu = new Personel_Şifre_Giriş();
            girisFormu.Show();
            this.Close();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Personel çıkış yapılıyor...");

            Form1 anaForm = new Form1();
            anaForm.Show();
            this.Close();
        
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            // Verileri yeniden yükleme metodunu çağırın (örneğin, bir DataGridView'i doldurma)
            LoadData(); // Bu, veritabanından verileri çekip ilgili kontrolleri dolduran kendi metodunuz olmalı.

            // Giriş alanlarını temizleyin
            ClearInputFields(); // Bu, metin kutuları, açılır listeler gibi giriş alanlarını temizleyen kendi metodunuz olmalı.

            // İsteğe bağlı olarak, kullanıcıya yenilemenin başarılı olduğuna dair bir mesaj gösterebilirsiniz
            // MessageBox.Show("Sayfa yenilendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void LoadData()
        {
            // Burada DataGridView'inizi veya diğer veri gösteren kontrollerinizi veritabanından
            // güncel verilerle doldurma kodunuz olmalı.
            // Örneğin:
            // DataTable dt = GetDataFromDatabase();
            // dataGridview1.DataSource = dt;
        }

        private void ClearInputFields()
        {
            // Buraya formunuzdaki tüm giriş alanlarını temizleyen kodunuzu yazın.
            // Örneğin:
            // txtPlaka.Text = "";
            // cmbMarka.SelectedIndex = -1;
            // txtSasiNumarasi.Text = "";
            // txtKilometre.Text = "";
            // cmbBakimTuru.SelectedIndex = -1;
            // cmbPersonel.SelectedIndex = -1;
            // cmbAracSahip.SelectedIndex = -1;
            // dtpBakimTarihi.Value = DateTime.Now;
            // dtpTeslimTarihi.Value = DateTime.Now;
            // cmbGarantiDurumu.SelectedIndex = -1;
        }

        private void raporlamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RaporlamaEkranPersonal frmEkranRapor = new RaporlamaEkranPersonal();
            frmEkranRapor.ShowDialog();
            this.Hide();
        }
    }
    
}