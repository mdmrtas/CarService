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
using CarService; // << Eğer daha önce eklemediyseniz bu satırı ekleyin

namespace CarService
{
    public partial class PersonelGirisCısıkIslem : Form
    {
        public PersonelGirisCısıkIslem()
        {
            InitializeComponent();

            SqlConnection baglanti = SqlBaglanti.BaglantiOlustur();


            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                // Sorguda 'PersoneLID' kullan
                string sorgu = "SELECT GirisID, PersoneLID, Ad, Soyad, GirisTarihi, CıkısTarihi FROM PersonelGiris"; // <-- Burası değişti!
                SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvPersonelGırısCıkısIslemleri.DataSource = dt;

                dgvPersonelGırısCıkısIslemleri.Columns["GirisID"].HeaderText = "Giriş ID";
                // DataGridView sütun başlığını ayarlarken de 'PersoneLID' kullan
                dgvPersonelGırısCıkısIslemleri.Columns["PersoneLID"].HeaderText = "Personel ID"; // <-- Burası değişti! (Başlık 'ID' yerine daha açıklayıcı 'Personel ID' olabilir.)
                dgvPersonelGırısCıkısIslemleri.Columns["Ad"].HeaderText = "Ad";
                dgvPersonelGırısCıkısIslemleri.Columns["Soyad"].HeaderText = "Soyad";
                dgvPersonelGırısCıkısIslemleri.Columns["GirisTarihi"].HeaderText = "Giriş Tarihi"; // <-- Başlıkları daha okunaklı yapalım
                dgvPersonelGırısCıkısIslemleri.Columns["CıkısTarihi"].HeaderText = "Çıkış Tarihi"; // <-- Başlıkları daha okunaklı yapalım

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

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Hide();
            YöneticiPanel yoneticiPanel = new YöneticiPanel();
            yoneticiPanel.Show();
        }
    }
}