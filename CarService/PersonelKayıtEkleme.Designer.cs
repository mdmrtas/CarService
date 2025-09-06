
namespace CarService
{
    partial class PersonelKayıtEkleme
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.txtTcKimlik = new System.Windows.Forms.MaskedTextBox();
            this.rctxtAdres = new System.Windows.Forms.RichTextBox();
            this.radPasif = new System.Windows.Forms.RadioButton();
            this.radAktif = new System.Windows.Forms.RadioButton();
            this.cmbYetki = new System.Windows.Forms.ComboBox();
            this.cmbGorev = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtMaas = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnPersonelEkleme = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.txtTelefon);
            this.groupBox1.Controls.Add(this.txtTcKimlik);
            this.groupBox1.Controls.Add(this.rctxtAdres);
            this.groupBox1.Controls.Add(this.radPasif);
            this.groupBox1.Controls.Add(this.radAktif);
            this.groupBox1.Controls.Add(this.cmbYetki);
            this.groupBox1.Controls.Add(this.cmbGorev);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtMaas);
            this.groupBox1.Controls.Add(this.txtSifre);
            this.groupBox1.Controls.Add(this.txtKullaniciAdi);
            this.groupBox1.Controls.Add(this.txtSoyad);
            this.groupBox1.Controls.Add(this.txtAd);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.btnPersonelEkleme);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(99, 52);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(483, 744);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(245, 252);
            this.txtTelefon.Mask = "(999) 000-0000";
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(157, 30);
            this.txtTelefon.TabIndex = 3;
            // 
            // txtTcKimlik
            // 
            this.txtTcKimlik.Location = new System.Drawing.Point(245, 45);
            this.txtTcKimlik.Mask = "00000000000";
            this.txtTcKimlik.Name = "txtTcKimlik";
            this.txtTcKimlik.Size = new System.Drawing.Size(157, 30);
            this.txtTcKimlik.TabIndex = 0;
            // 
            // rctxtAdres
            // 
            this.rctxtAdres.Location = new System.Drawing.Point(168, 578);
            this.rctxtAdres.Name = "rctxtAdres";
            this.rctxtAdres.Size = new System.Drawing.Size(291, 119);
            this.rctxtAdres.TabIndex = 11;
            this.rctxtAdres.Text = "";
            // 
            // radPasif
            // 
            this.radPasif.AutoSize = true;
            this.radPasif.Location = new System.Drawing.Point(340, 525);
            this.radPasif.Name = "radPasif";
            this.radPasif.Size = new System.Drawing.Size(83, 29);
            this.radPasif.TabIndex = 10;
            this.radPasif.TabStop = true;
            this.radPasif.Text = "Hayır";
            this.radPasif.UseVisualStyleBackColor = true;
            // 
            // radAktif
            // 
            this.radAktif.AutoSize = true;
            this.radAktif.Location = new System.Drawing.Point(245, 525);
            this.radAktif.Name = "radAktif";
            this.radAktif.Size = new System.Drawing.Size(76, 29);
            this.radAktif.TabIndex = 9;
            this.radAktif.TabStop = true;
            this.radAktif.Text = "Evet";
            this.radAktif.UseVisualStyleBackColor = true;
            // 
            // cmbYetki
            // 
            this.cmbYetki.FormattingEnabled = true;
            this.cmbYetki.Items.AddRange(new object[] {
            "Personel Usta",
            "Personel Kalfa",
            "Personel Çırak"});
            this.cmbYetki.Location = new System.Drawing.Point(245, 344);
            this.cmbYetki.Name = "cmbYetki";
            this.cmbYetki.Size = new System.Drawing.Size(157, 33);
            this.cmbYetki.TabIndex = 5;
            // 
            // cmbGorev
            // 
            this.cmbGorev.FormattingEnabled = true;
            this.cmbGorev.Items.AddRange(new object[] {
            "Usta",
            "Kalfa",
            "Çırak"});
            this.cmbGorev.Location = new System.Drawing.Point(245, 299);
            this.cmbGorev.Name = "cmbGorev";
            this.cmbGorev.Size = new System.Drawing.Size(157, 33);
            this.cmbGorev.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(245, 481);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(157, 30);
            this.txtEmail.TabIndex = 8;
            // 
            // txtMaas
            // 
            this.txtMaas.Location = new System.Drawing.Point(245, 435);
            this.txtMaas.Name = "txtMaas";
            this.txtMaas.Size = new System.Drawing.Size(157, 30);
            this.txtMaas.TabIndex = 7;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(245, 387);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(157, 30);
            this.txtSifre.TabIndex = 6;
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(245, 201);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(157, 30);
            this.txtKullaniciAdi.TabIndex = 2;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(245, 98);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(157, 30);
            this.txtAd.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(88, 521);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 25);
            this.label11.TabIndex = 1;
            this.label11.Text = "Aktif/Pasif:";
            // 
            // btnPersonelEkleme
            // 
            this.btnPersonelEkleme.Location = new System.Drawing.Point(18, 619);
            this.btnPersonelEkleme.Name = "btnPersonelEkleme";
            this.btnPersonelEkleme.Size = new System.Drawing.Size(135, 78);
            this.btnPersonelEkleme.TabIndex = 12;
            this.btnPersonelEkleme.Text = "Personel EKLE";
            this.btnPersonelEkleme.UseVisualStyleBackColor = true;
            this.btnPersonelEkleme.Click += new System.EventHandler(this.btnPersonelEkleme_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(86, 484);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 25);
            this.label13.TabIndex = 1;
            this.label13.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 438);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Maaş:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(116, 440);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 25);
            this.label8.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(84, 390);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 25);
            this.label9.TabIndex = 1;
            this.label9.Text = "Şifre:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(84, 344);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 25);
            this.label7.TabIndex = 1;
            this.label7.Text = "Yetki:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(84, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "Görevi:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(86, 581);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 25);
            this.label10.TabIndex = 1;
            this.label10.Text = "Adres:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(84, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Telefon:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(83, 204);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(139, 25);
            this.label12.TabIndex = 1;
            this.label12.Text = "Kullanıcı Adı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "TC Kimlik:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Personel Kayıt Ekleme Menüsü";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(84, 158);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 25);
            this.label14.TabIndex = 1;
            this.label14.Text = "Soyad:";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(245, 153);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(157, 30);
            this.txtSoyad.TabIndex = 1;
            // 
            // PersonelKayıtEkleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(644, 800);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "PersonelKayıtEkleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PersonelKayıtEkleme";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbYetki;
        private System.Windows.Forms.ComboBox cmbGorev;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Button btnPersonelEkleme;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton radPasif;
        private System.Windows.Forms.RadioButton radAktif;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RichTextBox rctxtAdres;
        private System.Windows.Forms.MaskedTextBox txtTcKimlik;
        private System.Windows.Forms.MaskedTextBox txtTelefon;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label14;
    }
}