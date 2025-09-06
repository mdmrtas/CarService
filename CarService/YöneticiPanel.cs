using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Text; // StringBuilder için eklendi

namespace CarService
{
    public partial class YöneticiPanel : Form
    {
        public YöneticiPanel()
        {
            InitializeComponent();
        }

        private void YöneticiPanel_Load(object sender, EventArgs e)
        {
            PersonelListesiniYukle();
            YukleBakimIslemleri(); // Yeni eklenen bakım işlemleri yükleme metodu
        }

        private void PersonelListesiniYukle()
        {
            SqlConnection baglanti = SqlBaglanti.BaglantiOlustur();
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                string sorgu = "SELECT PersonelID, TC, Ad,Soyad,KullaniciAdi,Sifre, Telefon,Mail,Adres,Gorevi, Yetkisi, Maas, AktifMi FROM Personel";
                SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvPersonelListesi.DataSource = dt;

                dgvPersonelListesi.Columns["PersonelID"].HeaderText = "ID";
                dgvPersonelListesi.Columns["TC"].HeaderText = "TC Kimlik";
                dgvPersonelListesi.Columns["Ad"].HeaderText = "Ad";
                dgvPersonelListesi.Columns["Soyad"].HeaderText = "Soyad";
                dgvPersonelListesi.Columns["Telefon"].HeaderText = "Telefon";
                dgvPersonelListesi.Columns["Adres"].HeaderText = "Adres";
                dgvPersonelListesi.Columns["Mail"].HeaderText = "E-Mail";
                dgvPersonelListesi.Columns["Gorevi"].HeaderText = "Görevi";
                dgvPersonelListesi.Columns["Yetkisi"].HeaderText = "Yetki";
                dgvPersonelListesi.Columns["Maas"].HeaderText = "Maaş";
                dgvPersonelListesi.Columns["KullaniciAdi"].HeaderText = "Kullanıcı Adı";
                dgvPersonelListesi.Columns["Sifre"].HeaderText = "Şifre";
                dgvPersonelListesi.Columns["AktifMi"].HeaderText = "Aktif";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                baglanti.Close();
            }
        }

        // *** YENİ: Bakım İşlemlerini Yükleme Metodu (Yönetici Paneli için) ***
        private void YukleBakimIslemleri()
        {
            SqlConnection baglanti = SqlBaglanti.BaglantiOlustur();
            try
            {
                baglanti.Open();

                string baseSorgu = "SELECT B.BakimID, A.Plaka, A.Marka, A.SasiNo, A.Kilometre, " +
                                   "B.BakımTuru, B.BakimTarihi, B.TeslimTarihi, B.GarantiDurumu, B.Durum, " +
                                   "P.Ad + ' ' + P.Soyad AS PersonelAdSoyad, " +
                                   "ASB.Ad + ' ' + ASB.Soyad AS AracSahipAdSoyad " +
                                   "FROM AracBakımKaydı B " +
                                   "JOIN AracBilgileri A ON A.AracID = B.AracID " +
                                   "JOIN Personel P ON P.PersonelID = B.PersonelID " +
                                   "JOIN AracSahipBilgileri ASB ON ASB.AracSahipID = A.AracSahipID ";

                // Bekleyen İşlemleri Yükle
                SqlCommand komutBekleyen = new SqlCommand(baseSorgu + " WHERE B.Durum = 'Beklemede' OR B.TeslimTarihi IS NULL", baglanti);
                SqlDataAdapter daBekleyen = new SqlDataAdapter(komutBekleyen);
                DataTable dtBekleyen = new DataTable();
                daBekleyen.Fill(dtBekleyen);
                dgvBekleyenIslemler.DataSource = dtBekleyen; // BURADA KENDİ DGVIEW İSİMLERİNİZİ KULLANIN
                GizleYoneticiDataGridViewSutunlari(dgvBekleyenIslemler);


                // Biten İşlemleri Yükle
                SqlCommand komutBiten = new SqlCommand(baseSorgu + " WHERE B.Durum = 'Tamamlandı' OR B.TeslimTarihi IS NOT NULL", baglanti);
                SqlDataAdapter daBiten = new SqlDataAdapter(komutBiten);
                DataTable dtBiten = new DataTable();
                daBiten.Fill(dtBiten);
                dgvBitenIslemler.DataSource = dtBiten; // BURADA KENDİ DGVIEW İSİMLERİNİZİ KULLANIN
                GizleYoneticiDataGridViewSutunlari(dgvBitenIslemler);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Yönetici Paneli bakım işlemleri yüklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();
            }
        }

        // *** YENİ: Yönetici Paneli için Ortak Sütun Gizleme Metodu ***
        private void GizleYoneticiDataGridViewSutunlari(DataGridView dgv)
        {
            if (dgv.Columns.Contains("BakimID")) dgv.Columns["BakimID"].Visible = false;
            if (dgv.Columns.Contains("AracID")) dgv.Columns["AracID"].Visible = false;
            if (dgv.Columns.Contains("PersonelID")) dgv.Columns["PersonelID"].Visible = false;
            if (dgv.Columns.Contains("AracSahipID")) dgv.Columns["AracSahipID"].Visible = false;
            // İhtiyaca göre diğer sütunları gizleyebilirsiniz:
            // if (dgv.Columns.Contains("SasiNo")) dgv.Columns["SasiNo"].Visible = false;
        }

