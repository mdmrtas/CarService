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
    public partial class AracSahipBilgiEkran : Form
    {
        public AracSahipBilgiEkran()
        {
            InitializeComponent();
        }
        private void VerileriYukle()
        {
            SqlConnection baglanti = SqlBaglanti.BaglantiOlustur();
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                string sorgu = "SELECT AracSahipID, TC, Ad, Soyad, Telefon, EvAdresi, IsAdresi FROM AracSahipBilgileri";
                SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvAracSahipBilgi.DataSource = dt; // DataGridView'e verileri atıyoruz
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veriler yüklenirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();
            }
        }

        private void btnAracSahipEkleme_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = SqlBaglanti.BaglantiOlustur();

            try
            {
                if (txtTcKimlik.Text == "" || txtAd.Text == "" || txtSoyad.Text == "" || txtTelefon.Text == "" || rctxtAdres.Text == "" || rctxtIsAdres.Text == "")
                {
                    MessageBox.Show("Lütfen İlgili Alanları Doldurunuz");
                    return;
                }

                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                SqlCommand komut = new SqlCommand("INSERT INTO AracSahipBilgileri (TC, Ad,Soyad, Telefon,EvAdresi,IsAdresi) Values (@TC,@Ad,@Soyad,@Telefon,@EvAdresi,@IsAdresi)", baglanti);

                komut.Parameters.AddWithValue("@TC", txtTcKimlik.Text);
                komut.Parameters.AddWithValue("@Ad", txtAd.Text);
                komut.Parameters.AddWithValue("@Soyad", txtSoyad.Text);
                komut.Parameters.AddWithValue("@Telefon", txtTelefon.Text);
                komut.Parameters.AddWithValue("@EvAdresi", rctxtAdres.Text);
                komut.Parameters.AddWithValue("@IsAdresi", rctxtIsAdres.Text);


                komut.ExecuteNonQuery();

                MessageBox.Show("Arac Sahip bilgileri  başarıyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                VerileriYukle();
                this.Close(); // Formu kapatıyoruz
                txtTcKimlik.Focus();
            }
            catch (Exception Hata )
            {
                MessageBox.Show("Hata oluştu: " + Hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void AracSahipBilgiEkran_Load(object sender, EventArgs e)
        {
            VerileriYukle();
        }

        private void btnSahipDüzenle_Click(object sender, EventArgs e)
        {
            if (dgvAracSahipBilgi.CurrentRow == null)
            {
                MessageBox.Show("Lütfen düzenlenecek bir kayıt seçin.");
                return;
            }

            SqlConnection baglanti = SqlBaglanti.BaglantiOlustur();

            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                int aracSahipID = Convert.ToInt32(dgvAracSahipBilgi.CurrentRow.Cells["AracSahipID"].Value);

                SqlCommand komut = new SqlCommand("UPDATE AracSahipBilgileri SET TC = @TC, Ad = @Ad, Soyad = @Soyad, Telefon = @Telefon, EvAdresi = @EvAdresi, IsAdresi = @IsAdresi WHERE AracSahipID = @AracSahipID", baglanti);

                komut.Parameters.AddWithValue("@TC", txtTcKimlik.Text);
                komut.Parameters.AddWithValue("@Ad", txtAd.Text);
                komut.Parameters.AddWithValue("@Soyad", txtSoyad.Text);
                komut.Parameters.AddWithValue("@Telefon", txtTelefon.Text);
                komut.Parameters.AddWithValue("@EvAdresi", rctxtAdres.Text);
                komut.Parameters.AddWithValue("@IsAdresi", rctxtIsAdres.Text);
                komut.Parameters.AddWithValue("@AracSahipID", aracSahipID);

                komut.ExecuteNonQuery();

                MessageBox.Show("Kayıt başarıyla güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                VerileriYukle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();
            }
        }

        private void dgvAracSahipBilgi_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvAracSahipBilgi_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAracSahipBilgi.CurrentRow != null)
            {
                DataGridViewRow row = dgvAracSahipBilgi.CurrentRow;

                txtTcKimlik.Text = row.Cells["TC"].Value?.ToString() ?? "";
                txtAd.Text = row.Cells["Ad"].Value?.ToString() ?? "";
                txtSoyad.Text = row.Cells["Soyad"].Value?.ToString() ?? "";
                txtTelefon.Text = row.Cells["Telefon"].Value?.ToString() ?? "";
                rctxtAdres.Text = row.Cells["EvAdresi"].Value?.ToString() ?? "";
                rctxtIsAdres.Text = row.Cells["IsAdresi"].Value?.ToString() ?? "";
            }
        }

        private void btnSahipSil_Click(object sender, EventArgs e)
        {
            if (dgvAracSahipBilgi.CurrentRow == null)
            {
                MessageBox.Show("Lütfen silmek için bir satır seçiniz.");
                return;
            }

            DialogResult onay = MessageBox.Show("Seçili kişiyi silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (onay == DialogResult.No)
                return;

            int seciliID = Convert.ToInt32(dgvAracSahipBilgi.CurrentRow.Cells["AracSahipID"].Value); // ID sütunu olmalı

            SqlConnection baglanti = SqlBaglanti.BaglantiOlustur();

            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                SqlCommand komut = new SqlCommand("DELETE FROM AracSahipBilgileri WHERE AracSahipID = @id", baglanti);
                komut.Parameters.AddWithValue("@id", seciliID);
                komut.ExecuteNonQuery();

                MessageBox.Show("Kayıt başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                VerileriYukle(); // Güncel tabloyu getir
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
}
