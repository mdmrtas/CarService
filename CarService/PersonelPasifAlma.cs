using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CarService
{
    public partial class PersonelPasifAlma : Form
    {
        public PersonelPasifAlma()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = SqlBaglanti.BaglantiOlustur();

        private void PersonelPasifAlma_Load(object sender, EventArgs e)
        {
            cmbAramaTuru.Items.AddRange(new string[] { "İle Başlayan", "İle Biten", "İçeren" });
            cmbAramaTuru.SelectedIndex = 0;

            AktifPersonelleriListele();
            PasifPersonelleriListele();
        }

        void AktifPersonelleriListele()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT PersonelID, Ad,Soyad, Adres, Telefon, AktifMi FROM Personel WHERE AktifMi = 1", baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dtvAktifPersonel.DataSource = dt;

                dtvAktifPersonel.Columns["PersonelID"].HeaderText = "ID";
                dtvAktifPersonel.Columns["Ad"].HeaderText = "Ad ";
                dtvAktifPersonel.Columns["Soyad"].HeaderText = "Soyad ";
                dtvAktifPersonel.Columns["Telefon"].HeaderText = "Telefon";
                dtvAktifPersonel.Columns["Adres"].HeaderText = "Adres";
                dtvAktifPersonel.Columns["AktifMi"].HeaderText = "Aktif Mi?";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        void PasifPersonelleriListele()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT PersonelID, Ad,Soyad, Adres, Telefon, AktifMi FROM Personel WHERE AktifMi = 0", baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dtvPasifPersonel.DataSource = dt;

                dtvPasifPersonel.Columns["PersonelID"].HeaderText = "ID";
                dtvPasifPersonel.Columns["Ad"].HeaderText = "Ad";
                dtvPasifPersonel.Columns["Soyad"].HeaderText = "Soyad ";
                dtvPasifPersonel.Columns["Telefon"].HeaderText = "Telefon";
                dtvPasifPersonel.Columns["Adres"].HeaderText = "Adres";
                dtvPasifPersonel.Columns["AktifMi"].HeaderText = "Aktif Mi?";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnPasif_Click(object sender, EventArgs e)
        {
            TabPage seciliTab;
            DataGridView seciliDgv;
            if (tabControl1.SelectedTab == tabAktifPersoneller)
            {
                seciliTab = tabAktifPersoneller;
                seciliDgv = dtvAktifPersonel;
            }
            else
            {
                seciliTab = tabAktifPersoneller;
                seciliDgv = dtvPasifPersonel;

            }

            if (seciliDgv.SelectedRows.Count > 0)
            {
                int secilenId;
                if (seciliTab == tabAktifPersoneller)
                {
                   secilenId=  Convert.ToInt32(seciliDgv.SelectedRows[0].Cells["PersonelID"].Value);
                }
                else
                {
                    secilenId = Convert.ToInt32(seciliDgv.SelectedRows[0].Cells["PersonelID"].Value);
                }

                try
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("UPDATE Personel SET AktifMi = 0 WHERE PersonelID = @PersonelID", baglanti);
                    komut.Parameters.AddWithValue("@PersonelID", secilenId);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Personel pasife alındı!");
                    AktifPersonelleriListele();
                    PasifPersonelleriListele();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
                finally
                {
                    if (baglanti.State == ConnectionState.Open)
                        baglanti.Close();
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir personel seçin!");
            }
        }

        private void btnAktf_Click(object sender, EventArgs e)
        {
            TabPage seciliTab;
            DataGridView seciliDgv;

            if (tabControl1.SelectedTab == tabPasifPersoneller)
            {
                seciliTab = tabPasifPersoneller;
                seciliDgv = dtvPasifPersonel;
            }
            else
            {
                seciliTab = tabPasifPersoneller;
                seciliDgv = dtvAktifPersonel;
            }

            if (seciliDgv.SelectedRows.Count > 0)
            {
                int secilenId = Convert.ToInt32(seciliDgv.SelectedRows[0].Cells["PersonelID"].Value);

                try
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("UPDATE Personel SET AktifMi = 1 WHERE PersonelID = @PersonelID", baglanti);
                    komut.Parameters.AddWithValue("@PersonelID", secilenId);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Personel aktife alındı!");
                    AktifPersonelleriListele();
                    PasifPersonelleriListele();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
                finally
                {
                    if (baglanti.State == ConnectionState.Open)
                        baglanti.Close();
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir personel seçin!");
            }
        }

        private void HizliAra()
        {
            try
            {
                string sorgu = "SELECT * FROM Personel WHERE ";
                string aramaKelimesi = txtHizliAra.Text.Trim();

                
                 if (radAdSoyad.Checked)
                {
                    sorgu += "AdiSoyadi ";
                }

                if (cmbAramaTuru.Text == "İle Başlayan")
                    sorgu += "LIKE '" + aramaKelimesi + "%'";
                else if (cmbAramaTuru.Text == "İle Biten")
                    sorgu += "LIKE '%" + aramaKelimesi + "'";
                else if (cmbAramaTuru.Text == "İçeren")
                    sorgu += "LIKE '%" + aramaKelimesi + "%'";

                SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dtvPasifPersonel.DataSource = dt; // Sonuçları göster
            }
            catch (Exception ex)
            {
                MessageBox.Show("Arama hatası: " + ex.Message);
            }
            
        }

        private void txtHizliAra_TextChanged(object sender, EventArgs e)
        {
            HizliAra();
        }

        private void cmbAramaTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            HizliAra();
        }

        private void radAktifMi_CheckedChanged(object sender, EventArgs e)
        {
            HizliAra();
        }

        private void radAdSoyad_CheckedChanged(object sender, EventArgs e)
        {
            HizliAra();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Bu isimler Tasarım ekranında TabPage'lere atanmış olmalı!
            if (tabControl1.SelectedTab == tabAktifPersoneller)
                AktifPersonelleriListele();
            else if (tabControl1.SelectedTab == tabPasifPersoneller)
                PasifPersonelleriListele();
        }
    }
}