        // Bu metotları artık kaldırdık, çünkü YukleBakimIslemleri() hepsini kapsıyor.
        // private void BekleyenIslemleriYukle() { }
        // private void BitenIslemleriYukle() { }

        private void pesonelEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonelKayıtEkleme personelKayıtEkleme = new PersonelKayıtEkleme();
            // Bu form kapandığında personel listesini yenilemek için FormClosed olayına abone olabilirsiniz.
            personelKayıtEkleme.FormClosed += (s, args) => PersonelListesiniYukle();
            personelKayıtEkleme.Show();
        }

        private void bilgileriGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvPersonelListesi.CurrentRow == null)
            {
                MessageBox.Show("Lütfen güncellenecek bir personel seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            PersonelBilgiGüncelle personelBilgiGuncelle = new PersonelBilgiGüncelle();
            // Try-Catch blokları ile güvenli dönüşümler yapın
            personelBilgiGuncelle.txtPersonalID.Text = dgvPersonelListesi.CurrentRow.Cells["PersonelID"].Value?.ToString();
            personelBilgiGuncelle.txtTcKimlik.Text = dgvPersonelListesi.CurrentRow.Cells["TC"].Value?.ToString();
            personelBilgiGuncelle.txtAd.Text = dgvPersonelListesi.CurrentRow.Cells["Ad"].Value?.ToString();
            personelBilgiGuncelle.txtSoyad.Text = dgvPersonelListesi.CurrentRow.Cells["Soyad"].Value?.ToString();
            personelBilgiGuncelle.txtKullaniciAdi.Text = dgvPersonelListesi.CurrentRow.Cells["KullaniciAdi"].Value?.ToString();
            personelBilgiGuncelle.txtSifre.Text = dgvPersonelListesi.CurrentRow.Cells["Sifre"].Value?.ToString();
            personelBilgiGuncelle.txtTelefon.Text = dgvPersonelListesi.CurrentRow.Cells["Telefon"].Value?.ToString();
            personelBilgiGuncelle.txtEmail.Text = dgvPersonelListesi.CurrentRow.Cells["Mail"].Value?.ToString();
            personelBilgiGuncelle.rctxtAdres.Text = dgvPersonelListesi.CurrentRow.Cells["Adres"].Value?.ToString();
            personelBilgiGuncelle.cmbGorev.Text = dgvPersonelListesi.CurrentRow.Cells["Gorevi"].Value?.ToString();
            personelBilgiGuncelle.cmbYetki.Text = dgvPersonelListesi.CurrentRow.Cells["Yetkisi"].Value?.ToString();
            personelBilgiGuncelle.txtMaas.Text = dgvPersonelListesi.CurrentRow.Cells["Maas"].Value?.ToString();

            // AktifMi sütunu genellikle bool döner, ona göre kontrol edin
            if (dgvPersonelListesi.CurrentRow.Cells["AktifMi"].Value != DBNull.Value)
            {
                bool aktifMi = Convert.ToBoolean(dgvPersonelListesi.CurrentRow.Cells["AktifMi"].Value);
                if (aktifMi)
                    personelBilgiGuncelle.radAktif.Checked = true;
                else
                    personelBilgiGuncelle.radPasif.Checked = true;
            }
            else
            {
                // Varsayılan bir durum atayabilirsiniz veya hata mesajı gösterebilirsiniz
                personelBilgiGuncelle.radAktif.Checked = false;
                personelBilgiGuncelle.radPasif.Checked = false;
            }

            // Bu form kapandığında personel listesini yenilemek için FormClosed olayına abone olun.
            personelBilgiGuncelle.FormClosed += (s, args) => PersonelListesiniYukle();
            personelBilgiGuncelle.Show();
        }

        private void listeyiYenileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonelListesiniYukle(); // Personel listesini yenile
            YukleBakimIslemleri();    // Bakım işlemlerini de yenile
        }

        private void PersonelPasifAlmalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonelPasifAlma personelPasifAlma = new PersonelPasifAlma();
            // Bu form kapandığında personel listesini yenilemek için FormClosed olayına abone olun.
            personelPasifAlma.FormClosed += (s, args) => PersonelListesiniYukle();
            personelPasifAlma.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frmForm = new Form1();
            frmForm.ShowDialog();
           // Application.Exit();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Hakkında frmHakkında = new Hakkında();
            frmHakkında.ShowDialog();
        }

        // *** YENİ: PersonelEkranı ile YöneticiPaneli arasında senkronizasyon için Event handler ***
        // Bu metot, PersonelEkranı'ndan bir değişiklik bildirimi geldiğinde çağrılacak.
        public void OnBakimDurumuDegisti(object sender, EventArgs e)
        {
            YukleBakimIslemleri(); // Bakım işlemlerini yeniden yükle
        }

        // TabControl'un SelectedIndexChanged olayına bu metodu bağlayın.
        // Form tasarımında tabControl1'i seçip Events'ten SelectedIndexChanged olayına çift tıklayarak bu metodu oluşturabilirsiniz.
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Sekmeler arasında geçiş yapıldığında listeleri yenile
            YukleBakimIslemleri();
        }

        private void personelGirisSaatleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            PersonelGirisCısıkIslem personelGirisCısıkIslem = new PersonelGirisCısıkIslem();
            personelGirisCısıkIslem.ShowDialog();
        }

        private void raporlamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rapor frmRaporlama = new Rapor();
             frmRaporlama.ShowDialog();
        }
    }
}